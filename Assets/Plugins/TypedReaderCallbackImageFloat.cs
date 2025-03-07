/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TypedReaderCallbackImageFloat : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderCallbackImageFloat(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TypedReaderCallbackImageFloat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderCallbackImageFloat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderCallbackImageFloat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new void onRead(ImageFloat datum) {
    yarpPINVOKE.TypedReaderCallbackImageFloat_onRead__SWIG_0(swigCPtr, ImageFloat.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageFloat datum, TypedReaderImageFloat reader) {
    yarpPINVOKE.TypedReaderCallbackImageFloat_onRead__SWIG_1(swigCPtr, ImageFloat.getCPtr(datum), TypedReaderImageFloat.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypedReaderCallbackImageFloat() : this(yarpPINVOKE.new_TypedReaderCallbackImageFloat(), true) {
  }

}
