//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public enum VkAttachmentLoadOp {
  VK_ATTACHMENT_LOAD_OP_LOAD = 0,
  VK_ATTACHMENT_LOAD_OP_CLEAR = 1,
  VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2,
  VK_ATTACHMENT_LOAD_OP_BEGIN_RANGE = VK_ATTACHMENT_LOAD_OP_LOAD,
  VK_ATTACHMENT_LOAD_OP_END_RANGE = VK_ATTACHMENT_LOAD_OP_DONT_CARE,
  VK_ATTACHMENT_LOAD_OP_RANGE_SIZE = (VK_ATTACHMENT_LOAD_OP_DONT_CARE-VK_ATTACHMENT_LOAD_OP_LOAD+1),
  VK_ATTACHMENT_LOAD_OP_MAX_ENUM = 0x7FFFFFFF
}
