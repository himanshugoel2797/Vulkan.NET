//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkPipelineRasterizationStateCreateInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkPipelineRasterizationStateCreateInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkPipelineRasterizationStateCreateInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkPipelineRasterizationStateCreateInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkPipelineRasterizationStateCreateInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VkStructureType sType {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_sType_set(swigCPtr, (int)value);
    } 
    get {
      VkStructureType ret = (VkStructureType)vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_sType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pNext {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_pNext_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_pNext_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t flags {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_flags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_flags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t depthClampEnable {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthClampEnable_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthClampEnable_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t rasterizerDiscardEnable {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_rasterizerDiscardEnable_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_rasterizerDiscardEnable_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkPolygonMode polygonMode {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_polygonMode_set(swigCPtr, (int)value);
    } 
    get {
      VkPolygonMode ret = (VkPolygonMode)vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_polygonMode_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t cullMode {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_cullMode_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_cullMode_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VkFrontFace frontFace {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_frontFace_set(swigCPtr, (int)value);
    } 
    get {
      VkFrontFace ret = (VkFrontFace)vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_frontFace_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t depthBiasEnable {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasEnable_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasEnable_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float depthBiasConstantFactor {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasConstantFactor_set(swigCPtr, value);
    } 
    get {
      float ret = vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasConstantFactor_get(swigCPtr);
      return ret;
    } 
  }

  public float depthBiasClamp {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasClamp_set(swigCPtr, value);
    } 
    get {
      float ret = vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasClamp_get(swigCPtr);
      return ret;
    } 
  }

  public float depthBiasSlopeFactor {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasSlopeFactor_set(swigCPtr, value);
    } 
    get {
      float ret = vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_depthBiasSlopeFactor_get(swigCPtr);
      return ret;
    } 
  }

  public float lineWidth {
    set {
      vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_lineWidth_set(swigCPtr, value);
    } 
    get {
      float ret = vulkanPINVOKE.VkPipelineRasterizationStateCreateInfo_lineWidth_get(swigCPtr);
      return ret;
    } 
  }

  public VkPipelineRasterizationStateCreateInfo() : this(vulkanPINVOKE.new_VkPipelineRasterizationStateCreateInfo(), true) {
  }

}
