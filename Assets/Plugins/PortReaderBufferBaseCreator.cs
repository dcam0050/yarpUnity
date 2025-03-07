/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PortReaderBufferBaseCreator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PortReaderBufferBaseCreator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PortReaderBufferBaseCreator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PortReaderBufferBaseCreator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PortReaderBufferBaseCreator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual PortReader create() {
    IntPtr cPtr = yarpPINVOKE.PortReaderBufferBaseCreator_create(swigCPtr);
    PortReader ret = (cPtr == IntPtr.Zero) ? null : new PortReader(cPtr, false);
    return ret;
  }

}
