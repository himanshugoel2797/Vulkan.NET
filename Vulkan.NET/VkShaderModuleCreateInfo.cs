//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkShaderModuleCreateInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkShaderModuleCreateInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkShaderModuleCreateInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkShaderModuleCreateInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkShaderModuleCreateInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VkStructureType sType {
    set {
      vulkanPINVOKE.VkShaderModuleCreateInfo_sType_set(swigCPtr, (int)value);
    } 
    get {
      VkStructureType ret = (VkStructureType)vulkanPINVOKE.VkShaderModuleCreateInfo_sType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pNext {
    set {
      vulkanPINVOKE.VkShaderModuleCreateInfo_pNext_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkShaderModuleCreateInfo_pNext_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t flags {
    set {
      vulkanPINVOKE.VkShaderModuleCreateInfo_flags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(vulkanPINVOKE.VkShaderModuleCreateInfo_flags_get(swigCPtr), true);
      if (vulkanPINVOKE.SWIGPendingException.Pending) throw vulkanPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint codeSize {
    set {
      vulkanPINVOKE.VkShaderModuleCreateInfo_codeSize_set(swigCPtr, value);
    } 
    get {
      uint ret = vulkanPINVOKE.VkShaderModuleCreateInfo_codeSize_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t pCode {
    set {
      vulkanPINVOKE.VkShaderModuleCreateInfo_pCode_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkShaderModuleCreateInfo_pCode_get(swigCPtr);
      SWIGTYPE_p_uint32_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_uint32_t(cPtr, false);
      return ret;
    } 
  }

  public VkShaderModuleCreateInfo() : this(vulkanPINVOKE.new_VkShaderModuleCreateInfo(), true) {
  }

}