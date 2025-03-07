/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BufferedPortProperty : Contactable {
  private HandleRef swigCPtr;

  internal BufferedPortProperty(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.BufferedPortProperty_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BufferedPortProperty obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BufferedPortProperty() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_BufferedPortProperty(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new void onRead(Property datum, TypedReaderProperty reader) {
    yarpPINVOKE.BufferedPortProperty_onRead__SWIG_0_0(swigCPtr, Property.getCPtr(datum), TypedReaderProperty.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public BufferedPortProperty() : this(yarpPINVOKE.new_BufferedPortProperty__SWIG_0(), true) {
  }

  public BufferedPortProperty(Port port) : this(yarpPINVOKE.new_BufferedPortProperty__SWIG_1(Port.getCPtr(port)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool addOutput(string name) {
    bool ret = yarpPINVOKE.BufferedPortProperty_addOutput__SWIG_0(swigCPtr, name);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(string name, string carrier) {
    bool ret = yarpPINVOKE.BufferedPortProperty_addOutput__SWIG_1(swigCPtr, name, carrier);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(Contact contact) {
    bool ret = yarpPINVOKE.BufferedPortProperty_addOutput__SWIG_2(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void close() {
    yarpPINVOKE.BufferedPortProperty_close(swigCPtr);
  }

  public override void interrupt() {
    yarpPINVOKE.BufferedPortProperty_interrupt(swigCPtr);
  }

  public override void resume() {
    yarpPINVOKE.BufferedPortProperty_resume(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.BufferedPortProperty_getPendingReads(swigCPtr);
    return ret;
  }

  public override Contact where() {
    Contact ret = new Contact(yarpPINVOKE.BufferedPortProperty_where(swigCPtr), true);
    return ret;
  }

  public override string getName() {
    string ret = yarpPINVOKE.BufferedPortProperty_getName(swigCPtr);
    return ret;
  }

  public Property prepare() {
    Property ret = new Property(yarpPINVOKE.BufferedPortProperty_prepare(swigCPtr), false);
    return ret;
  }

  public bool unprepare() {
    bool ret = yarpPINVOKE.BufferedPortProperty_unprepare(swigCPtr);
    return ret;
  }

  public new void write(bool forceStrict) {
    yarpPINVOKE.BufferedPortProperty_write__SWIG_0(swigCPtr, forceStrict);
  }

  public new void write() {
    yarpPINVOKE.BufferedPortProperty_write__SWIG_1(swigCPtr);
  }

  public void writeStrict() {
    yarpPINVOKE.BufferedPortProperty_writeStrict(swigCPtr);
  }

  public void waitForWrite() {
    yarpPINVOKE.BufferedPortProperty_waitForWrite(swigCPtr);
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.BufferedPortProperty_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.BufferedPortProperty_setStrict__SWIG_1(swigCPtr);
  }

  public new Property read(bool shouldWait) {
    IntPtr cPtr = yarpPINVOKE.BufferedPortProperty_read__SWIG_0(swigCPtr, shouldWait);
    Property ret = (cPtr == IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public new Property read() {
    IntPtr cPtr = yarpPINVOKE.BufferedPortProperty_read__SWIG_1(swigCPtr);
    Property ret = (cPtr == IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public new Property lastRead() {
    IntPtr cPtr = yarpPINVOKE.BufferedPortProperty_lastRead(swigCPtr);
    Property ret = (cPtr == IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.BufferedPortProperty_isClosed(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.BufferedPortProperty_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReader(PortReader reader) {
    yarpPINVOKE.BufferedPortProperty_setReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setAdminReader(PortReader reader) {
    yarpPINVOKE.BufferedPortProperty_setAdminReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(Property datum) {
    yarpPINVOKE.BufferedPortProperty_onRead__SWIG_1(swigCPtr, Property.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback(PropertyCallback callback) {
    yarpPINVOKE.BufferedPortProperty_useCallback__SWIG_0(swigCPtr, PropertyCallback.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback() {
    yarpPINVOKE.BufferedPortProperty_useCallback__SWIG_1(swigCPtr);
  }

  public virtual void disableCallback() {
    yarpPINVOKE.BufferedPortProperty_disableCallback(swigCPtr);
  }

  public override bool setEnvelope(PortWriter envelope) {
    bool ret = yarpPINVOKE.BufferedPortProperty_setEnvelope(swigCPtr, PortWriter.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.BufferedPortProperty_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getInputCount() {
    int ret = yarpPINVOKE.BufferedPortProperty_getInputCount(swigCPtr);
    return ret;
  }

  public override int getOutputCount() {
    int ret = yarpPINVOKE.BufferedPortProperty_getOutputCount(swigCPtr);
    return ret;
  }

  public override bool isWriting() {
    bool ret = yarpPINVOKE.BufferedPortProperty_isWriting(swigCPtr);
    return ret;
  }

  public override void getReport(PortReport reporter) {
    yarpPINVOKE.BufferedPortProperty_getReport(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReporter(PortReport reporter) {
    yarpPINVOKE.BufferedPortProperty_setReporter(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual System.IntPtr acquire() { return yarpPINVOKE.BufferedPortProperty_acquire(swigCPtr); }

  public virtual void release(System.IntPtr handle) {
    yarpPINVOKE.BufferedPortProperty_release(swigCPtr, handle);
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.BufferedPortProperty_setTargetPeriod(swigCPtr, period);
  }

  public override SWIGTYPE_p_Type getType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type(yarpPINVOKE.BufferedPortProperty_getType(swigCPtr), true);
    return ret;
  }

  public override void promiseType(SWIGTYPE_p_Type typ) {
    yarpPINVOKE.BufferedPortProperty_promiseType(swigCPtr, SWIGTYPE_p_Type.getCPtr(typ));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setInputMode(bool expectInput) {
    yarpPINVOKE.BufferedPortProperty_setInputMode(swigCPtr, expectInput);
  }

  public override void setOutputMode(bool expectOutput) {
    yarpPINVOKE.BufferedPortProperty_setOutputMode(swigCPtr, expectOutput);
  }

  public override void setRpcMode(bool expectRpc) {
    yarpPINVOKE.BufferedPortProperty_setRpcMode(swigCPtr, expectRpc);
  }

  public override Property acquireProperties(bool readOnly) {
    IntPtr cPtr = yarpPINVOKE.BufferedPortProperty_acquireProperties(swigCPtr, readOnly);
    Property ret = (cPtr == IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public override void releaseProperties(Property prop) {
    yarpPINVOKE.BufferedPortProperty_releaseProperties(swigCPtr, Property.getCPtr(prop));
  }

  public override void includeNodeInName(bool flag) {
    yarpPINVOKE.BufferedPortProperty_includeNodeInName(swigCPtr, flag);
  }

  public override bool setCallbackLock(SWIGTYPE_p_yarp__os__Mutex mutex) {
    bool ret = yarpPINVOKE.BufferedPortProperty_setCallbackLock(swigCPtr, SWIGTYPE_p_yarp__os__Mutex.getCPtr(mutex));
    return ret;
  }

  public override bool removeCallbackLock() {
    bool ret = yarpPINVOKE.BufferedPortProperty_removeCallbackLock(swigCPtr);
    return ret;
  }

  public override bool lockCallback() {
    bool ret = yarpPINVOKE.BufferedPortProperty_lockCallback(swigCPtr);
    return ret;
  }

  public override bool tryLockCallback() {
    bool ret = yarpPINVOKE.BufferedPortProperty_tryLockCallback(swigCPtr);
    return ret;
  }

  public override void unlockCallback() {
    yarpPINVOKE.BufferedPortProperty_unlockCallback(swigCPtr);
  }

}
