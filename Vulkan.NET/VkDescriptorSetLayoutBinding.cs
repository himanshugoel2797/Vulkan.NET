//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkDescriptorSetLayoutBinding : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkDescriptorSetLayoutBinding(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkDescriptorSetLayoutBinding obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkDescriptorSetLayoutBinding() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkDescriptorSetLayoutBinding(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_uint32_t binding {
    set {
      vulkanPINVOKE.VkDescriptorSetLayoutBinding_binding_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkDescriptorSetLayoutBinding_binding_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkDescriptorType descriptorType {
    set {
      vulkanPINVOKE.VkDescriptorSetLayoutBinding_descriptorType_set(swigCPtr, (int)value);
    } 
    get {
      VkDescriptorType ret = (VkDescriptorType)vulkanPINVOKE.VkDescriptorSetLayoutBinding_descriptorType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t descriptorCount {
    set {
      vulkanPINVOKE.VkDescriptorSetLayoutBinding_descriptorCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkDescriptorSetLayoutBinding_descriptorCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t stageFlags {
    set {
      vulkanPINVOKE.VkDescriptorSetLayoutBinding_stageFlags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkDescriptorSetLayoutBinding_stageFlags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint64_t pImmutableSamplers {
    set {
      vulkanPINVOKE.VkDescriptorSetLayoutBinding_pImmutableSamplers_set(swigCPtr, SWIGTYPE_p_uint64_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkDescriptorSetLayoutBinding_pImmutableSamplers_get(swigCPtr);
      SWIGTYPE_p_uint64_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_uint64_t(cPtr, false);
      return ret;
    } 
  }

  public VkDescriptorSetLayoutBinding() : this(vulkanPINVOKE.new_VkDescriptorSetLayoutBinding(), true) {
  }

}
