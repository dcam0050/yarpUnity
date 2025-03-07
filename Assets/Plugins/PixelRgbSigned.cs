/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PixelRgbSigned : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PixelRgbSigned(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PixelRgbSigned obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PixelRgbSigned() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PixelRgbSigned(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public char r {
    set {
      yarpPINVOKE.PixelRgbSigned_r_set(swigCPtr, value);
    } 
    get {
      char ret = yarpPINVOKE.PixelRgbSigned_r_get(swigCPtr);
      return ret;
    } 
  }

  public char g {
    set {
      yarpPINVOKE.PixelRgbSigned_g_set(swigCPtr, value);
    } 
    get {
      char ret = yarpPINVOKE.PixelRgbSigned_g_get(swigCPtr);
      return ret;
    } 
  }

  public char b {
    set {
      yarpPINVOKE.PixelRgbSigned_b_set(swigCPtr, value);
    } 
    get {
      char ret = yarpPINVOKE.PixelRgbSigned_b_get(swigCPtr);
      return ret;
    } 
  }

  public PixelRgbSigned() : this(yarpPINVOKE.new_PixelRgbSigned(), true) {
  }

}
