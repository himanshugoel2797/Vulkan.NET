//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkPipelineViewportStateCreateInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkPipelineViewportStateCreateInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkPipelineViewportStateCreateInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkPipelineViewportStateCreateInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkPipelineViewportStateCreateInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VkStructureType sType {
    set {
      vulkanPINVOKE.VkPipelineViewportStateCreateInfo_sType_set(swigCPtr, (int)value);
    } 
    get {
      VkStructureType ret = (VkStructureType)vulkanPINVOKE.VkPipelineViewportStateCreateInfo_sType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pNext {
    set {
      vulkanPINVOKE.VkPipelineViewportStateCreateInfo_pNext_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkPipelineViewportStateCreateInfo_pNext_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t flags {
    set {
      vulkanPINVOKE.VkPipelineViewportStateCreateInfo_flags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineViewportStateCreateInfo_flags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t viewportCount {
    set {
      vulkanPINVOKE.VkPipelineViewportStateCreateInfo_viewportCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineViewportStateCreateInfo_viewportCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkViewport pViewports {
    set {
      vulkanPINVOKE.VkPipelineViewportStateCreateInfo_pViewports_set(swigCPtr, VkViewport.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkPipelineViewportStateCreateInfo_pViewports_get(swigCPtr);
      VkViewport ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkViewport(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t scissorCount {
    set {
      vulkanPINVOKE.VkPipelineViewportStateCreateInfo_scissorCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineViewportStateCreateInfo_scissorCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkRect2D pScissors {
    set {
      vulkanPINVOKE.VkPipelineViewportStateCreateInfo_pScissors_set(swigCPtr, VkRect2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkPipelineViewportStateCreateInfo_pScissors_get(swigCPtr);
      VkRect2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkRect2D(cPtr, false);
      return ret;
    } 
  }

  public VkPipelineViewportStateCreateInfo() : this(vulkanPINVOKE.new_VkPipelineViewportStateCreateInfo(), true) {
  }

}