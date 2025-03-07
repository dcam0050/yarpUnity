/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IAxisInfoRaw : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IAxisInfoRaw(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IAxisInfoRaw obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IAxisInfoRaw() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IAxisInfoRaw(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxisNameRaw(int axis, SWIGTYPE_p_std__string name) {
    bool ret = yarpPINVOKE.IAxisInfoRaw_getAxisNameRaw(swigCPtr, axis, SWIGTYPE_p_std__string.getCPtr(name));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getJointTypeRaw(int axis, SWIGTYPE_p_yarp__dev__JointTypeEnum type) {
    bool ret = yarpPINVOKE.IAxisInfoRaw_getJointTypeRaw(swigCPtr, axis, SWIGTYPE_p_yarp__dev__JointTypeEnum.getCPtr(type));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
