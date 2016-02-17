//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkDisplayPropertiesKHR : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkDisplayPropertiesKHR(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkDisplayPropertiesKHR obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkDisplayPropertiesKHR() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkDisplayPropertiesKHR(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_uint64_t display {
    set {
      vulkanPINVOKE.VkDisplayPropertiesKHR_display_set(swigCPtr, SWIGTYPE_p_uint64_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint64_t ret = new SWIGTYPE_p_uint64_t(vulkanPINVOKE.VkDisplayPropertiesKHR_display_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string displayName {
    set {
      vulkanPINVOKE.VkDisplayPropertiesKHR_displayName_set(swigCPtr, value);
    } 
    get {
      string ret = vulkanPINVOKE.VkDisplayPropertiesKHR_displayName_get(swigCPtr);
      return ret;
    } 
  }

  public VkExtent2D physicalDimensions {
    set {
      vulkanPINVOKE.VkDisplayPropertiesKHR_physicalDimensions_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPropertiesKHR_physicalDimensions_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public VkExtent2D physicalResolution {
    set {
      vulkanPINVOKE.VkDisplayPropertiesKHR_physicalResolution_set(swigCPtr, VkExtent2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDisplayPropertiesKHR_physicalResolution_get(swigCPtr);
      VkExtent2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent2D(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t supportedTransforms {
    set {
      vulkanPINVOKE.VkDisplayPropertiesKHR_supportedTransforms_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkDisplayPropertiesKHR_supportedTransforms_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t planeReorderPossible {
    set {
      vulkanPINVOKE.VkDisplayPropertiesKHR_planeReorderPossible_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkDisplayPropertiesKHR_planeReorderPossible_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t persistentContent {
    set {
      vulkanPINVOKE.VkDisplayPropertiesKHR_persistentContent_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkDisplayPropertiesKHR_persistentContent_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkDisplayPropertiesKHR() : this(vulkanPINVOKE.new_VkDisplayPropertiesKHR(), true) {
  }

}
