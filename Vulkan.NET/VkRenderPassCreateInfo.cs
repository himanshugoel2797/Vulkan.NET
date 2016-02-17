//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkRenderPassCreateInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkRenderPassCreateInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkRenderPassCreateInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkRenderPassCreateInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkRenderPassCreateInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VkStructureType sType {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_sType_set(swigCPtr, (int)value);
    } 
    get {
      VkStructureType ret = (VkStructureType)vulkanPINVOKE.VkRenderPassCreateInfo_sType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pNext {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_pNext_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkRenderPassCreateInfo_pNext_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t flags {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_flags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkRenderPassCreateInfo_flags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t attachmentCount {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_attachmentCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkRenderPassCreateInfo_attachmentCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkAttachmentDescription pAttachments {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_pAttachments_set(swigCPtr, VkAttachmentDescription.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkRenderPassCreateInfo_pAttachments_get(swigCPtr);
      VkAttachmentDescription ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkAttachmentDescription(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t subpassCount {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_subpassCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkRenderPassCreateInfo_subpassCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkSubpassDescription pSubpasses {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_pSubpasses_set(swigCPtr, VkSubpassDescription.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkRenderPassCreateInfo_pSubpasses_get(swigCPtr);
      VkSubpassDescription ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkSubpassDescription(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t dependencyCount {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_dependencyCount_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkRenderPassCreateInfo_dependencyCount_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkSubpassDependency pDependencies {
    set {
      vulkanPINVOKE.VkRenderPassCreateInfo_pDependencies_set(swigCPtr, VkSubpassDependency.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkRenderPassCreateInfo_pDependencies_get(swigCPtr);
      VkSubpassDependency ret = (cPtr == global::System.IntPtr.Zero) ? null : new VkSubpassDependency(cPtr, false);
      return ret;
    } 
  }

  public VkRenderPassCreateInfo() : this(vulkanPINVOKE.new_VkRenderPassCreateInfo(), true) {
  }

}