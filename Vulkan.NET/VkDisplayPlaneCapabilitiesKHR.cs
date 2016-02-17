//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkDisplayPlaneCapabilitiesKHR : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkDisplayPlaneCapabilitiesKHR(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkDisplayPlaneCapabilitiesKHR obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkDisplayPlaneCapabilitiesKHR() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkDisplayPlaneCapabilitiesKHR(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_uint32_t supportedAlpha {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_supportedAlpha_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_supportedAlpha_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkOffset2D minSrcPosition {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minSrcPosition_set(swigCPtr, VkOffset2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minSrcPosition_get(swigCPtr);
      VkOffset2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkOffset2D(cPtr, false);
      return ret;
    } 
  }

  public VkOffset2D maxSrcPosition {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxSrcPosition_set(swigCPtr, VkOffset2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxSrcPosition_get(swigCPtr);
      VkOffset2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkOffset2D(cPtr, false);
      return ret;
    } 
  }

  public VkExtent2D minSrcExtent {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minSrcExtent_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minSrcExtent_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public VkExtent2D maxSrcExtent {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxSrcExtent_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxSrcExtent_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public VkOffset2D minDstPosition {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minDstPosition_set(swigCPtr, VkOffset2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minDstPosition_get(swigCPtr);
      VkOffset2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkOffset2D(cPtr, false);
      return ret;
    } 
  }

  public VkOffset2D maxDstPosition {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxDstPosition_set(swigCPtr, VkOffset2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxDstPosition_get(swigCPtr);
      VkOffset2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkOffset2D(cPtr, false);
      return ret;
    } 
  }

  public VkExtent2D minDstExtent {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minDstExtent_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_minDstExtent_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public VkExtent2D maxDstExtent {
    set {
      vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxDstExtent_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPlaneCapabilitiesKHR_maxDstExtent_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public VkDisplayPlaneCapabilitiesKHR() : this(vulkanPINVOKE.new_VkDisplayPlaneCapabilitiesKHR(), true) {
  }

}
