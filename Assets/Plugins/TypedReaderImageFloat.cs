/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TypedReaderImageFloat : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderImageFloat(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TypedReaderImageFloat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderImageFloat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderImageFloat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.TypedReaderImageFloat_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.TypedReaderImageFloat_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageFloat read(bool shouldWait) {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageFloat_read__SWIG_0(swigCPtr, shouldWait);
    ImageFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageFloat(cPtr, false);
    return ret;
  }

  public new ImageFloat read() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageFloat_read__SWIG_1(swigCPtr);
    ImageFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageFloat(cPtr, false);
    return ret;
  }

  public virtual void interrupt() {
    yarpPINVOKE.TypedReaderImageFloat_interrupt(swigCPtr);
  }

  public new ImageFloat lastRead() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageFloat_lastRead(swigCPtr);
    ImageFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageFloat(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.TypedReaderImageFloat_isClosed(swigCPtr);
    return ret;
  }

  public new void useCallback(TypedReaderCallbackImageFloat callback) {
    yarpPINVOKE.TypedReaderImageFloat_useCallback(swigCPtr, TypedReaderCallbackImageFloat.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void disableCallback() {
    yarpPINVOKE.TypedReaderImageFloat_disableCallback(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.TypedReaderImageFloat_getPendingReads(swigCPtr);
    return ret;
  }

  public virtual string getName() {
    string ret = yarpPINVOKE.TypedReaderImageFloat_getName(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.TypedReaderImageFloat_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual System.IntPtr acquire() { return yarpPINVOKE.TypedReaderImageFloat_acquire(swigCPtr); }

  public virtual void release(System.IntPtr handle) {
    yarpPINVOKE.TypedReaderImageFloat_release(swigCPtr, handle);
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.TypedReaderImageFloat_setTargetPeriod(swigCPtr, period);
  }

}
