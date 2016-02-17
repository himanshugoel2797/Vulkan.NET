//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkQueueFamilyProperties : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkQueueFamilyProperties(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkQueueFamilyProperties obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkQueueFamilyProperties() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkQueueFamilyProperties(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_uint32_t queueFlags {
    set {
      vulkanPINVOKE.VkQueueFamilyProperties_queueFlags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkQueueFamilyProperties_queueFlags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t queueCount {
    set {
      vulkanPINVOKE.VkQueueFamilyProperties_queueCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkQueueFamilyProperties_queueCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t timestampValidBits {
    set {
      vulkanPINVOKE.VkQueueFamilyProperties_timestampValidBits_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkQueueFamilyProperties_timestampValidBits_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkExtent3D minImageTransferGranularity {
    set {
      vulkanPINVOKE.VkQueueFamilyProperties_minImageTransferGranularity_set(swigCPtr, VkExtent3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkQueueFamilyProperties_minImageTransferGranularity_get(swigCPtr);
      VkExtent3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkExtent3D(cPtr, false);
      return ret;
    } 
  }

  public VkQueueFamilyProperties() : this(vulkanPINVOKE.new_VkQueueFamilyProperties(), true) {
  }

}
