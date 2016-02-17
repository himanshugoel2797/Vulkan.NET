//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VkClearColorValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VkClearColorValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VkClearColorValue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VkClearColorValue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vulkanPINVOKE.delete_VkClearColorValue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_float float32 {
    set {
      vulkanPINVOKE.VkClearColorValue_float32_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkClearColorValue_float32_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int32_t int32 {
    set {
      vulkanPINVOKE.VkClearColorValue_int32_set(swigCPtr, SWIGTYPE_p_int32_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkClearColorValue_int32_get(swigCPtr);
      SWIGTYPE_p_int32_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int32_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t uint32 {
    set {
      vulkanPINVOKE.VkClearColorValue_uint32_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = vulkanPINVOKE.VkClearColorValue_uint32_get(swigCPtr);
      SWIGTYPE_p_uint32_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_uint32_t(cPtr, false);
      return ret;
    } 
  }

  public VkClearColorValue() : this(vulkanPINVOKE.new_VkClearColorValue(), true) {
  }

}