/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ITorqueControlRaw : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITorqueControlRaw(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ITorqueControlRaw obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITorqueControlRaw() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ITorqueControlRaw(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool getAxes(SWIGTYPE_p_int ax) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getAxes(swigCPtr, SWIGTYPE_p_int.getCPtr(ax));
    return ret;
  }

  public virtual bool setTorqueModeRaw() {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setTorqueModeRaw(swigCPtr);
    return ret;
  }

  public virtual bool getTorqueRaw(int j, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getTorquesRaw(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorquesRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getTorqueRangeRaw(int j, SWIGTYPE_p_double min, SWIGTYPE_p_double max) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueRangeRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(min), SWIGTYPE_p_double.getCPtr(max));
    return ret;
  }

  public virtual bool getTorqueRangesRaw(SWIGTYPE_p_double min, SWIGTYPE_p_double max) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueRangesRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(min), SWIGTYPE_p_double.getCPtr(max));
    return ret;
  }

  public virtual bool setRefTorquesRaw(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setRefTorquesRaw__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool setRefTorqueRaw(int j, double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setRefTorqueRaw(swigCPtr, j, t);
    return ret;
  }

  public virtual bool setRefTorquesRaw(int n_joint, SWIGTYPE_p_int joints, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setRefTorquesRaw__SWIG_1(swigCPtr, n_joint, SWIGTYPE_p_int.getCPtr(joints), SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getRefTorquesRaw(SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getRefTorquesRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getRefTorqueRaw(int j, SWIGTYPE_p_double t) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getRefTorqueRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(t));
    return ret;
  }

  public virtual bool getBemfParamRaw(int j, SWIGTYPE_p_double bemf) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getBemfParamRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(bemf));
    return ret;
  }

  public virtual bool setBemfParamRaw(int j, double bemf) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setBemfParamRaw(swigCPtr, j, bemf);
    return ret;
  }

  public virtual bool getMotorTorqueParamsRaw(int j, MotorTorqueParameters arg1) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getMotorTorqueParamsRaw(swigCPtr, j, MotorTorqueParameters.getCPtr(arg1));
    return ret;
  }

  public virtual bool setMotorTorqueParamsRaw(int j, MotorTorqueParameters arg1) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setMotorTorqueParamsRaw(swigCPtr, j, MotorTorqueParameters.getCPtr(arg1));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool setTorquePidRaw(int j, Pid pid) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setTorquePidRaw(swigCPtr, j, Pid.getCPtr(pid));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool setTorquePidsRaw(Pid pids) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setTorquePidsRaw(swigCPtr, Pid.getCPtr(pids));
    return ret;
  }

  public virtual bool setTorqueErrorLimitRaw(int j, double limit) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setTorqueErrorLimitRaw(swigCPtr, j, limit);
    return ret;
  }

  public virtual bool setTorqueErrorLimitsRaw(SWIGTYPE_p_double limits) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setTorqueErrorLimitsRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(limits));
    return ret;
  }

  public virtual bool getTorqueErrorRaw(int j, SWIGTYPE_p_double err) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueErrorRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(err));
    return ret;
  }

  public virtual bool getTorqueErrorsRaw(SWIGTYPE_p_double errs) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueErrorsRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(errs));
    return ret;
  }

  public virtual bool getTorquePidOutputRaw(int j, SWIGTYPE_p_double arg1) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorquePidOutputRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(arg1));
    return ret;
  }

  public virtual bool getTorquePidOutputsRaw(SWIGTYPE_p_double outs) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorquePidOutputsRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(outs));
    return ret;
  }

  public virtual bool getTorquePidRaw(int j, Pid pid) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorquePidRaw(swigCPtr, j, Pid.getCPtr(pid));
    return ret;
  }

  public virtual bool getTorquePidsRaw(Pid pids) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorquePidsRaw(swigCPtr, Pid.getCPtr(pids));
    return ret;
  }

  public virtual bool getTorqueErrorLimitRaw(int j, SWIGTYPE_p_double limit) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueErrorLimitRaw(swigCPtr, j, SWIGTYPE_p_double.getCPtr(limit));
    return ret;
  }

  public virtual bool getTorqueErrorLimitsRaw(SWIGTYPE_p_double limits) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_getTorqueErrorLimitsRaw(swigCPtr, SWIGTYPE_p_double.getCPtr(limits));
    return ret;
  }

  public virtual bool resetTorquePidRaw(int j) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_resetTorquePidRaw(swigCPtr, j);
    return ret;
  }

  public virtual bool disableTorquePidRaw(int j) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_disableTorquePidRaw(swigCPtr, j);
    return ret;
  }

  public virtual bool enableTorquePidRaw(int j) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_enableTorquePidRaw(swigCPtr, j);
    return ret;
  }

  public virtual bool setTorqueOffsetRaw(int j, double v) {
    bool ret = yarpPINVOKE.ITorqueControlRaw_setTorqueOffsetRaw(swigCPtr, j, v);
    return ret;
  }

}
