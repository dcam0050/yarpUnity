/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ConnectionReader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ConnectionReader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ConnectionReader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConnectionReader() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ConnectionReader(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool expectBlock(string data, uint len) {
    bool ret = yarpPINVOKE.ConnectionReader_expectBlock(swigCPtr, data, len);
    return ret;
  }

  public virtual string expectText(int terminatingChar) {
    string ret = yarpPINVOKE.ConnectionReader_expectText__SWIG_0(swigCPtr, terminatingChar);
    return ret;
  }

  public virtual string expectText() {
    string ret = yarpPINVOKE.ConnectionReader_expectText__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual int expectInt() {
    int ret = yarpPINVOKE.ConnectionReader_expectInt(swigCPtr);
    return ret;
  }

  public virtual SWIGTYPE_p_YARP_INT64 expectInt64() {
    SWIGTYPE_p_YARP_INT64 ret = new SWIGTYPE_p_YARP_INT64(yarpPINVOKE.ConnectionReader_expectInt64(swigCPtr), true);
    return ret;
  }

  public virtual double expectDouble() {
    double ret = yarpPINVOKE.ConnectionReader_expectDouble(swigCPtr);
    return ret;
  }

  public virtual bool isTextMode() {
    bool ret = yarpPINVOKE.ConnectionReader_isTextMode(swigCPtr);
    return ret;
  }

  public virtual bool isBareMode() {
    bool ret = yarpPINVOKE.ConnectionReader_isBareMode(swigCPtr);
    return ret;
  }

  public virtual bool convertTextMode() {
    bool ret = yarpPINVOKE.ConnectionReader_convertTextMode(swigCPtr);
    return ret;
  }

  public virtual uint getSize() {
    uint ret = yarpPINVOKE.ConnectionReader_getSize(swigCPtr);
    return ret;
  }

  public virtual ConnectionWriter getWriter() {
    IntPtr cPtr = yarpPINVOKE.ConnectionReader_getWriter(swigCPtr);
    ConnectionWriter ret = (cPtr == IntPtr.Zero) ? null : new ConnectionWriter(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_Bytes readEnvelope() {
    SWIGTYPE_p_Bytes ret = new SWIGTYPE_p_Bytes(yarpPINVOKE.ConnectionReader_readEnvelope(swigCPtr), true);
    return ret;
  }

  public virtual Portable getReference() {
    IntPtr cPtr = yarpPINVOKE.ConnectionReader_getReference(swigCPtr);
    Portable ret = (cPtr == IntPtr.Zero) ? null : new Portable(cPtr, false);
    return ret;
  }

  public virtual Contact getRemoteContact() {
    Contact ret = new Contact(yarpPINVOKE.ConnectionReader_getRemoteContact(swigCPtr), true);
    return ret;
  }

  public virtual Contact getLocalContact() {
    Contact ret = new Contact(yarpPINVOKE.ConnectionReader_getLocalContact(swigCPtr), true);
    return ret;
  }

  public virtual bool isValid() {
    bool ret = yarpPINVOKE.ConnectionReader_isValid(swigCPtr);
    return ret;
  }

  public virtual bool isActive() {
    bool ret = yarpPINVOKE.ConnectionReader_isActive(swigCPtr);
    return ret;
  }

  public virtual bool isError() {
    bool ret = yarpPINVOKE.ConnectionReader_isError(swigCPtr);
    return ret;
  }

  public virtual void requestDrop() {
    yarpPINVOKE.ConnectionReader_requestDrop(swigCPtr);
  }

  public virtual SWIGTYPE_p_Searchable getConnectionModifiers() {
    SWIGTYPE_p_Searchable ret = new SWIGTYPE_p_Searchable(yarpPINVOKE.ConnectionReader_getConnectionModifiers(swigCPtr), false);
    return ret;
  }

  public virtual bool pushInt(int x) {
    bool ret = yarpPINVOKE.ConnectionReader_pushInt(swigCPtr, x);
    return ret;
  }

  public virtual bool setSize(uint len) {
    bool ret = yarpPINVOKE.ConnectionReader_setSize(swigCPtr, len);
    return ret;
  }

  public static ConnectionReader createConnectionReader(SWIGTYPE_p_yarp__os__InputStream arg0) {
    IntPtr cPtr = yarpPINVOKE.ConnectionReader_createConnectionReader(SWIGTYPE_p_yarp__os__InputStream.getCPtr(arg0));
    ConnectionReader ret = (cPtr == IntPtr.Zero) ? null : new ConnectionReader(cPtr, false);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool readFromStream(PortReader portable, SWIGTYPE_p_yarp__os__InputStream arg1) {
    bool ret = yarpPINVOKE.ConnectionReader_readFromStream(PortReader.getCPtr(portable), SWIGTYPE_p_yarp__os__InputStream.getCPtr(arg1));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
