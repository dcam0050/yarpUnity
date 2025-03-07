/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BufferedPortImageRgba : Contactable {
  private HandleRef swigCPtr;

  internal BufferedPortImageRgba(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.BufferedPortImageRgba_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BufferedPortImageRgba obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BufferedPortImageRgba() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_BufferedPortImageRgba(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new void onRead(ImageRgba datum, TypedReaderImageRgba reader) {
    yarpPINVOKE.BufferedPortImageRgba_onRead__SWIG_0_0(swigCPtr, ImageRgba.getCPtr(datum), TypedReaderImageRgba.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public BufferedPortImageRgba() : this(yarpPINVOKE.new_BufferedPortImageRgba__SWIG_0(), true) {
  }

  public BufferedPortImageRgba(Port port) : this(yarpPINVOKE.new_BufferedPortImageRgba__SWIG_1(Port.getCPtr(port)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool addOutput(string name) {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_addOutput__SWIG_0(swigCPtr, name);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(string name, string carrier) {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_addOutput__SWIG_1(swigCPtr, name, carrier);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool addOutput(Contact contact) {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_addOutput__SWIG_2(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void close() {
    yarpPINVOKE.BufferedPortImageRgba_close(swigCPtr);
  }

  public override void interrupt() {
    yarpPINVOKE.BufferedPortImageRgba_interrupt(swigCPtr);
  }

  public override void resume() {
    yarpPINVOKE.BufferedPortImageRgba_resume(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.BufferedPortImageRgba_getPendingReads(swigCPtr);
    return ret;
  }

  public override Contact where() {
    Contact ret = new Contact(yarpPINVOKE.BufferedPortImageRgba_where(swigCPtr), true);
    return ret;
  }

  public override string getName() {
    string ret = yarpPINVOKE.BufferedPortImageRgba_getName(swigCPtr);
    return ret;
  }

  public ImageRgba prepare() {
    ImageRgba ret = new ImageRgba(yarpPINVOKE.BufferedPortImageRgba_prepare(swigCPtr), false);
    return ret;
  }

  public bool unprepare() {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_unprepare(swigCPtr);
    return ret;
  }

  public new void write(bool forceStrict) {
    yarpPINVOKE.BufferedPortImageRgba_write__SWIG_0(swigCPtr, forceStrict);
  }

  public new void write() {
    yarpPINVOKE.BufferedPortImageRgba_write__SWIG_1(swigCPtr);
  }

  public void writeStrict() {
    yarpPINVOKE.BufferedPortImageRgba_writeStrict(swigCPtr);
  }

  public void waitForWrite() {
    yarpPINVOKE.BufferedPortImageRgba_waitForWrite(swigCPtr);
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.BufferedPortImageRgba_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.BufferedPortImageRgba_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageRgba read(bool shouldWait) {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgba_read__SWIG_0(swigCPtr, shouldWait);
    ImageRgba ret = (cPtr == IntPtr.Zero) ? null : new ImageRgba(cPtr, false);
    return ret;
  }

  public new ImageRgba read() {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgba_read__SWIG_1(swigCPtr);
    ImageRgba ret = (cPtr == IntPtr.Zero) ? null : new ImageRgba(cPtr, false);
    return ret;
  }

  public new ImageRgba lastRead() {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgba_lastRead(swigCPtr);
    ImageRgba ret = (cPtr == IntPtr.Zero) ? null : new ImageRgba(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_isClosed(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.BufferedPortImageRgba_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReader(PortReader reader) {
    yarpPINVOKE.BufferedPortImageRgba_setReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setAdminReader(PortReader reader) {
    yarpPINVOKE.BufferedPortImageRgba_setAdminReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageRgba datum) {
    yarpPINVOKE.BufferedPortImageRgba_onRead__SWIG_1(swigCPtr, ImageRgba.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback(TypedReaderCallbackImageRgba callback) {
    yarpPINVOKE.BufferedPortImageRgba_useCallback__SWIG_0(swigCPtr, TypedReaderCallbackImageRgba.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback() {
    yarpPINVOKE.BufferedPortImageRgba_useCallback__SWIG_1(swigCPtr);
  }

  public virtual void disableCallback() {
    yarpPINVOKE.BufferedPortImageRgba_disableCallback(swigCPtr);
  }

  public override bool setEnvelope(PortWriter envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_setEnvelope(swigCPtr, PortWriter.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getInputCount() {
    int ret = yarpPINVOKE.BufferedPortImageRgba_getInputCount(swigCPtr);
    return ret;
  }

  public override int getOutputCount() {
    int ret = yarpPINVOKE.BufferedPortImageRgba_getOutputCount(swigCPtr);
    return ret;
  }

  public override bool isWriting() {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_isWriting(swigCPtr);
    return ret;
  }

  public override void getReport(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageRgba_getReport(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReporter(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageRgba_setReporter(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual System.IntPtr acquire() { return yarpPINVOKE.BufferedPortImageRgba_acquire(swigCPtr); }

  public virtual void release(System.IntPtr handle) {
    yarpPINVOKE.BufferedPortImageRgba_release(swigCPtr, handle);
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.BufferedPortImageRgba_setTargetPeriod(swigCPtr, period);
  }

  public override SWIGTYPE_p_Type getType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type(yarpPINVOKE.BufferedPortImageRgba_getType(swigCPtr), true);
    return ret;
  }

  public override void promiseType(SWIGTYPE_p_Type typ) {
    yarpPINVOKE.BufferedPortImageRgba_promiseType(swigCPtr, SWIGTYPE_p_Type.getCPtr(typ));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setInputMode(bool expectInput) {
    yarpPINVOKE.BufferedPortImageRgba_setInputMode(swigCPtr, expectInput);
  }

  public override void setOutputMode(bool expectOutput) {
    yarpPINVOKE.BufferedPortImageRgba_setOutputMode(swigCPtr, expectOutput);
  }

  public override void setRpcMode(bool expectRpc) {
    yarpPINVOKE.BufferedPortImageRgba_setRpcMode(swigCPtr, expectRpc);
  }

  public override Property acquireProperties(bool readOnly) {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageRgba_acquireProperties(swigCPtr, readOnly);
    Property ret = (cPtr == IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public override void releaseProperties(Property prop) {
    yarpPINVOKE.BufferedPortImageRgba_releaseProperties(swigCPtr, Property.getCPtr(prop));
  }

  public override void includeNodeInName(bool flag) {
    yarpPINVOKE.BufferedPortImageRgba_includeNodeInName(swigCPtr, flag);
  }

  public override bool setCallbackLock(SWIGTYPE_p_yarp__os__Mutex mutex) {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_setCallbackLock(swigCPtr, SWIGTYPE_p_yarp__os__Mutex.getCPtr(mutex));
    return ret;
  }

  public override bool removeCallbackLock() {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_removeCallbackLock(swigCPtr);
    return ret;
  }

  public override bool lockCallback() {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_lockCallback(swigCPtr);
    return ret;
  }

  public override bool tryLockCallback() {
    bool ret = yarpPINVOKE.BufferedPortImageRgba_tryLockCallback(swigCPtr);
    return ret;
  }

  public override void unlockCallback() {
    yarpPINVOKE.BufferedPortImageRgba_unlockCallback(swigCPtr);
  }

}
