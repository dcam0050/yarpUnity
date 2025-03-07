/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_yarp_WRAP_H_
#define SWIG_yarp_WRAP_H_

class SwigDirector_PortReader : public yarp::os::PortReader, public Swig::Director {

public:
    SwigDirector_PortReader();
    virtual ~SwigDirector_PortReader();
    virtual bool read(yarp::os::ConnectionReader &reader);
    virtual Type getReadType();

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback1_t)();
    void swig_connect_director(SWIG_Callback0_t callbackread, SWIG_Callback1_t callbackgetReadType);

private:
    SWIG_Callback0_t swig_callbackread;
    SWIG_Callback1_t swig_callbackgetReadType;
    void swig_init_callbacks();
};

class SwigDirector_Thread : public yarp::os::Thread, public Swig::Director {

public:
    SwigDirector_Thread();
    virtual ~SwigDirector_Thread();
    virtual void run();
    virtual void onStop();
    virtual void beforeStart();
    virtual void afterStart(bool success);
    virtual bool threadInit();
    virtual void threadRelease();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(unsigned int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback4_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback5_t)();
    void swig_connect_director(SWIG_Callback0_t callbackrun, SWIG_Callback1_t callbackonStop, SWIG_Callback2_t callbackbeforeStart, SWIG_Callback3_t callbackafterStart, SWIG_Callback4_t callbackthreadInit, SWIG_Callback5_t callbackthreadRelease);

private:
    SWIG_Callback0_t swig_callbackrun;
    SWIG_Callback1_t swig_callbackonStop;
    SWIG_Callback2_t swig_callbackbeforeStart;
    SWIG_Callback3_t swig_callbackafterStart;
    SWIG_Callback4_t swig_callbackthreadInit;
    SWIG_Callback5_t swig_callbackthreadRelease;
    void swig_init_callbacks();
};

class SwigDirector_RFModule : public yarp::os::RFModule, public Swig::Director {

public:
    SwigDirector_RFModule();
    virtual ~SwigDirector_RFModule();
    virtual double getPeriod();
    virtual bool updateModule();
    virtual int runModule();
    virtual int runModule(yarp::os::ResourceFinder &rf);
    virtual bool configure(yarp::os::ResourceFinder &rf);
    virtual bool respond(yarp::os::Bottle const &command, yarp::os::Bottle &reply);
    virtual bool attach(yarp::os::Port &source);
    virtual bool attach(yarp::os::RpcServer &source);
    virtual bool interruptModule();
    virtual bool close();

    typedef double (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef int (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef int (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback5_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback6_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback7_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback8_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback9_t)();
    void swig_connect_director(SWIG_Callback0_t callbackgetPeriod, SWIG_Callback1_t callbackupdateModule, SWIG_Callback2_t callbackrunModule__SWIG_0, SWIG_Callback3_t callbackrunModule__SWIG_1, SWIG_Callback4_t callbackconfigure, SWIG_Callback5_t callbackrespond, SWIG_Callback6_t callbackattach, SWIG_Callback7_t callbackattach_rpc_server, SWIG_Callback8_t callbackinterruptModule, SWIG_Callback9_t callbackclose);

private:
    SWIG_Callback0_t swig_callbackgetPeriod;
    SWIG_Callback1_t swig_callbackupdateModule;
    SWIG_Callback2_t swig_callbackrunModule__SWIG_0;
    SWIG_Callback3_t swig_callbackrunModule__SWIG_1;
    SWIG_Callback4_t swig_callbackconfigure;
    SWIG_Callback5_t swig_callbackrespond;
    SWIG_Callback6_t swig_callbackattach;
    SWIG_Callback7_t swig_callbackattach_rpc_server;
    SWIG_Callback8_t swig_callbackinterruptModule;
    SWIG_Callback9_t swig_callbackclose;
    void swig_init_callbacks();
};

class SwigDirector_PropertyCallback : public yarp::os::TypedReaderCallback< Property >, public Swig::Director {

public:
    SwigDirector_PropertyCallback();
    virtual ~SwigDirector_PropertyCallback();
    virtual void onRead(yarp::os::Property &datum);
    virtual void onRead(yarp::os::Property &datum, yarp::os::TypedReader< yarp::os::Property > const &reader);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *);
    void swig_connect_director(SWIG_Callback0_t callbackonRead__SWIG_0, SWIG_Callback1_t callbackonRead__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackonRead__SWIG_0;
    SWIG_Callback1_t swig_callbackonRead__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_BottleCallback : public yarp::os::TypedReaderCallback< Bottle >, public Swig::Director {

public:
    SwigDirector_BottleCallback();
    virtual ~SwigDirector_BottleCallback();
    virtual void onRead(yarp::os::Bottle &datum);
    virtual void onRead(yarp::os::Bottle &datum, yarp::os::TypedReader< yarp::os::Bottle > const &reader);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *);
    void swig_connect_director(SWIG_Callback0_t callbackonRead__SWIG_0, SWIG_Callback1_t callbackonRead__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackonRead__SWIG_0;
    SWIG_Callback1_t swig_callbackonRead__SWIG_1;
    void swig_init_callbacks();
};


#endif
