/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IPositionControl : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IPositionControl(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IPositionControl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IPositionControl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IPositionControl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxes(SWIGTYPE_p_int ax) {
    bool ret = yarpPINVOKE.IPositionControl_getAxes__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(ax));
    return ret;
  }

  public virtual bool setPositionMode() {
    bool ret = yarpPINVOKE.IPositionControl_setPositionMode(swigCPtr);
    return ret;
  }

  public virtual bool positionMove(int j, double arg1) {
    bool ret = yarpPINVOKE.IPositionControl_positionMove__SWIG_0(swigCPtr, j, arg1);
    return ret;
  }

  public virtual bool positionMove(SWIGTYPE_p_double refs) {
    bool ret = yarpPINVOKE.IPositionControl_positionMove__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(refs));
    return ret;
  }

  public virtual bool relativeMove(int j, double delta) {
    bool ret = yarpPINVOKE.IPositionControl_relativeMove__SWIG_0(swigCPtr, j, delta);
    return ret;
  }

  public virtual bool relativeMove(SWIGTYPE_p_double deltas) {
    bool ret = yarpPINVOKE.IPositionControl_relativeMove__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(deltas));
    return ret;
  }

  public virtual bool checkMotionDone(int j, SWIGTYPE_p_bool flag) {
    bool ret = yarpPINVOKE.IPositionControl_checkMotionDone__SWIG_0(swigCPtr, j, SWIGTYPE_p_bool.getCPtr(flag));
    return ret;
  }

  public virtual bool checkMotionDone(SWIGTYPE_p_bool flag) {
    bool ret = yarpPINVOKE.IPositionControl_checkMotionDone__SWIG_1(swigCPtr, SWIGTYPE_p_bool.getCPtr(flag));
    return ret;
  }

  public virtual bool setRefSpeed(int j, double sp) {
    bool ret = yarpPINVOKE.IPositionControl_setRefSpeed(swigCPtr, j, sp);
    return ret;
  }

  public virtual bool setRefSpeeds(SWIGTYPE_p_double spds) {
    bool ret = yarpPINVOKE.IPositionControl_setRefSpeeds__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(spds));
    return ret;
  }

  public virtual bool setRefAcceleration(int j, double acc) {
    bool ret = yarpPINVOKE.IPositionControl_setRefAcceleration(swigCPtr, j, acc);
    return ret;
  }

  public virtual bool setRefAccelerations(SWIGTYPE_p_double accs) {
    bool ret = yarpPINVOKE.IPositionControl_setRefAccelerations(swigCPtr, SWIGTYPE_p_double.getCPtr(accs));
    return ret;
  }

  public virtual bool getRefSpeed(int j, SWIGTYPE_p_double arg1) {
    bool ret = yarpPINVOKE.IPositionControl_getRefSpeed__SWIG_0(swigCPtr, j, SWIGTYPE_p_double.getCPtr(arg1));
    return ret;
  }

  public virtual bool getRefSpeeds(SWIGTYPE_p_double spds) {
    bool ret = yarpPINVOKE.IPositionControl_getRefSpeeds__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(spds));
    return ret;
  }

  public virtual bool getRefAcceleration(int j, SWIGTYPE_p_double acc) {
    bool ret = yarpPINVOKE.IPositionControl_getRefAcceleration__SWIG_0(swigCPtr, j, SWIGTYPE_p_double.getCPtr(acc));
    return ret;
  }

  public virtual bool getRefAccelerations(SWIGTYPE_p_double accs) {
    bool ret = yarpPINVOKE.IPositionControl_getRefAccelerations__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(accs));
    return ret;
  }

  public virtual bool stop(int j) {
    bool ret = yarpPINVOKE.IPositionControl_stop__SWIG_0(swigCPtr, j);
    return ret;
  }

  public virtual bool stop() {
    bool ret = yarpPINVOKE.IPositionControl_stop__SWIG_1(swigCPtr);
    return ret;
  }

  public int getAxes() {
    int ret = yarpPINVOKE.IPositionControl_getAxes__SWIG_1(swigCPtr);
    return ret;
  }

  public bool positionMove(DVector data) {
    bool ret = yarpPINVOKE.IPositionControl_positionMove__SWIG_2(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool relativeMove(DVector data) {
    bool ret = yarpPINVOKE.IPositionControl_relativeMove__SWIG_2(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setRefSpeeds(DVector data) {
    bool ret = yarpPINVOKE.IPositionControl_setRefSpeeds__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getRefSpeed(int j, DVector data) {
    bool ret = yarpPINVOKE.IPositionControl_getRefSpeed__SWIG_1(swigCPtr, j, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getRefSpeeds(DVector data) {
    bool ret = yarpPINVOKE.IPositionControl_getRefSpeeds__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getRefAcceleration(int j, DVector data) {
    bool ret = yarpPINVOKE.IPositionControl_getRefAcceleration__SWIG_1(swigCPtr, j, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getRefAccelerations(DVector data) {
    bool ret = yarpPINVOKE.IPositionControl_getRefAccelerations__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool checkMotionDone() {
    bool ret = yarpPINVOKE.IPositionControl_checkMotionDone__SWIG_2(swigCPtr);
    return ret;
  }

  public bool checkMotionDone(BVector flag) {
    bool ret = yarpPINVOKE.IPositionControl_checkMotionDone__SWIG_3(swigCPtr, BVector.getCPtr(flag));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool checkMotionDone(int i, BVector flag) {
    bool ret = yarpPINVOKE.IPositionControl_checkMotionDone__SWIG_4(swigCPtr, i, BVector.getCPtr(flag));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isMotionDone(int i) {
    bool ret = yarpPINVOKE.IPositionControl_isMotionDone__SWIG_0(swigCPtr, i);
    return ret;
  }

  public bool isMotionDone() {
    bool ret = yarpPINVOKE.IPositionControl_isMotionDone__SWIG_1(swigCPtr);
    return ret;
  }

}
