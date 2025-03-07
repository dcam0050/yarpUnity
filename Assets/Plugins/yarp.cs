/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class yarp {
  public static void typedReaderMissingCallback() {
    yarpPINVOKE.typedReaderMissingCallback();
  }

  public static int PAD_BYTES(int len, int pad) {
    int ret = yarpPINVOKE.PAD_BYTES(len, pad);
    return ret;
  }

  public new static bool read(ImageRgb dest, string src) {
    bool ret = yarpPINVOKE.read__SWIG_0(ImageRgb.getCPtr(dest), src);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool read(SWIGTYPE_p_yarp__sig__ImageOfT_yarp__sig__PixelBgr_t dest, string src) {
    bool ret = yarpPINVOKE.read__SWIG_1(SWIGTYPE_p_yarp__sig__ImageOfT_yarp__sig__PixelBgr_t.getCPtr(dest), src);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool read(ImageRgba dest, string src) {
    bool ret = yarpPINVOKE.read__SWIG_2(ImageRgba.getCPtr(dest), src);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool read(ImageMono dest, string src) {
    bool ret = yarpPINVOKE.read__SWIG_3(ImageMono.getCPtr(dest), src);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool read(ImageFloat dest, string src) {
    bool ret = yarpPINVOKE.read__SWIG_4(ImageFloat.getCPtr(dest), src);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(ImageRgb src, string dest) {
    bool ret = yarpPINVOKE.write__SWIG_0(ImageRgb.getCPtr(src), dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(SWIGTYPE_p_yarp__sig__ImageOfT_yarp__sig__PixelBgr_t src, string dest) {
    bool ret = yarpPINVOKE.write__SWIG_1(SWIGTYPE_p_yarp__sig__ImageOfT_yarp__sig__PixelBgr_t.getCPtr(src), dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(ImageRgba src, string dest) {
    bool ret = yarpPINVOKE.write__SWIG_2(ImageRgba.getCPtr(src), dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(ImageMono src, string dest) {
    bool ret = yarpPINVOKE.write__SWIG_3(ImageMono.getCPtr(src), dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(ImageFloat src, string dest) {
    bool ret = yarpPINVOKE.write__SWIG_4(ImageFloat.getCPtr(src), dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static bool write(Image src, string dest) {
    bool ret = yarpPINVOKE.write__SWIG_5(Image.getCPtr(src), dest);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly int YARP_CONSTSTRING_IS_STD_STRING = yarpPINVOKE.YARP_CONSTSTRING_IS_STD_STRING_get();
  public static readonly int BOTTLE_TAG_INT = yarpPINVOKE.BOTTLE_TAG_INT_get();
  public static readonly int BOTTLE_TAG_VOCAB = yarpPINVOKE.BOTTLE_TAG_VOCAB_get();
  public static readonly int BOTTLE_TAG_DOUBLE = yarpPINVOKE.BOTTLE_TAG_DOUBLE_get();
  public static readonly int BOTTLE_TAG_STRING = yarpPINVOKE.BOTTLE_TAG_STRING_get();
  public static readonly int BOTTLE_TAG_BLOB = yarpPINVOKE.BOTTLE_TAG_BLOB_get();
  public static readonly int BOTTLE_TAG_INT64 = yarpPINVOKE.BOTTLE_TAG_INT64_get();
  public static readonly int BOTTLE_TAG_LIST = yarpPINVOKE.BOTTLE_TAG_LIST_get();
  public static readonly int BOTTLE_TAG_DICT = yarpPINVOKE.BOTTLE_TAG_DICT_get();
  public static readonly int FORMAT_NULL = yarpPINVOKE.FORMAT_NULL_get();
  public static readonly int FORMAT_ANY = yarpPINVOKE.FORMAT_ANY_get();
  public static readonly int FORMAT_PGM = yarpPINVOKE.FORMAT_PGM_get();
  public static readonly int FORMAT_PPM = yarpPINVOKE.FORMAT_PPM_get();
  public static readonly int FORMAT_NUMERIC = yarpPINVOKE.FORMAT_NUMERIC_get();

}
