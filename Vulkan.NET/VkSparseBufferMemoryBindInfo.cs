//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkSparseBufferMemoryBindInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkSparseBufferMemoryBindInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkSparseBufferMemoryBindInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkSparseBufferMemoryBindInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkSparseBufferMemoryBindInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_uint64_t buffer {
    set {
      vulkanPINVOKE.VkSparseBufferMemoryBindInfo_buffer_set(swigCPtr, SWIGTYPE_p_uint64_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint64_t ret = new SWIGTYPE_p_uint64_t(vulkanPINVOKE.VkSparseBufferMemoryBindInfo_buffer_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t bindCount {
    set {
      vulkanPINVOKE.VkSparseBufferMemoryBindInfo_bindCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkSparseBufferMemoryBindInfo_bindCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkSparseMemoryBind pBinds {
    set {
      vulkanPINVOKE.VkSparseBufferMemoryBindInfo_pBinds_set(swigCPtr, VkSparseMemoryBind.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkSparseBufferMemoryBindInfo_pBinds_get(swigCPtr);
      VkSparseMemoryBind ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkSparseMemoryBind(cPtr, false);
      return ret;
    } 
  }

  public VkSparseBufferMemoryBindInfo() : this(vulkanPINVOKE.new_VkSparseBufferMemoryBindInfo(), true) {
  }

}