﻿using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

public class yarpReceiveImage : MonoBehaviour {
	
	private BufferedPortImageRgb inputImagePort;
	public string inputPortName;
	public string sourcePortName;
	
	YarpImageCheck checkImageThread;
	
	private Texture2D image2DTex; 
	public GameObject plane;
	private Renderer planeRender;
	private bool checkInit;

	// Use this for initialization
	void Start () {
		Network.init();
		if(sourcePortName != null)
		{
			inputImagePort = new BufferedPortImageRgb();
			bool open = inputImagePort.open (inputPortName);
			Debug.Log ("Port opened: " + open);
			Network.connect(sourcePortName, inputPortName);
			
			checkImageThread = new YarpImageCheck();
			checkImageThread.imagePort = inputImagePort;
			checkImageThread.Start();
			checkInit = checkImageThread.InitVariables();
			Debug.Log(checkImageThread.iters);
			if(checkInit)
			{
				Debug.Log("Initialised Correctly");
				image2DTex = new Texture2D(checkImageThread.resWidth,checkImageThread.resHeight,TextureFormat.ARGB32, false);
				image2DTex.wrapMode = TextureWrapMode.Clamp;
				
				planeRender = plane.GetComponent<Renderer>();
			}
			else
			{
				Debug.Log("Could not initialise resolution. No images received");
			}
		}
		else
		{
			Debug.Log("Please specify a source port");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if (checkImageThread != null && checkInit)
		{
			if (checkImageThread.imageReceived)
			{
				Debug.Log ("Image Received");

				image2DTex.SetPixels32(checkImageThread.colorArray);
				image2DTex.Apply();
				planeRender.material.mainTexture = image2DTex;
				
				checkImageThread.imageReceived = false;
				checkImageThread.Start();
			}
			else
			{
				Debug.Log("No image yet");
			}
		}
	}
	
	void OnApplicationQuit() {
		if (checkImageThread != null) 
		{
			Debug.Log ("Closing Thread");
		}
	}
}

public class YarpImageCheck : ThreadedJob
{
	public bool imageReceived, init=false;
	public BufferedPortImageRgb imagePort;
	private ImageRgb inputImage;
	public int resWidth;
	public int resHeight;
	public Color32[] colorArray;
	public int iters;

	public bool InitVariables()
	{
		iters = 0;
		init = false;
		//loop to check first image to set resolution of texture
		while(!init) //put in failsafe limiting number of iterations or use ienumerator class
		{
			if (imageReceived)
			{
				resWidth = inputImage.width();
				resHeight = inputImage.height();
				init = true;
			}
			iters++;

			if (iters > 100) {
				break;
			}
			System.Threading.Thread.Sleep(100);
		}
		return init;
	}

	protected override void ThreadFunction()
	{
		inputImage = imagePort.read();
		if(inputImage != null)
		{
			convertToTexture2D();

			imageReceived = true;
		}
	}

	private void convertToTexture2D()
	{
		System.IntPtr imagePtr = inputImage.getRawImage();
		int imageSize = inputImage.getRawImageSize();

		byte[] byteArray = new byte[imageSize];
		Marshal.Copy(imagePtr, byteArray, 0, imageSize);

		byte R,G,B,A;
		colorArray = new Color32[imageSize/3];
		for(int i = 0; i < imageSize ; i+=3)
		{	
			R = byteArray [i + 0];
			G = byteArray [i + 1];
			B = byteArray [i + 2];

			if(R<10 && G<10 && B<10)
			{
				A = 0;
			}
			else
			{
				A = 255;
			}

			Color32 color = new Color32(R, G, B, A);
			colorArray[i/3] = color;
		}
	}
}



