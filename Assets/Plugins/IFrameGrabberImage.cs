/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IFrameGrabberImage : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IFrameGrabberImage(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IFrameGrabberImage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IFrameGrabberImage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IFrameGrabberImage(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool getImage(ImageRgb image) {
    bool ret = yarpPINVOKE.IFrameGrabberImage_getImage(swigCPtr, ImageRgb.getCPtr(image));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int height() {
    int ret = yarpPINVOKE.IFrameGrabberImage_height(swigCPtr);
    return ret;
  }

  public virtual int width() {
    int ret = yarpPINVOKE.IFrameGrabberImage_width(swigCPtr);
    return ret;
  }

}
