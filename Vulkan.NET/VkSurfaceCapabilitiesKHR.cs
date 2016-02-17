//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkSurfaceCapabilitiesKHR : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkSurfaceCapabilitiesKHR(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkSurfaceCapabilitiesKHR obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkSurfaceCapabilitiesKHR() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkSurfaceCapabilitiesKHR(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_uint32_t minImageCount {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_minImageCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkSurfaceCapabilitiesKHR_minImageCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t maxImageCount {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_maxImageCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkSurfaceCapabilitiesKHR_maxImageCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkExtent2D currentExtent {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_currentExtent_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkSurfaceCapabilitiesKHR_currentExtent_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public VkExtent2D minImageExtent {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_minImageExtent_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkSurfaceCapabilitiesKHR_minImageExtent_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public VkExtent2D maxImageExtent {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_maxImageExtent_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkSurfaceCapabilitiesKHR_maxImageExtent_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t maxImageArrayLayers {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_maxImageArrayLayers_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkSurfaceCapabilitiesKHR_maxImageArrayLayers_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t supportedTransforms {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_supportedTransforms_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkSurfaceCapabilitiesKHR_supportedTransforms_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkSurfaceTransformFlagBitsKHR currentTransform {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_currentTransform_set(swigCPtr, (int)value);
    } 
    get {
      VkSurfaceTransformFlagBitsKHR ret = (VkSurfaceTransformFlagBitsKHR)vulkanPINVOKE.VkSurfaceCapabilitiesKHR_currentTransform_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t supportedCompositeAlpha {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_supportedCompositeAlpha_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkSurfaceCapabilitiesKHR_supportedCompositeAlpha_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t supportedUsageFlags {
    set {
      vulkanPINVOKE.VkSurfaceCapabilitiesKHR_supportedUsageFlags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkSurfaceCapabilitiesKHR_supportedUsageFlags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkSurfaceCapabilitiesKHR() : this(vulkanPINVOKE.new_VkSurfaceCapabilitiesKHR(), true) {
  }

}
