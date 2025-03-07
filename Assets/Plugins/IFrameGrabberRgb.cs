/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IFrameGrabberRgb : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IFrameGrabberRgb(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IFrameGrabberRgb obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IFrameGrabberRgb() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IFrameGrabberRgb(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool getRgbBuffer(System.IntPtr buffer) {
    bool ret = yarpPINVOKE.IFrameGrabberRgb_getRgbBuffer(swigCPtr, buffer);
    return ret;
  }

  public virtual int height() {
    int ret = yarpPINVOKE.IFrameGrabberRgb_height(swigCPtr);
    return ret;
  }

  public virtual int width() {
    int ret = yarpPINVOKE.IFrameGrabberRgb_width(swigCPtr);
    return ret;
  }

}
