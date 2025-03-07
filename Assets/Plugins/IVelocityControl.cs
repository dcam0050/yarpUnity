/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IVelocityControl : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IVelocityControl(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IVelocityControl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IVelocityControl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IVelocityControl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxes(SWIGTYPE_p_int axes) {
    bool ret = yarpPINVOKE.IVelocityControl_getAxes__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(axes));
    return ret;
  }

  public virtual bool setVelocityMode() {
    bool ret = yarpPINVOKE.IVelocityControl_setVelocityMode(swigCPtr);
    return ret;
  }

  public virtual bool velocityMove(int j, double sp) {
    bool ret = yarpPINVOKE.IVelocityControl_velocityMove__SWIG_0(swigCPtr, j, sp);
    return ret;
  }

  public virtual bool velocityMove(SWIGTYPE_p_double sp) {
    bool ret = yarpPINVOKE.IVelocityControl_velocityMove__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(sp));
    return ret;
  }

  public virtual bool setRefAcceleration(int j, double acc) {
    bool ret = yarpPINVOKE.IVelocityControl_setRefAcceleration(swigCPtr, j, acc);
    return ret;
  }

  public virtual bool setRefAccelerations(SWIGTYPE_p_double accs) {
    bool ret = yarpPINVOKE.IVelocityControl_setRefAccelerations__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(accs));
    return ret;
  }

  public virtual bool getRefAcceleration(int j, SWIGTYPE_p_double acc) {
    bool ret = yarpPINVOKE.IVelocityControl_getRefAcceleration__SWIG_0(swigCPtr, j, SWIGTYPE_p_double.getCPtr(acc));
    return ret;
  }

  public virtual bool getRefAccelerations(SWIGTYPE_p_double accs) {
    bool ret = yarpPINVOKE.IVelocityControl_getRefAccelerations__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(accs));
    return ret;
  }

  public virtual bool stop(int j) {
    bool ret = yarpPINVOKE.IVelocityControl_stop__SWIG_0(swigCPtr, j);
    return ret;
  }

  public virtual bool stop() {
    bool ret = yarpPINVOKE.IVelocityControl_stop__SWIG_1(swigCPtr);
    return ret;
  }

  public int getAxes() {
    int ret = yarpPINVOKE.IVelocityControl_getAxes__SWIG_1(swigCPtr);
    return ret;
  }

  public bool velocityMove(DVector data) {
    bool ret = yarpPINVOKE.IVelocityControl_velocityMove__SWIG_2(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setRefAccelerations(DVector data) {
    bool ret = yarpPINVOKE.IVelocityControl_setRefAccelerations__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getRefAcceleration(int j, DVector data) {
    bool ret = yarpPINVOKE.IVelocityControl_getRefAcceleration__SWIG_1(swigCPtr, j, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getRefAccelerations(DVector data) {
    bool ret = yarpPINVOKE.IVelocityControl_getRefAccelerations__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
