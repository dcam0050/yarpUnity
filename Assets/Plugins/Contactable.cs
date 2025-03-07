/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Contactable : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Contactable(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Contactable obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Contactable() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Contactable(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public bool open() {
    bool ret = yarpPINVOKE.Contactable_open__SWIG_0(swigCPtr);
    return ret;
  }

  public virtual bool open(string name) {
    bool ret = yarpPINVOKE.Contactable_open__SWIG_1(swigCPtr, name);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool open(Contact contact, bool registerName) {
    bool ret = yarpPINVOKE.Contactable_open__SWIG_2(swigCPtr, Contact.getCPtr(contact), registerName);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool open(Contact contact) {
    bool ret = yarpPINVOKE.Contactable_open__SWIG_3(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addOutput(string name) {
    bool ret = yarpPINVOKE.Contactable_addOutput__SWIG_0(swigCPtr, name);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addOutput(string name, string carrier) {
    bool ret = yarpPINVOKE.Contactable_addOutput__SWIG_1(swigCPtr, name, carrier);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addOutput(Contact contact) {
    bool ret = yarpPINVOKE.Contactable_addOutput__SWIG_2(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void close() {
    yarpPINVOKE.Contactable_close(swigCPtr);
  }

  public virtual void interrupt() {
    yarpPINVOKE.Contactable_interrupt(swigCPtr);
  }

  public virtual void resume() {
    yarpPINVOKE.Contactable_resume(swigCPtr);
  }

  public virtual Contact where() {
    Contact ret = new Contact(yarpPINVOKE.Contactable_where(swigCPtr), true);
    return ret;
  }

  public virtual string getName() {
    string ret = yarpPINVOKE.Contactable_getName(swigCPtr);
    return ret;
  }

  public virtual bool setEnvelope(PortWriter envelope) {
    bool ret = yarpPINVOKE.Contactable_setEnvelope__SWIG_0(swigCPtr, PortWriter.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.Contactable_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int getInputCount() {
    int ret = yarpPINVOKE.Contactable_getInputCount(swigCPtr);
    return ret;
  }

  public virtual int getOutputCount() {
    int ret = yarpPINVOKE.Contactable_getOutputCount(swigCPtr);
    return ret;
  }

  public virtual void getReport(PortReport reporter) {
    yarpPINVOKE.Contactable_getReport(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setReporter(PortReport reporter) {
    yarpPINVOKE.Contactable_setReporter(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isWriting() {
    bool ret = yarpPINVOKE.Contactable_isWriting(swigCPtr);
    return ret;
  }

  public virtual void setReader(PortReader reader) {
    yarpPINVOKE.Contactable_setReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setAdminReader(PortReader reader) {
    yarpPINVOKE.Contactable_setAdminReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setInputMode(bool expectInput) {
    yarpPINVOKE.Contactable_setInputMode(swigCPtr, expectInput);
  }

  public virtual void setOutputMode(bool expectOutput) {
    yarpPINVOKE.Contactable_setOutputMode(swigCPtr, expectOutput);
  }

  public virtual void setRpcMode(bool expectRpc) {
    yarpPINVOKE.Contactable_setRpcMode(swigCPtr, expectRpc);
  }

  public virtual SWIGTYPE_p_Type getType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type(yarpPINVOKE.Contactable_getType(swigCPtr), true);
    return ret;
  }

  public virtual void promiseType(SWIGTYPE_p_Type typ) {
    yarpPINVOKE.Contactable_promiseType(swigCPtr, SWIGTYPE_p_Type.getCPtr(typ));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Property acquireProperties(bool readOnly) {
    IntPtr cPtr = yarpPINVOKE.Contactable_acquireProperties(swigCPtr, readOnly);
    Property ret = (cPtr == IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public virtual void releaseProperties(Property prop) {
    yarpPINVOKE.Contactable_releaseProperties(swigCPtr, Property.getCPtr(prop));
  }

  public virtual void includeNodeInName(bool flag) {
    yarpPINVOKE.Contactable_includeNodeInName(swigCPtr, flag);
  }

  public void setReadOnly() {
    yarpPINVOKE.Contactable_setReadOnly(swigCPtr);
  }

  public void setWriteOnly() {
    yarpPINVOKE.Contactable_setWriteOnly(swigCPtr);
  }

  public void setRpcServer() {
    yarpPINVOKE.Contactable_setRpcServer(swigCPtr);
  }

  public void setRpcClient() {
    yarpPINVOKE.Contactable_setRpcClient(swigCPtr);
  }

  public virtual bool setCallbackLock(SWIGTYPE_p_yarp__os__Mutex mutex) {
    bool ret = yarpPINVOKE.Contactable_setCallbackLock__SWIG_0(swigCPtr, SWIGTYPE_p_yarp__os__Mutex.getCPtr(mutex));
    return ret;
  }

  public virtual bool setCallbackLock() {
    bool ret = yarpPINVOKE.Contactable_setCallbackLock__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual bool removeCallbackLock() {
    bool ret = yarpPINVOKE.Contactable_removeCallbackLock(swigCPtr);
    return ret;
  }

  public virtual bool lockCallback() {
    bool ret = yarpPINVOKE.Contactable_lockCallback(swigCPtr);
    return ret;
  }

  public virtual bool tryLockCallback() {
    bool ret = yarpPINVOKE.Contactable_tryLockCallback(swigCPtr);
    return ret;
  }

  public virtual void unlockCallback() {
    yarpPINVOKE.Contactable_unlockCallback(swigCPtr);
  }

  public bool setEnvelope(Portable data) {
    bool ret = yarpPINVOKE.Contactable_setEnvelope__SWIG_1(swigCPtr, Portable.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
