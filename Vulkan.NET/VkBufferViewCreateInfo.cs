//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkBufferViewCreateInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkBufferViewCreateInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkBufferViewCreateInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkBufferViewCreateInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkBufferViewCreateInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VkStructureType sType {
    set {
      vulkanPINVOKE.VkBufferViewCreateInfo_sType_set(swigCPtr, (int)value);
    } 
    get {
      VkStructureType ret = (VkStructureType)vulkanPINVOKE.VkBufferViewCreateInfo_sType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pNext {
    set {
      vulkanPINVOKE.VkBufferViewCreateInfo_pNext_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkBufferViewCreateInfo_pNext_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t flags {
    set {
      vulkanPINVOKE.VkBufferViewCreateInfo_flags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkBufferViewCreateInfo_flags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint64_t buffer {
    set {
      vulkanPINVOKE.VkBufferViewCreateInfo_buffer_set(swigCPtr, SWIGTYPE_p_uint64_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint64_t ret = new SWIGTYPE_p_uint64_t(vulkanPINVOKE.VkBufferViewCreateInfo_buffer_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkFormat format {
    set {
      vulkanPINVOKE.VkBufferViewCreateInfo_format_set(swigCPtr, (int)value);
    } 
    get {
      VkFormat ret = (VkFormat)vulkanPINVOKE.VkBufferViewCreateInfo_format_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint64_t offset {
    set {
      vulkanPINVOKE.VkBufferViewCreateInfo_offset_set(swigCPtr, SWIGTYPE_p_uint64_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint64_t ret = new SWIGTYPE_p_uint64_t(vulkanPINVOKE.VkBufferViewCreateInfo_offset_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint64_t range {
    set {
      vulkanPINVOKE.VkBufferViewCreateInfo_range_set(swigCPtr, SWIGTYPE_p_uint64_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint64_t ret = new SWIGTYPE_p_uint64_t(vulkanPINVOKE.VkBufferViewCreateInfo_range_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkBufferViewCreateInfo() : this(vulkanPINVOKE.new_VkBufferViewCreateInfo(), true) {
  }

}