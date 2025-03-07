/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ImageFloat : Image {
  private HandleRef swigCPtr;

  internal ImageFloat(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.ImageFloat_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ImageFloat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ImageFloat() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ImageFloat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override int getPixelSize() {
    int ret = yarpPINVOKE.ImageFloat_getPixelSize(swigCPtr);
    return ret;
  }

  public override int getPixelCode() {
    int ret = yarpPINVOKE.ImageFloat_getPixelCode(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_float pixel(int x, int y) {
    SWIGTYPE_p_float ret = new SWIGTYPE_p_float(yarpPINVOKE.ImageFloat_pixel(swigCPtr, x, y), false);
    return ret;
  }

  public SWIGTYPE_p_float access(int x, int y) {
    SWIGTYPE_p_float ret = new SWIGTYPE_p_float(yarpPINVOKE.ImageFloat_access(swigCPtr, x, y), false);
    return ret;
  }

  public SWIGTYPE_p_float safePixel(int x, int y) {
    SWIGTYPE_p_float ret = new SWIGTYPE_p_float(yarpPINVOKE.ImageFloat_safePixel__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

  public float getPixel(int x, int y) {
    float ret = yarpPINVOKE.ImageFloat_getPixel(swigCPtr, x, y);
    return ret;
  }

  public void setPixel(int x, int y, float v) {
    yarpPINVOKE.ImageFloat_setPixel(swigCPtr, x, y, v);
  }

  public ImageFloat() : this(yarpPINVOKE.new_ImageFloat(), true) {
  }

}
