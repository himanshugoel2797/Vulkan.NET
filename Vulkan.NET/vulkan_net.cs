
using System;

namespace Vulkan.NET
{
    public class Vk
    {
        public enum PipelineCacheHeaderVersion
        {
            VersionEndRange = 1,
            VersionOne = 1,
            VersionBeginRange = 1,
            VersionMaxEnum = 2147483647,
            VersionRangeSize = -1,
        }

        public enum Result
        {
            Success = 0,
            NotReady = 1,
            Timeout = 2,
            EventSet = 3,
            EventReset = 4,
            ResultEndRange = 5,
            Incomplete = 5,
            ResultRangeSize = 15,
            SuboptimalKHR = 1000001003,
            ResultMaxEnum = 2147483647,
            ErrorValidationFailedEXT = -1000011001,
            ErrorIncompatibleDisplayKHR = -1000003001,
            ErrorOutOfDateKHR = -1000001004,
            ErrorNativeWindowInUseKHR = -1000000001,
            ErrorSurfaceLostKHR = -1000000000,
            ErrorFormatNotSupported = -11,
            ResultBeginRange = -11,
            ErrorTooManyObjects = -10,
            ErrorIncompatibleDriver = -9,
            ErrorFeatureNotPresent = -8,
            ErrorExtensionNotPresent = -7,
            ErrorLayerNotPresent = -6,
            ErrorMemoryMapFailed = -5,
            ErrorDeviceLost = -4,
            ErrorInitializationFailed = -3,
            ErrorOutOfDeviceMemory = -2,
            ErrorOutOfHostMemory = -1,
        }

        public enum StructureType
        {
            TypeApplicationInfo = 0,
            TypeBeginRange = 0,
            TypeInstanceCreateInfo = 1,
            TypeDeviceQueueCreateInfo = 2,
            TypeDeviceCreateInfo = 3,
            TypeSubmitInfo = 4,
            TypeMemoryAllocateInfo = 5,
            TypeMappedMemoryRange = 6,
            TypeBindSparseInfo = 7,
            TypeFenceCreateInfo = 8,
            TypeSemaphoreCreateInfo = 9,
            TypeEventCreateInfo = 10,
            TypeQueryPoolCreateInfo = 11,
            TypeBufferCreateInfo = 12,
            TypeBufferViewCreateInfo = 13,
            TypeImageCreateInfo = 14,
            TypeImageViewCreateInfo = 15,
            TypeShaderModuleCreateInfo = 16,
            TypePipelineCacheCreateInfo = 17,
            TypePipelineShaderStageCreateInfo = 18,
            TypePipelineVertexInputStateCreateInfo = 19,
            TypePipelineInputAssemblyStateCreateInfo = 20,
            TypePipelineTessellationStateCreateInfo = 21,
            TypePipelineViewportStateCreateInfo = 22,
            TypePipelineRasterizationStateCreateInfo = 23,
            TypePipelineMultisampleStateCreateInfo = 24,
            TypePipelineDepthStencilStateCreateInfo = 25,
            TypePipelineColorBlendStateCreateInfo = 26,
            TypePipelineDynamicStateCreateInfo = 27,
            TypeGraphicsPipelineCreateInfo = 28,
            TypeComputePipelineCreateInfo = 29,
            TypePipelineLayoutCreateInfo = 30,
            TypeSamplerCreateInfo = 31,
            TypeDescriptorSetLayoutCreateInfo = 32,
            TypeDescriptorPoolCreateInfo = 33,
            TypeDescriptorSetAllocateInfo = 34,
            TypeWriteDescriptorSet = 35,
            TypeCopyDescriptorSet = 36,
            TypeFramebufferCreateInfo = 37,
            TypeRenderPassCreateInfo = 38,
            TypeCommandPoolCreateInfo = 39,
            TypeCommandBufferAllocateInfo = 40,
            TypeCommandBufferInheritanceInfo = 41,
            TypeCommandBufferBeginInfo = 42,
            TypeRenderPassBeginInfo = 43,
            TypeBufferMemoryBarrier = 44,
            TypeImageMemoryBarrier = 45,
            TypeMemoryBarrier = 46,
            TypeLoaderInstanceCreateInfo = 47,
            TypeRangeSize = 47,
            TypeLoaderDeviceCreateInfo = 48,
            TypeEndRange = 48,
            TypeSwapchainCreateInfoKHR = 1000001000,
            TypePresentInfoKHR = 1000001001,
            TypeDisplayModeCreateInfoKHR = 1000002000,
            TypeDisplaySurfaceCreateInfoKHR = 1000002001,
            TypeDisplayPresentInfoKHR = 1000003000,
            TypeXlibSurfaceCreateInfoKHR = 1000004000,
            TypeXcbSurfaceCreateInfoKHR = 1000005000,
            TypeWaylandSurfaceCreateInfoKHR = 1000006000,
            TypeMirSurfaceCreateInfoKHR = 1000007000,
            TypeAndroidSurfaceCreateInfoKHR = 1000008000,
            TypeWin32SurfaceCreateInfoKHR = 1000009000,
            TypeDebugReportCreateInfoEXT = 1000011000,
            TypeMaxEnum = 2147483647,
        }

        public enum SystemAllocationScope
        {
            ScopeCommand = 0,
            ScopeBeginRange = 0,
            ScopeObject = 1,
            ScopeCache = 2,
            ScopeRangeSize = 3,
            ScopeDevice = 3,
            ScopeInstance = 4,
            ScopeEndRange = 4,
            ScopeMaxEnum = 2147483647,
        }

        public enum InternalAllocationType
        {
            TypeEndRange = 0,
            TypeExecutable = 0,
            TypeBeginRange = 0,
            TypeMaxEnum = 2147483647,
            TypeRangeSize = -1,
        }

        public enum Format
        {
            FormatBeginRange = 0,
            FormatUndefined = 0,
            FormatR4g4UnormPack8 = 1,
            FormatR4g4b4a4UnormPack16 = 2,
            FormatB4g4r4a4UnormPack16 = 3,
            FormatR5g6b5UnormPack16 = 4,
            FormatB5g6r5UnormPack16 = 5,
            FormatR5g5b5a1UnormPack16 = 6,
            FormatB5g5r5a1UnormPack16 = 7,
            FormatA1r5g5b5UnormPack16 = 8,
            FormatR8Unorm = 9,
            FormatR8Snorm = 10,
            FormatR8Uscaled = 11,
            FormatR8Sscaled = 12,
            FormatR8Uint = 13,
            FormatR8Sint = 14,
            FormatR8SRGB = 15,
            FormatR8g8Unorm = 16,
            FormatR8g8Snorm = 17,
            FormatR8g8Uscaled = 18,
            FormatR8g8Sscaled = 19,
            FormatR8g8Uint = 20,
            FormatR8g8Sint = 21,
            FormatR8g8SRGB = 22,
            FormatR8g8b8Unorm = 23,
            FormatR8g8b8Snorm = 24,
            FormatR8g8b8Uscaled = 25,
            FormatR8g8b8Sscaled = 26,
            FormatR8g8b8Uint = 27,
            FormatR8g8b8Sint = 28,
            FormatR8g8b8SRGB = 29,
            FormatB8g8r8Unorm = 30,
            FormatB8g8r8Snorm = 31,
            FormatB8g8r8Uscaled = 32,
            FormatB8g8r8Sscaled = 33,
            FormatB8g8r8Uint = 34,
            FormatB8g8r8Sint = 35,
            FormatB8g8r8SRGB = 36,
            FormatR8g8b8a8Unorm = 37,
            FormatR8g8b8a8Snorm = 38,
            FormatR8g8b8a8Uscaled = 39,
            FormatR8g8b8a8Sscaled = 40,
            FormatR8g8b8a8Uint = 41,
            FormatR8g8b8a8Sint = 42,
            FormatR8g8b8a8SRGB = 43,
            FormatB8g8r8a8Unorm = 44,
            FormatB8g8r8a8Snorm = 45,
            FormatB8g8r8a8Uscaled = 46,
            FormatB8g8r8a8Sscaled = 47,
            FormatB8g8r8a8Uint = 48,
            FormatB8g8r8a8Sint = 49,
            FormatB8g8r8a8SRGB = 50,
            FormatA8b8g8r8UnormPack32 = 51,
            FormatA8b8g8r8SnormPack32 = 52,
            FormatA8b8g8r8UscaledPack32 = 53,
            FormatA8b8g8r8SscaledPack32 = 54,
            FormatA8b8g8r8UintPack32 = 55,
            FormatA8b8g8r8SintPack32 = 56,
            FormatA8b8g8r8SRGBPack32 = 57,
            FormatA2r10g10b10UnormPack32 = 58,
            FormatA2r10g10b10SnormPack32 = 59,
            FormatA2r10g10b10UscaledPack32 = 60,
            FormatA2r10g10b10SscaledPack32 = 61,
            FormatA2r10g10b10UintPack32 = 62,
            FormatA2r10g10b10SintPack32 = 63,
            FormatA2b10g10r10UnormPack32 = 64,
            FormatA2b10g10r10SnormPack32 = 65,
            FormatA2b10g10r10UscaledPack32 = 66,
            FormatA2b10g10r10SscaledPack32 = 67,
            FormatA2b10g10r10UintPack32 = 68,
            FormatA2b10g10r10SintPack32 = 69,
            FormatR16Unorm = 70,
            FormatR16Snorm = 71,
            FormatR16Uscaled = 72,
            FormatR16Sscaled = 73,
            FormatR16Uint = 74,
            FormatR16Sint = 75,
            FormatR16Sfloat = 76,
            FormatR16g16Unorm = 77,
            FormatR16g16Snorm = 78,
            FormatR16g16Uscaled = 79,
            FormatR16g16Sscaled = 80,
            FormatR16g16Uint = 81,
            FormatR16g16Sint = 82,
            FormatR16g16Sfloat = 83,
            FormatR16g16b16Unorm = 84,
            FormatR16g16b16Snorm = 85,
            FormatR16g16b16Uscaled = 86,
            FormatR16g16b16Sscaled = 87,
            FormatR16g16b16Uint = 88,
            FormatR16g16b16Sint = 89,
            FormatR16g16b16Sfloat = 90,
            FormatR16g16b16a16Unorm = 91,
            FormatR16g16b16a16Snorm = 92,
            FormatR16g16b16a16Uscaled = 93,
            FormatR16g16b16a16Sscaled = 94,
            FormatR16g16b16a16Uint = 95,
            FormatR16g16b16a16Sint = 96,
            FormatR16g16b16a16Sfloat = 97,
            FormatR32Uint = 98,
            FormatR32Sint = 99,
            FormatR32Sfloat = 100,
            FormatR32g32Uint = 101,
            FormatR32g32Sint = 102,
            FormatR32g32Sfloat = 103,
            FormatR32g32b32Uint = 104,
            FormatR32g32b32Sint = 105,
            FormatR32g32b32Sfloat = 106,
            FormatR32g32b32a32Uint = 107,
            FormatR32g32b32a32Sint = 108,
            FormatR32g32b32a32Sfloat = 109,
            FormatR64Uint = 110,
            FormatR64Sint = 111,
            FormatR64Sfloat = 112,
            FormatR64g64Uint = 113,
            FormatR64g64Sint = 114,
            FormatR64g64Sfloat = 115,
            FormatR64g64b64Uint = 116,
            FormatR64g64b64Sint = 117,
            FormatR64g64b64Sfloat = 118,
            FormatR64g64b64a64Uint = 119,
            FormatR64g64b64a64Sint = 120,
            FormatR64g64b64a64Sfloat = 121,
            FormatB10g11r11UfloatPack32 = 122,
            FormatE5b9g9r9UfloatPack32 = 123,
            FormatD16Unorm = 124,
            FormatX8D24UnormPack32 = 125,
            FormatD32Sfloat = 126,
            FormatS8Uint = 127,
            FormatD16UnormS8Uint = 128,
            FormatD24UnormS8Uint = 129,
            FormatD32SfloatS8Uint = 130,
            FormatBc1RGBUnormBlock = 131,
            FormatBc1RGB_SRGBBlock = 132,
            FormatBc1RGBAUnormBlock = 133,
            FormatBc1RGBA_SRGBBlock = 134,
            FormatBc2UnormBlock = 135,
            FormatBc2SRGBBlock = 136,
            FormatBc3UnormBlock = 137,
            FormatBc3SRGBBlock = 138,
            FormatBc4UnormBlock = 139,
            FormatBc4SnormBlock = 140,
            FormatBc5UnormBlock = 141,
            FormatBc5SnormBlock = 142,
            FormatBc6hUfloatBlock = 143,
            FormatBc6hSfloatBlock = 144,
            FormatBc7UnormBlock = 145,
            FormatBc7SRGBBlock = 146,
            FormatEtc2R8g8b8UnormBlock = 147,
            FormatEtc2R8g8b8SRGBBlock = 148,
            FormatEtc2R8g8b8a1UnormBlock = 149,
            FormatEtc2R8g8b8a1SRGBBlock = 150,
            FormatEtc2R8g8b8a8UnormBlock = 151,
            FormatEtc2R8g8b8a8SRGBBlock = 152,
            FormatEacR11UnormBlock = 153,
            FormatEacR11SnormBlock = 154,
            FormatEacR11g11UnormBlock = 155,
            FormatEacR11g11SnormBlock = 156,
            FormatAstc4x4UnormBlock = 157,
            FormatAstc4x4SRGBBlock = 158,
            FormatAstc5x4UnormBlock = 159,
            FormatAstc5x4SRGBBlock = 160,
            FormatAstc5x5UnormBlock = 161,
            FormatAstc5x5SRGBBlock = 162,
            FormatAstc6x5UnormBlock = 163,
            FormatAstc6x5SRGBBlock = 164,
            FormatAstc6x6UnormBlock = 165,
            FormatAstc6x6SRGBBlock = 166,
            FormatAstc8x5UnormBlock = 167,
            FormatAstc8x5SRGBBlock = 168,
            FormatAstc8x6UnormBlock = 169,
            FormatAstc8x6SRGBBlock = 170,
            FormatAstc8x8UnormBlock = 171,
            FormatAstc8x8SRGBBlock = 172,
            FormatAstc10x5UnormBlock = 173,
            FormatAstc10x5SRGBBlock = 174,
            FormatAstc10x6UnormBlock = 175,
            FormatAstc10x6SRGBBlock = 176,
            FormatAstc10x8UnormBlock = 177,
            FormatAstc10x8SRGBBlock = 178,
            FormatAstc10x10UnormBlock = 179,
            FormatAstc10x10SRGBBlock = 180,
            FormatAstc12x10UnormBlock = 181,
            FormatAstc12x10SRGBBlock = 182,
            FormatRangeSize = 183,
            FormatAstc12x12UnormBlock = 183,
            FormatAstc12x12SRGBBlock = 184,
            FormatEndRange = 184,
            FormatMaxEnum = 2147483647,
        }

        public enum ImageType
        {
            TypeBeginRange = 0,
            Type1d = 0,
            TypeRangeSize = 1,
            Type2d = 1,
            TypeEndRange = 2,
            Type3d = 2,
            TypeMaxEnum = 2147483647,
        }

        public enum ImageTiling
        {
            TilingBeginRange = 0,
            TilingRangeSize = 0,
            TilingOptimal = 0,
            TilingEndRange = 1,
            TilingLinear = 1,
            TilingMaxEnum = 2147483647,
        }

        public enum PhysicalDeviceType
        {
            TypeOther = 0,
            TypeBeginRange = 0,
            TypeIntegratedGpu = 1,
            TypeDiscreteGpu = 2,
            TypeRangeSize = 3,
            TypeVirtualGpu = 3,
            TypeCpu = 4,
            TypeEndRange = 4,
            TypeMaxEnum = 2147483647,
        }

        public enum QueryType
        {
            TypeBeginRange = 0,
            TypeOcclusion = 0,
            TypeRangeSize = 1,
            TypePipelineStatistics = 1,
            TypeEndRange = 2,
            TypeTimestamp = 2,
            TypeMaxEnum = 2147483647,
        }

        public enum SharingMode
        {
            ModeBeginRange = 0,
            ModeRangeSize = 0,
            ModeExclusive = 0,
            ModeEndRange = 1,
            ModeConcurrent = 1,
            ModeMaxEnum = 2147483647,
        }

        public enum ImageLayout
        {
            LayoutBeginRange = 0,
            LayoutUndefined = 0,
            LayoutGeneral = 1,
            LayoutColorAttachmentOptimal = 2,
            LayoutDepthStencilAttachmentOptimal = 3,
            LayoutDepthStencilReadOnlyOptimal = 4,
            LayoutShaderReadOnlyOptimal = 5,
            LayoutTransferSrcOptimal = 6,
            LayoutTransferDstOptimal = 7,
            LayoutRangeSize = 7,
            LayoutEndRange = 8,
            LayoutPreinitialized = 8,
            LayoutPresentSrcKHR = 1000001002,
            LayoutMaxEnum = 2147483647,
        }

        public enum ImageViewType
        {
            TypeBeginRange = 0,
            Type1d = 0,
            Type2d = 1,
            Type3d = 2,
            TypeCube = 3,
            Type1dArray = 4,
            Type2dArray = 5,
            TypeRangeSize = 5,
            TypeEndRange = 6,
            TypeCubeArray = 6,
            TypeMaxEnum = 2147483647,
        }

        public enum ComponentSwizzle
        {
            SwizzleBeginRange = 0,
            SwizzleIdentity = 0,
            SwizzleZero = 1,
            SwizzleOne = 2,
            SwizzleR = 3,
            SwizzleG = 4,
            SwizzleB = 5,
            SwizzleRangeSize = 5,
            SwizzleEndRange = 6,
            SwizzleA = 6,
            SwizzleMaxEnum = 2147483647,
        }

        public enum VertexInputRate
        {
            RateBeginRange = 0,
            RateRangeSize = 0,
            RateVertex = 0,
            RateEndRange = 1,
            RateInstance = 1,
            RateMaxEnum = 2147483647,
        }

        public enum PrimitiveTopology
        {
            TopologyBeginRange = 0,
            TopologyPointList = 0,
            TopologyLineList = 1,
            TopologyLineStrip = 2,
            TopologyTriangleList = 3,
            TopologyTriangleStrip = 4,
            TopologyTriangleFan = 5,
            TopologyLineListWithAdjacency = 6,
            TopologyLineStripWithAdjacency = 7,
            TopologyTriangleListWithAdjacency = 8,
            TopologyRangeSize = 9,
            TopologyTriangleStripWithAdjacency = 9,
            TopologyEndRange = 10,
            TopologyPatchList = 10,
            TopologyMaxEnum = 2147483647,
        }

        public enum PolygonMode
        {
            ModeBeginRange = 0,
            ModeFill = 0,
            ModeRangeSize = 1,
            ModeLine = 1,
            ModeEndRange = 2,
            ModePoint = 2,
            ModeMaxEnum = 2147483647,
        }

        public enum FrontFace
        {
            FaceBeginRange = 0,
            FaceRangeSize = 0,
            FaceCounterClockwise = 0,
            FaceEndRange = 1,
            FaceClockwise = 1,
            FaceMaxEnum = 2147483647,
        }

        public enum CompareOp
        {
            OpBeginRange = 0,
            OpNever = 0,
            OpLess = 1,
            OpEqual = 2,
            OpLessOrEqual = 3,
            OpGreater = 4,
            OpNotEqual = 5,
            OpRangeSize = 6,
            OpGreaterOrEqual = 6,
            OpEndRange = 7,
            OpAlways = 7,
            OpMaxEnum = 2147483647,
        }

        public enum StencilOp
        {
            OpBeginRange = 0,
            OpKeep = 0,
            OpZero = 1,
            OpReplace = 2,
            OpIncrementAndClamp = 3,
            OpDecrementAndClamp = 4,
            OpInvert = 5,
            OpRangeSize = 6,
            OpIncrementAndWrap = 6,
            OpEndRange = 7,
            OpDecrementAndWrap = 7,
            OpMaxEnum = 2147483647,
        }

        public enum LogicOp
        {
            OpClear = 0,
            OpBeginRange = 0,
            OpAnd = 1,
            OpAndReverse = 2,
            OpCopy = 3,
            OpAndInverted = 4,
            OpNoOp = 5,
            OpXor = 6,
            OpOr = 7,
            OpNor = 8,
            OpEquivalent = 9,
            OpInvert = 10,
            OpOrReverse = 11,
            OpCopyInverted = 12,
            OpOrInverted = 13,
            OpRangeSize = 14,
            OpNand = 14,
            OpSet = 15,
            OpEndRange = 15,
            OpMaxEnum = 2147483647,
        }

        public enum BlendFactor
        {
            FactorZero = 0,
            FactorBeginRange = 0,
            FactorOne = 1,
            FactorSrcColor = 2,
            FactorOneMinusSrcColor = 3,
            FactorDstColor = 4,
            FactorOneMinusDstColor = 5,
            FactorSrcAlpha = 6,
            FactorOneMinusSrcAlpha = 7,
            FactorDstAlpha = 8,
            FactorOneMinusDstAlpha = 9,
            FactorConstantColor = 10,
            FactorOneMinusConstantColor = 11,
            FactorConstantAlpha = 12,
            FactorOneMinusConstantAlpha = 13,
            FactorSrcAlphaSaturate = 14,
            FactorSrc1Color = 15,
            FactorOneMinusSrc1Color = 16,
            FactorSrc1Alpha = 17,
            FactorRangeSize = 17,
            FactorEndRange = 18,
            FactorOneMinusSrc1Alpha = 18,
            FactorMaxEnum = 2147483647,
        }

        public enum BlendOp
        {
            OpAdd = 0,
            OpBeginRange = 0,
            OpSubtract = 1,
            OpReverseSubtract = 2,
            OpRangeSize = 3,
            OpMin = 3,
            OpMax = 4,
            OpEndRange = 4,
            OpMaxEnum = 2147483647,
        }

        public enum DynamicState
        {
            StateBeginRange = 0,
            StateViewport = 0,
            StateScissor = 1,
            StateLineWidth = 2,
            StateDepthBias = 3,
            StateBlendConstants = 4,
            StateDepthBounds = 5,
            StateStencilCompareMask = 6,
            StateRangeSize = 7,
            StateStencilWriteMask = 7,
            StateEndRange = 8,
            StateStencilReference = 8,
            StateMaxEnum = 2147483647,
        }

        public enum Filter
        {
            FilterBeginRange = 0,
            FilterRangeSize = 0,
            FilterNearest = 0,
            FilterEndRange = 1,
            FilterLinear = 1,
            FilterMaxEnum = 2147483647,
        }

        public enum SamplerMipmapMode
        {
            ModeBeginRange = 0,
            ModeRangeSize = 0,
            ModeNearest = 0,
            ModeEndRange = 1,
            ModeLinear = 1,
            ModeMaxEnum = 2147483647,
        }

        public enum SamplerAddressMode
        {
            ModeRepeat = 0,
            ModeBeginRange = 0,
            ModeMirroredRepeat = 1,
            ModeClampToEdge = 2,
            ModeRangeSize = 3,
            ModeClampToBorder = 3,
            ModeMirrorClampToEdge = 4,
            ModeEndRange = 4,
            ModeMaxEnum = 2147483647,
        }

        public enum BorderColor
        {
            ColorBeginRange = 0,
            ColorFloatTransparentBlack = 0,
            ColorIntTransparentBlack = 1,
            ColorFloatOpaqueBlack = 2,
            ColorIntOpaqueBlack = 3,
            ColorFloatOpaqueWhite = 4,
            ColorRangeSize = 4,
            ColorEndRange = 5,
            ColorIntOpaqueWhite = 5,
            ColorMaxEnum = 2147483647,
        }

        public enum DescriptorType
        {
            TypeBeginRange = 0,
            TypeSampler = 0,
            TypeCombinedImageSampler = 1,
            TypeSampledImage = 2,
            TypeStorageImage = 3,
            TypeUniformTexelBuffer = 4,
            TypeStorageTexelBuffer = 5,
            TypeUniformBuffer = 6,
            TypeStorageBuffer = 7,
            TypeUniformBufferDynamic = 8,
            TypeRangeSize = 9,
            TypeStorageBufferDynamic = 9,
            TypeEndRange = 10,
            TypeInputAttachment = 10,
            TypeMaxEnum = 2147483647,
        }

        public enum AttachmentLoadOp
        {
            OpBeginRange = 0,
            OpLoad = 0,
            OpRangeSize = 1,
            OpClear = 1,
            OpEndRange = 2,
            OpDontCare = 2,
            OpMaxEnum = 2147483647,
        }

        public enum AttachmentStoreOp
        {
            OpBeginRange = 0,
            OpRangeSize = 0,
            OpStore = 0,
            OpEndRange = 1,
            OpDontCare = 1,
            OpMaxEnum = 2147483647,
        }

        public enum PipelineBindPoint
        {
            PointBeginRange = 0,
            PointRangeSize = 0,
            PointGraphics = 0,
            PointEndRange = 1,
            PointCompute = 1,
            PointMaxEnum = 2147483647,
        }

        public enum CommandBufferLevel
        {
            LevelBeginRange = 0,
            LevelRangeSize = 0,
            LevelPrimary = 0,
            LevelEndRange = 1,
            LevelSecondary = 1,
            LevelMaxEnum = 2147483647,
        }

        public enum IndexType
        {
            TypeBeginRange = 0,
            TypeRangeSize = 0,
            TypeUint16 = 0,
            TypeEndRange = 1,
            TypeUint32 = 1,
            TypeMaxEnum = 2147483647,
        }

        public enum SubpassContents
        {
            ContentsBeginRange = 0,
            ContentsRangeSize = 0,
            ContentsInline = 0,
            ContentsEndRange = 1,
            ContentsSecondaryCommandBuffers = 1,
            ContentsMaxEnum = 2147483647,
        }

        public enum FormatFeatureFlagBits
        {
            SampledImageBit = 1,
            StorageImageBit = 2,
            StorageImageAtomicBit = 4,
            UniformTexelBufferBit = 8,
            StorageTexelBufferBit = 16,
            StorageTexelBufferAtomicBit = 32,
            VertexBufferBit = 64,
            ColorAttachmentBit = 128,
            ColorAttachmentBlendBit = 256,
            DepthStencilAttachmentBit = 512,
            BlitSrcBit = 1024,
            BlitDstBit = 2048,
            SampledImageFilterLinearBit = 4096,
        }

        public enum ImageUsageFlagBits
        {
            TransferSrcBit = 1,
            TransferDstBit = 2,
            SampledBit = 4,
            StorageBit = 8,
            ColorAttachmentBit = 16,
            DepthStencilAttachmentBit = 32,
            TransientAttachmentBit = 64,
            InputAttachmentBit = 128,
        }

        public enum ImageCreateFlagBits
        {
            SparseBindingBit = 1,
            SparseResidencyBit = 2,
            SparseAliasedBit = 4,
            MutableFormatBit = 8,
            CubeCompatibleBit = 16,
        }

        public enum SampleCountFlagBits
        {
            _1Bit = 1,
            _2Bit = 2,
            _4Bit = 4,
            _8Bit = 8,
            _16Bit = 16,
            _32Bit = 32,
            _64Bit = 64,
        }

        public enum QueueFlagBits
        {
            GraphicsBit = 1,
            ComputeBit = 2,
            TransferBit = 4,
            SparseBindingBit = 8,
        }

        public enum MemoryPropertyFlagBits
        {
            DeviceLocalBit = 1,
            HostVisibleBit = 2,
            HostCoherentBit = 4,
            HostCachedBit = 8,
            LazilyAllocatedBit = 16,
        }

        public enum MemoryHeapFlagBits
        {
            DeviceLocalBit = 1,
        }

        public enum PipelineStageFlagBits
        {
            TopOfPipeBit = 1,
            DrawIndirectBit = 2,
            VertexInputBit = 4,
            VertexShaderBit = 8,
            TessellationControlShaderBit = 16,
            TessellationEvaluationShaderBit = 32,
            GeometryShaderBit = 64,
            FragmentShaderBit = 128,
            EarlyFragmentTestsBit = 256,
            LateFragmentTestsBit = 512,
            ColorAttachmentOutputBit = 1024,
            ComputeShaderBit = 2048,
            TransferBit = 4096,
            BottomOfPipeBit = 8192,
            HostBit = 16384,
            AllGraphicsBit = 32768,
            AllCommandsBit = 65536,
        }

        public enum ImageAspectFlagBits
        {
            ColorBit = 1,
            DepthBit = 2,
            StencilBit = 4,
            MetadataBit = 8,
        }

        public enum SparseImageFormatFlagBits
        {
            SingleMiptailBit = 1,
            AlignedMipSizeBit = 2,
            NonstandardBlockSizeBit = 4,
        }

        public enum SparseMemoryBindFlagBits
        {
            MetadataBit = 1,
        }

        public enum FenceCreateFlagBits
        {
            SignaledBit = 1,
        }

        public enum QueryPipelineStatisticFlagBits
        {
            InputAssemblyVerticesBit = 1,
            InputAssemblyPrimitivesBit = 2,
            VertexShaderInvocationsBit = 4,
            GeometryShaderInvocationsBit = 8,
            GeometryShaderPrimitivesBit = 16,
            ClippingInvocationsBit = 32,
            ClippingPrimitivesBit = 64,
            FragmentShaderInvocationsBit = 128,
            TessellationControlShaderPatchesBit = 256,
            TessellationEvaluationShaderInvocationsBit = 512,
            ComputeShaderInvocationsBit = 1024,
        }

        public enum QueryResultFlagBits
        {
            _64Bit = 1,
            WaitBit = 2,
            WithAvailabilityBit = 4,
            PartialBit = 8,
        }

        public enum BufferCreateFlagBits
        {
            SparseBindingBit = 1,
            SparseResidencyBit = 2,
            SparseAliasedBit = 4,
        }

        public enum BufferUsageFlagBits
        {
            TransferSrcBit = 1,
            TransferDstBit = 2,
            UniformTexelBit = 4,
            StorageTexelBit = 8,
            UniformBit = 16,
            StorageBit = 32,
            IndexBit = 64,
            VertexBit = 128,
            IndirectBit = 256,
        }

        public enum PipelineCreateFlagBits
        {
            DisableOptimizationBit = 1,
            AllowDerivativesBit = 2,
            DerivativeBit = 4,
        }

        public enum ShaderStageFlagBits
        {
            VertexBit = 1,
            TessellationControlBit = 2,
            TessellationEvaluationBit = 4,
            GeometryBit = 8,
            FragmentBit = 16,
            AllGraphics = 31,
            ComputeBit = 32,
            All = 2147483647,
        }

        public enum CullModeFlagBits
        {
            None = 0,
            FrontBit = 1,
            BackBit = 2,
            FrontAndBack = 3,
        }

        public enum ColorComponentFlagBits
        {
            RBit = 1,
            GBit = 2,
            BBit = 4,
            ABit = 8,
        }

        public enum DescriptorPoolCreateFlagBits
        {
            FreeSetBit = 1,
        }

        public enum AttachmentDescriptionFlagBits
        {
            MayAliasBit = 1,
        }

        public enum AccessFlagBits
        {
            IndirectCommandReadBit = 1,
            IndexReadBit = 2,
            VertexAttributeReadBit = 4,
            UniformReadBit = 8,
            InputAttachmentReadBit = 16,
            ShaderReadBit = 32,
            ShaderWriteBit = 64,
            ColorAttachmentReadBit = 128,
            ColorAttachmentWriteBit = 256,
            DepthStencilAttachmentReadBit = 512,
            DepthStencilAttachmentWriteBit = 1024,
            TransferReadBit = 2048,
            TransferWriteBit = 4096,
            HostReadBit = 8192,
            HostWriteBit = 16384,
            MemoryReadBit = 32768,
            MemoryWriteBit = 65536,
        }

        public enum DependencyFlagBits
        {
            ByRegionBit = 1,
        }

        public enum CommandPoolCreateFlagBits
        {
            TransientBit = 1,
            ResetBufferBit = 2,
        }

        public enum CommandPoolResetFlagBits
        {
            ReleaseResourcesBit = 1,
        }

        public enum CommandBufferUsageFlagBits
        {
            OneTimeSubmitBit = 1,
            RenderPassContinueBit = 2,
            SimultaneousUseBit = 4,
        }

        public enum QueryControlFlagBits
        {
            PreciseBit = 1,
        }

        public enum CommandBufferResetFlagBits
        {
            ReleaseResourcesBit = 1,
        }

        public enum StencilFaceFlagBits
        {
            FrontBit = 1,
            BackBit = 2,
            FrontAndBack = 3,
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate System.IntPtr PFN_vkAllocationFunction(System.IntPtr pUserData, System.IntPtr size, System.IntPtr alignment, SystemAllocationScope allocationScope);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate System.IntPtr PFN_vkReallocationFunction(System.IntPtr pUserData, System.IntPtr pOriginal, System.IntPtr size, System.IntPtr alignment, SystemAllocationScope allocationScope);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkFreeFunction(System.IntPtr pUserData, System.IntPtr pMemory);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkInternalAllocationNotification(System.IntPtr pUserData, System.IntPtr size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkInternalFreeNotification(System.IntPtr pUserData, System.IntPtr size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkVoidFunction();

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ApplicationInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)20, SizeConst = (System.Int32)0, IidParameterIndex = (System.Int32)0)]
            public string pApplicationName;
            public uint applicationVersion;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)20, SizeConst = (System.Int32)0, IidParameterIndex = (System.Int32)0)]
            public string pEngineName;
            public uint engineVersion;
            public uint apiVersion;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct InstanceCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public System.IntPtr pApplicationInfo;
            public uint enabledLayerCount;
            public System.IntPtr ppEnabledLayerNames;
            public uint enabledExtensionCount;
            public System.IntPtr ppEnabledExtensionNames;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct AllocationCallbacks
        {
            public System.IntPtr pUserData;
            public PFN_vkAllocationFunction pfnAllocation;
            public PFN_vkReallocationFunction pfnReallocation;
            public PFN_vkFreeFunction pfnFree;
            public PFN_vkInternalAllocationNotification pfnInternalAllocation;
            public PFN_vkInternalFreeNotification pfnInternalFree;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PhysicalDeviceFeatures
        {
            public uint robustBufferAccess;
            public uint fullDrawIndexUint32;
            public uint imageCubeArray;
            public uint independentBlend;
            public uint geometryShader;
            public uint tessellationShader;
            public uint sampleRateShading;
            public uint dualSrcBlend;
            public uint logicOp;
            public uint multiDrawIndirect;
            public uint drawIndirectFirstInstance;
            public uint depthClamp;
            public uint depthBiasClamp;
            public uint fillModeNonSolid;
            public uint depthBounds;
            public uint wideLines;
            public uint largePoints;
            public uint alphaToOne;
            public uint multiViewport;
            public uint samplerAnisotropy;
            public uint textureCompressionETC2;
            public uint textureCompressionASTC_LDR;
            public uint textureCompressionBC;
            public uint occlusionQueryPrecise;
            public uint pipelineStatisticsQuery;
            public uint vertexPipelineStoresAndAtomics;
            public uint fragmentStoresAndAtomics;
            public uint shaderTessellationAndGeometryPointSize;
            public uint shaderImageGatherExtended;
            public uint shaderStorageImageExtendedFormats;
            public uint shaderStorageImageMultisample;
            public uint shaderStorageImageReadWithoutFormat;
            public uint shaderStorageImageWriteWithoutFormat;
            public uint shaderUniformBufferArrayDynamicIndexing;
            public uint shaderSampledImageArrayDynamicIndexing;
            public uint shaderStorageBufferArrayDynamicIndexing;
            public uint shaderStorageImageArrayDynamicIndexing;
            public uint shaderClipDistance;
            public uint shaderCullDistance;
            public uint shaderFloat64;
            public uint shaderInt64;
            public uint shaderInt16;
            public uint shaderResourceResidency;
            public uint shaderResourceMinLod;
            public uint sparseBinding;
            public uint sparseResidencyBuffer;
            public uint sparseResidencyImage2D;
            public uint sparseResidencyImage3D;
            public uint sparseResidency2Samples;
            public uint sparseResidency4Samples;
            public uint sparseResidency8Samples;
            public uint sparseResidency16Samples;
            public uint sparseResidencyAliased;
            public uint variableMultisampleRate;
            public uint inheritedQueries;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct FormatProperties
        {
            public uint linearTilingFeatures;
            public uint optimalTilingFeatures;
            public uint bufferFeatures;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct Extent3D
        {
            public uint width;
            public uint height;
            public uint depth;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageFormatProperties
        {
            public Extent3D maxExtent;
            public uint maxMipLevels;
            public uint maxArrayLayers;
            public uint sampleCounts;
            public uint maxResourceSize;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PhysicalDeviceLimits
        {
            public uint maxImageDimension1D;
            public uint maxImageDimension2D;
            public uint maxImageDimension3D;
            public uint maxImageDimensionCube;
            public uint maxImageArrayLayers;
            public uint maxTexelBufferElements;
            public uint maxUniformBufferRange;
            public uint maxStorageBufferRange;
            public uint maxPushConstantsSize;
            public uint maxMemoryAllocationCount;
            public uint maxSamplerAllocationCount;
            public uint bufferImageGranularity;
            public uint sparseAddressSpaceSize;
            public uint maxBoundDescriptorSets;
            public uint maxPerStageDescriptorSamplers;
            public uint maxPerStageDescriptorUniformBuffers;
            public uint maxPerStageDescriptorStorageBuffers;
            public uint maxPerStageDescriptorSampledImages;
            public uint maxPerStageDescriptorStorageImages;
            public uint maxPerStageDescriptorInputAttachments;
            public uint maxPerStageResources;
            public uint maxDescriptorSetSamplers;
            public uint maxDescriptorSetUniformBuffers;
            public uint maxDescriptorSetUniformBuffersDynamic;
            public uint maxDescriptorSetStorageBuffers;
            public uint maxDescriptorSetStorageBuffersDynamic;
            public uint maxDescriptorSetSampledImages;
            public uint maxDescriptorSetStorageImages;
            public uint maxDescriptorSetInputAttachments;
            public uint maxVertexInputAttributes;
            public uint maxVertexInputBindings;
            public uint maxVertexInputAttributeOffset;
            public uint maxVertexInputBindingStride;
            public uint maxVertexOutputComponents;
            public uint maxTessellationGenerationLevel;
            public uint maxTessellationPatchSize;
            public uint maxTessellationControlPerVertexInputComponents;
            public uint maxTessellationControlPerVertexOutputComponents;
            public uint maxTessellationControlPerPatchOutputComponents;
            public uint maxTessellationControlTotalOutputComponents;
            public uint maxTessellationEvaluationInputComponents;
            public uint maxTessellationEvaluationOutputComponents;
            public uint maxGeometryShaderInvocations;
            public uint maxGeometryInputComponents;
            public uint maxGeometryOutputComponents;
            public uint maxGeometryOutputVertices;
            public uint maxGeometryTotalOutputComponents;
            public uint maxFragmentInputComponents;
            public uint maxFragmentOutputAttachments;
            public uint maxFragmentDualSrcAttachments;
            public uint maxFragmentCombinedOutputResources;
            public uint maxComputeSharedMemorySize;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)8, SizeConst = (System.Int32)3, IidParameterIndex = (System.Int32)0)]
            public UInt32[] maxComputeWorkGroupCount;
            public uint maxComputeWorkGroupInvocations;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)8, SizeConst = (System.Int32)3, IidParameterIndex = (System.Int32)0)]
            public UInt32[] maxComputeWorkGroupSize;
            public uint subPixelPrecisionBits;
            public uint subTexelPrecisionBits;
            public uint mipmapPrecisionBits;
            public uint maxDrawIndexedIndexValue;
            public uint maxDrawIndirectCount;
            public float maxSamplerLodBias;
            public float maxSamplerAnisotropy;
            public uint maxViewports;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)8, SizeConst = (System.Int32)2, IidParameterIndex = (System.Int32)0)]
            public UInt32[] maxViewportDimensions;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)11, SizeConst = (System.Int32)2, IidParameterIndex = (System.Int32)0)]
            public Single[] viewportBoundsRange;
            public uint viewportSubPixelBits;
            public uint minMemoryMapAlignment;
            public uint minTexelBufferOffsetAlignment;
            public uint minUniformBufferOffsetAlignment;
            public uint minStorageBufferOffsetAlignment;
            public int minTexelOffset;
            public uint maxTexelOffset;
            public int minTexelGatherOffset;
            public uint maxTexelGatherOffset;
            public float minInterpolationOffset;
            public float maxInterpolationOffset;
            public uint subPixelInterpolationOffsetBits;
            public uint maxFramebufferWidth;
            public uint maxFramebufferHeight;
            public uint maxFramebufferLayers;
            public uint framebufferColorSampleCounts;
            public uint framebufferDepthSampleCounts;
            public uint framebufferStencilSampleCounts;
            public uint framebufferNoAttachmentsSampleCounts;
            public uint maxColorAttachments;
            public uint sampledImageColorSampleCounts;
            public uint sampledImageIntegerSampleCounts;
            public uint sampledImageDepthSampleCounts;
            public uint sampledImageStencilSampleCounts;
            public uint storageImageSampleCounts;
            public uint maxSampleMaskWords;
            public uint timestampComputeAndGraphics;
            public float timestampPeriod;
            public uint maxClipDistances;
            public uint maxCullDistances;
            public uint maxCombinedClipAndCullDistances;
            public uint discreteQueuePriorities;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)11, SizeConst = (System.Int32)2, IidParameterIndex = (System.Int32)0)]
            public Single[] pointSizeRange;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)11, SizeConst = (System.Int32)2, IidParameterIndex = (System.Int32)0)]
            public Single[] lineWidthRange;
            public float pointSizeGranularity;
            public float lineWidthGranularity;
            public uint strictLines;
            public uint standardSampleLocations;
            public uint optimalBufferCopyOffsetAlignment;
            public uint optimalBufferCopyRowPitchAlignment;
            public uint nonCoherentAtomSize;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PhysicalDeviceSparseProperties
        {
            public uint residencyStandard2DBlockShape;
            public uint residencyStandard2DMultisampleBlockShape;
            public uint residencyStandard3DBlockShape;
            public uint residencyAlignedMipSize;
            public uint residencyNonResidentStrict;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PhysicalDeviceProperties
        {
            public uint apiVersion;
            public uint driverVersion;
            public uint vendorID;
            public uint deviceID;
            public PhysicalDeviceType deviceType;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)23, SizeConst = (System.Int32)256, IidParameterIndex = (System.Int32)0)]
            public string deviceName;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)23, SizeConst = (System.Int32)16, IidParameterIndex = (System.Int32)0)]
            public string pipelineCacheUUID;
            public PhysicalDeviceLimits limits;
            public PhysicalDeviceSparseProperties sparseProperties;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct QueueFamilyProperties
        {
            public uint queueFlags;
            public uint queueCount;
            public uint timestampValidBits;
            public Extent3D minImageTransferGranularity;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MemoryType
        {
            public uint propertyFlags;
            public uint heapIndex;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MemoryHeap
        {
            public uint size;
            public uint flags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PhysicalDeviceMemoryProperties
        {
            public uint memoryTypeCount;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)27, SizeConst = (System.Int32)32, IidParameterIndex = (System.Int32)0)]
            public MemoryType[] memoryTypes;
            public uint memoryHeapCount;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)27, SizeConst = (System.Int32)16, IidParameterIndex = (System.Int32)0)]
            public MemoryHeap[] memoryHeaps;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DeviceQueueCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint queueFamilyIndex;
            public uint queueCount;
            public System.IntPtr pQueuePriorities;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DeviceCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint queueCreateInfoCount;
            public System.IntPtr pQueueCreateInfos;
            public uint enabledLayerCount;
            public System.IntPtr ppEnabledLayerNames;
            public uint enabledExtensionCount;
            public System.IntPtr ppEnabledExtensionNames;
            public System.IntPtr pEnabledFeatures;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ExtensionProperties
        {
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)23, SizeConst = (System.Int32)256, IidParameterIndex = (System.Int32)0)]
            public string extensionName;
            public uint specVersion;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct LayerProperties
        {
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)23, SizeConst = (System.Int32)256, IidParameterIndex = (System.Int32)0)]
            public string layerName;
            public uint specVersion;
            public uint implementationVersion;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)23, SizeConst = (System.Int32)256, IidParameterIndex = (System.Int32)0)]
            public string description;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SubmitInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint waitSemaphoreCount;
            public System.IntPtr pWaitSemaphores;
            public System.IntPtr pWaitDstStageMask;
            public uint commandBufferCount;
            public System.IntPtr pCommandBuffers;
            public uint signalSemaphoreCount;
            public System.IntPtr pSignalSemaphores;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MemoryAllocateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint allocationSize;
            public uint memoryTypeIndex;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MappedMemoryRange
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint memory;
            public uint offset;
            public uint size;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MemoryRequirements
        {
            public uint size;
            public uint alignment;
            public uint memoryTypeBits;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SparseImageFormatProperties
        {
            public uint aspectMask;
            public Extent3D imageGranularity;
            public uint flags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SparseImageMemoryRequirements
        {
            public SparseImageFormatProperties formatProperties;
            public uint imageMipTailFirstLod;
            public uint imageMipTailSize;
            public uint imageMipTailOffset;
            public uint imageMipTailStride;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SparseMemoryBind
        {
            public uint resourceOffset;
            public uint size;
            public uint memory;
            public uint memoryOffset;
            public uint flags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SparseBufferMemoryBindInfo
        {
            public uint buffer;
            public uint bindCount;
            public System.IntPtr pBinds;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SparseImageOpaqueMemoryBindInfo
        {
            public uint image;
            public uint bindCount;
            public System.IntPtr pBinds;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageSubresource
        {
            public uint aspectMask;
            public uint mipLevel;
            public uint arrayLayer;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct Offset3D
        {
            public int x;
            public int y;
            public int z;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SparseImageMemoryBind
        {
            public ImageSubresource subresource;
            public Offset3D offset;
            public Extent3D extent;
            public uint memory;
            public uint memoryOffset;
            public uint flags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SparseImageMemoryBindInfo
        {
            public uint image;
            public uint bindCount;
            public System.IntPtr pBinds;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct BindSparseInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint waitSemaphoreCount;
            public System.IntPtr pWaitSemaphores;
            public uint bufferBindCount;
            public System.IntPtr pBufferBinds;
            public uint imageOpaqueBindCount;
            public System.IntPtr pImageOpaqueBinds;
            public uint imageBindCount;
            public System.IntPtr pImageBinds;
            public uint signalSemaphoreCount;
            public System.IntPtr pSignalSemaphores;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct FenceCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SemaphoreCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct EventCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct QueryPoolCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public QueryType queryType;
            public uint queryCount;
            public uint pipelineStatistics;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct BufferCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint size;
            public uint usage;
            public SharingMode sharingMode;
            public uint queueFamilyIndexCount;
            public System.IntPtr pQueueFamilyIndices;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct BufferViewCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint buffer;
            public Format format;
            public uint offset;
            public uint range;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public ImageType imageType;
            public Format format;
            public Extent3D extent;
            public uint mipLevels;
            public uint arrayLayers;
            public SampleCountFlagBits samples;
            public ImageTiling tiling;
            public uint usage;
            public SharingMode sharingMode;
            public uint queueFamilyIndexCount;
            public System.IntPtr pQueueFamilyIndices;
            public ImageLayout initialLayout;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SubresourceLayout
        {
            public uint offset;
            public uint size;
            public uint rowPitch;
            public uint arrayPitch;
            public uint depthPitch;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ComponentMapping
        {
            public ComponentSwizzle r;
            public ComponentSwizzle g;
            public ComponentSwizzle b;
            public ComponentSwizzle a;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageSubresourceRange
        {
            public uint aspectMask;
            public uint baseMipLevel;
            public uint levelCount;
            public uint baseArrayLayer;
            public uint layerCount;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageViewCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint image;
            public ImageViewType viewType;
            public Format format;
            public ComponentMapping components;
            public ImageSubresourceRange subresourceRange;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ShaderModuleCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint codeSize;
            public System.IntPtr pCode;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineCacheCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint initialDataSize;
            public System.IntPtr pInitialData;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SpecializationMapEntry
        {
            public uint constantID;
            public uint offset;
            public uint size;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SpecializationInfo
        {
            public uint mapEntryCount;
            public System.IntPtr pMapEntries;
            public uint dataSize;
            public System.IntPtr pData;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineShaderStageCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public ShaderStageFlagBits stage;
            public uint module;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)20, SizeConst = (System.Int32)0, IidParameterIndex = (System.Int32)0)]
            public string pName;
            public System.IntPtr pSpecializationInfo;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct VertexInputBindingDescription
        {
            public uint binding;
            public uint stride;
            public VertexInputRate inputRate;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct VertexInputAttributeDescription
        {
            public uint location;
            public uint binding;
            public Format format;
            public uint offset;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineVertexInputStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint vertexBindingDescriptionCount;
            public System.IntPtr pVertexBindingDescriptions;
            public uint vertexAttributeDescriptionCount;
            public System.IntPtr pVertexAttributeDescriptions;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineInputAssemblyStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public PrimitiveTopology topology;
            public uint primitiveRestartEnable;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineTessellationStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint patchControlPoints;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct Viewport
        {
            public float x;
            public float y;
            public float width;
            public float height;
            public float minDepth;
            public float maxDepth;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct Offset2D
        {
            public int x;
            public int y;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct Extent2D
        {
            public uint width;
            public uint height;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct Rect2D
        {
            public Offset2D offset;
            public Extent2D extent;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineViewportStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint viewportCount;
            public System.IntPtr pViewports;
            public uint scissorCount;
            public System.IntPtr pScissors;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineRasterizationStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint depthClampEnable;
            public uint rasterizerDiscardEnable;
            public PolygonMode polygonMode;
            public uint cullMode;
            public FrontFace frontFace;
            public uint depthBiasEnable;
            public float depthBiasConstantFactor;
            public float depthBiasClamp;
            public float depthBiasSlopeFactor;
            public float lineWidth;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineMultisampleStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public SampleCountFlagBits rasterizationSamples;
            public uint sampleShadingEnable;
            public float minSampleShading;
            public System.IntPtr pSampleMask;
            public uint alphaToCoverageEnable;
            public uint alphaToOneEnable;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct StencilOpState
        {
            public StencilOp failOp;
            public StencilOp passOp;
            public StencilOp depthFailOp;
            public CompareOp compareOp;
            public uint compareMask;
            public uint writeMask;
            public uint reference;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineDepthStencilStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint depthTestEnable;
            public uint depthWriteEnable;
            public CompareOp depthCompareOp;
            public uint depthBoundsTestEnable;
            public uint stencilTestEnable;
            public StencilOpState front;
            public StencilOpState back;
            public float minDepthBounds;
            public float maxDepthBounds;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineColorBlendAttachmentState
        {
            public uint blendEnable;
            public BlendFactor srcColorBlendFactor;
            public BlendFactor dstColorBlendFactor;
            public BlendOp colorBlendOp;
            public BlendFactor srcAlphaBlendFactor;
            public BlendFactor dstAlphaBlendFactor;
            public BlendOp alphaBlendOp;
            public uint colorWriteMask;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineColorBlendStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint logicOpEnable;
            public LogicOp logicOp;
            public uint attachmentCount;
            public System.IntPtr pAttachments;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)11, SizeConst = (System.Int32)4, IidParameterIndex = (System.Int32)0)]
            public Single[] blendConstants;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineDynamicStateCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint dynamicStateCount;
            public System.IntPtr pDynamicStates;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct GraphicsPipelineCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint stageCount;
            public System.IntPtr pStages;
            public System.IntPtr pVertexInputState;
            public System.IntPtr pInputAssemblyState;
            public System.IntPtr pTessellationState;
            public System.IntPtr pViewportState;
            public System.IntPtr pRasterizationState;
            public System.IntPtr pMultisampleState;
            public System.IntPtr pDepthStencilState;
            public System.IntPtr pColorBlendState;
            public System.IntPtr pDynamicState;
            public uint layout;
            public uint renderPass;
            public uint subpass;
            public uint basePipelineHandle;
            public int basePipelineIndex;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ComputePipelineCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public PipelineShaderStageCreateInfo stage;
            public uint layout;
            public uint basePipelineHandle;
            public int basePipelineIndex;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PushConstantRange
        {
            public uint stageFlags;
            public uint offset;
            public uint size;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PipelineLayoutCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint setLayoutCount;
            public System.IntPtr pSetLayouts;
            public uint pushConstantRangeCount;
            public System.IntPtr pPushConstantRanges;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SamplerCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public Filter magFilter;
            public Filter minFilter;
            public SamplerMipmapMode mipmapMode;
            public SamplerAddressMode addressModeU;
            public SamplerAddressMode addressModeV;
            public SamplerAddressMode addressModeW;
            public float mipLodBias;
            public uint anisotropyEnable;
            public float maxAnisotropy;
            public uint compareEnable;
            public CompareOp compareOp;
            public float minLod;
            public float maxLod;
            public BorderColor borderColor;
            public uint unnormalizedCoordinates;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DescriptorSetLayoutBinding
        {
            public uint binding;
            public DescriptorType descriptorType;
            public uint descriptorCount;
            public uint stageFlags;
            public System.IntPtr pImmutableSamplers;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DescriptorSetLayoutCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint bindingCount;
            public System.IntPtr pBindings;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DescriptorPoolSize
        {
            public DescriptorType type;
            public uint descriptorCount;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DescriptorPoolCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint maxSets;
            public uint poolSizeCount;
            public System.IntPtr pPoolSizes;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DescriptorSetAllocateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint descriptorPool;
            public uint descriptorSetCount;
            public System.IntPtr pSetLayouts;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DescriptorImageInfo
        {
            public uint sampler;
            public uint imageView;
            public ImageLayout imageLayout;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DescriptorBufferInfo
        {
            public uint buffer;
            public uint offset;
            public uint range;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct WriteDescriptorSet
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint dstSet;
            public uint dstBinding;
            public uint dstArrayElement;
            public uint descriptorCount;
            public DescriptorType descriptorType;
            public System.IntPtr pImageInfo;
            public System.IntPtr pBufferInfo;
            public System.IntPtr pTexelBufferView;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct CopyDescriptorSet
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint srcSet;
            public uint srcBinding;
            public uint srcArrayElement;
            public uint dstSet;
            public uint dstBinding;
            public uint dstArrayElement;
            public uint descriptorCount;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct FramebufferCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint renderPass;
            public uint attachmentCount;
            public System.IntPtr pAttachments;
            public uint width;
            public uint height;
            public uint layers;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct AttachmentDescription
        {
            public uint flags;
            public Format format;
            public SampleCountFlagBits samples;
            public AttachmentLoadOp loadOp;
            public AttachmentStoreOp storeOp;
            public AttachmentLoadOp stencilLoadOp;
            public AttachmentStoreOp stencilStoreOp;
            public ImageLayout initialLayout;
            public ImageLayout finalLayout;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct AttachmentReference
        {
            public uint attachment;
            public ImageLayout layout;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SubpassDescription
        {
            public uint flags;
            public PipelineBindPoint pipelineBindPoint;
            public uint inputAttachmentCount;
            public System.IntPtr pInputAttachments;
            public uint colorAttachmentCount;
            public System.IntPtr pColorAttachments;
            public System.IntPtr pResolveAttachments;
            public System.IntPtr pDepthStencilAttachment;
            public uint preserveAttachmentCount;
            public System.IntPtr pPreserveAttachments;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SubpassDependency
        {
            public uint srcSubpass;
            public uint dstSubpass;
            public uint srcStageMask;
            public uint dstStageMask;
            public uint srcAccessMask;
            public uint dstAccessMask;
            public uint dependencyFlags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct RenderPassCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint attachmentCount;
            public System.IntPtr pAttachments;
            public uint subpassCount;
            public System.IntPtr pSubpasses;
            public uint dependencyCount;
            public System.IntPtr pDependencies;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct CommandPoolCreateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint queueFamilyIndex;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct CommandBufferAllocateInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint commandPool;
            public CommandBufferLevel level;
            public uint commandBufferCount;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct CommandBufferInheritanceInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint renderPass;
            public uint subpass;
            public uint framebuffer;
            public uint occlusionQueryEnable;
            public uint queryFlags;
            public uint pipelineStatistics;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct CommandBufferBeginInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public System.IntPtr pInheritanceInfo;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct BufferCopy
        {
            public uint srcOffset;
            public uint dstOffset;
            public uint size;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageSubresourceLayers
        {
            public uint aspectMask;
            public uint mipLevel;
            public uint baseArrayLayer;
            public uint layerCount;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageCopy
        {
            public ImageSubresourceLayers srcSubresource;
            public Offset3D srcOffset;
            public ImageSubresourceLayers dstSubresource;
            public Offset3D dstOffset;
            public Extent3D extent;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageBlit
        {
            public ImageSubresourceLayers srcSubresource;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)27, SizeConst = (System.Int32)2, IidParameterIndex = (System.Int32)0)]
            public Offset3D[] srcOffsets;
            public ImageSubresourceLayers dstSubresource;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)27, SizeConst = (System.Int32)2, IidParameterIndex = (System.Int32)0)]
            public Offset3D[] dstOffsets;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct BufferImageCopy
        {
            public uint bufferOffset;
            public uint bufferRowLength;
            public uint bufferImageHeight;
            public ImageSubresourceLayers imageSubresource;
            public Offset3D imageOffset;
            public Extent3D imageExtent;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public unsafe struct ClearColorValue
        {
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)11, SizeConst = (System.Int32)4, IidParameterIndex = (System.Int32)0)]
            [System.Runtime.InteropServices.FieldOffsetAttribute((System.Int32)0)]
            public fixed float float32[(Int32)4];
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)7, SizeConst = (System.Int32)4, IidParameterIndex = (System.Int32)0)]
            [System.Runtime.InteropServices.FieldOffsetAttribute((System.Int32)0)]
            public fixed int int32[(Int32)4];
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)30, ArraySubType = (System.Runtime.InteropServices.UnmanagedType)8, SizeConst = (System.Int32)4, IidParameterIndex = (System.Int32)0)]
            [System.Runtime.InteropServices.FieldOffsetAttribute((System.Int32)0)]
            public fixed uint uint32[(Int32)4];
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ClearDepthStencilValue
        {
            public float depth;
            public uint stencil;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public struct ClearValue
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute((System.Int32)0)]
            public ClearColorValue color;
            [System.Runtime.InteropServices.FieldOffsetAttribute((System.Int32)0)]
            public ClearDepthStencilValue depthStencil;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ClearAttachment
        {
            public uint aspectMask;
            public uint colorAttachment;
            public ClearValue clearValue;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ClearRect
        {
            public Rect2D rect;
            public uint baseArrayLayer;
            public uint layerCount;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageResolve
        {
            public ImageSubresourceLayers srcSubresource;
            public Offset3D srcOffset;
            public ImageSubresourceLayers dstSubresource;
            public Offset3D dstOffset;
            public Extent3D extent;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MemoryBarrier
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint srcAccessMask;
            public uint dstAccessMask;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct BufferMemoryBarrier
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint srcAccessMask;
            public uint dstAccessMask;
            public uint srcQueueFamilyIndex;
            public uint dstQueueFamilyIndex;
            public uint buffer;
            public uint offset;
            public uint size;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct ImageMemoryBarrier
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint srcAccessMask;
            public uint dstAccessMask;
            public ImageLayout oldLayout;
            public ImageLayout newLayout;
            public uint srcQueueFamilyIndex;
            public uint dstQueueFamilyIndex;
            public uint image;
            public ImageSubresourceRange subresourceRange;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct RenderPassBeginInfo
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint renderPass;
            public uint framebuffer;
            public Rect2D renderArea;
            public uint clearValueCount;
            public System.IntPtr pClearValues;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DispatchIndirectCommand
        {
            public uint x;
            public uint y;
            public uint z;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DrawIndexedIndirectCommand
        {
            public uint indexCount;
            public uint instanceCount;
            public uint firstIndex;
            public int vertexOffset;
            public uint firstInstance;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DrawIndirectCommand
        {
            public uint vertexCount;
            public uint instanceCount;
            public uint firstVertex;
            public uint firstInstance;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateInstance(ref InstanceCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref IntPtr pInstance);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyInstance(System.IntPtr instance, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkEnumeratePhysicalDevices(System.IntPtr instance, ref UInt32 pPhysicalDeviceCount, ref IntPtr pPhysicalDevices);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetPhysicalDeviceFeatures(System.IntPtr physicalDevice, ref PhysicalDeviceFeatures pFeatures);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetPhysicalDeviceFormatProperties(System.IntPtr physicalDevice, Format format, ref FormatProperties pFormatProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPhysicalDeviceImageFormatProperties(System.IntPtr physicalDevice, Format format, ImageType type, ImageTiling tiling, uint usage, uint flags, ref ImageFormatProperties pImageFormatProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetPhysicalDeviceProperties(System.IntPtr physicalDevice, ref PhysicalDeviceProperties pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetPhysicalDeviceQueueFamilyProperties(System.IntPtr physicalDevice, ref UInt32 pQueueFamilyPropertyCount, ref QueueFamilyProperties pQueueFamilyProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetPhysicalDeviceMemoryProperties(System.IntPtr physicalDevice, ref PhysicalDeviceMemoryProperties pMemoryProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate PFN_vkVoidFunction PFN_vkGetInstanceProcAddr(System.IntPtr instance, string pName);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate PFN_vkVoidFunction PFN_vkGetDeviceProcAddr(System.IntPtr device, string pName);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateDevice(System.IntPtr physicalDevice, ref DeviceCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref IntPtr pDevice);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyDevice(System.IntPtr device, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkEnumerateInstanceExtensionProperties(string pLayerName, ref UInt32 pPropertyCount, ref ExtensionProperties pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkEnumerateDeviceExtensionProperties(System.IntPtr physicalDevice, string pLayerName, ref UInt32 pPropertyCount, ref ExtensionProperties pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkEnumerateInstanceLayerProperties(ref UInt32 pPropertyCount, ref LayerProperties pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkEnumerateDeviceLayerProperties(System.IntPtr physicalDevice, ref UInt32 pPropertyCount, ref LayerProperties pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetDeviceQueue(System.IntPtr device, uint queueFamilyIndex, uint queueIndex, ref IntPtr pQueue);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkQueueSubmit(System.IntPtr queue, uint submitCount, ref SubmitInfo pSubmits, uint fence);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkQueueWaitIdle(System.IntPtr queue);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkDeviceWaitIdle(System.IntPtr device);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkAllocateMemory(System.IntPtr device, ref MemoryAllocateInfo pAllocateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pMemory);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkFreeMemory(System.IntPtr device, uint memory, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkMapMemory(System.IntPtr device, uint memory, uint offset, uint size, uint flags, ref IntPtr ppData);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkUnmapMemory(System.IntPtr device, uint memory);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkFlushMappedMemoryRanges(System.IntPtr device, uint memoryRangeCount, ref MappedMemoryRange pMemoryRanges);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkInvalidateMappedMemoryRanges(System.IntPtr device, uint memoryRangeCount, ref MappedMemoryRange pMemoryRanges);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetDeviceMemoryCommitment(System.IntPtr device, uint memory, ref UInt32 pCommittedMemoryInBytes);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkBindBufferMemory(System.IntPtr device, uint buffer, uint memory, uint memoryOffset);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkBindImageMemory(System.IntPtr device, uint image, uint memory, uint memoryOffset);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetBufferMemoryRequirements(System.IntPtr device, uint buffer, ref MemoryRequirements pMemoryRequirements);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetImageMemoryRequirements(System.IntPtr device, uint image, ref MemoryRequirements pMemoryRequirements);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetImageSparseMemoryRequirements(System.IntPtr device, uint image, ref UInt32 pSparseMemoryRequirementCount, ref SparseImageMemoryRequirements pSparseMemoryRequirements);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetPhysicalDeviceSparseImageFormatProperties(System.IntPtr physicalDevice, Format format, ImageType type, SampleCountFlagBits samples, uint usage, ImageTiling tiling, ref UInt32 pPropertyCount, ref SparseImageFormatProperties pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkQueueBindSparse(System.IntPtr queue, uint bindInfoCount, ref BindSparseInfo pBindInfo, uint fence);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateFence(System.IntPtr device, ref FenceCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pFence);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyFence(System.IntPtr device, uint fence, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkResetFences(System.IntPtr device, uint fenceCount, ref UInt32 pFences);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetFenceStatus(System.IntPtr device, uint fence);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkWaitForFences(System.IntPtr device, uint fenceCount, ref UInt32 pFences, uint waitAll, uint timeout);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateSemaphore(System.IntPtr device, ref SemaphoreCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pSemaphore);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroySemaphore(System.IntPtr device, uint semaphore, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateEvent(System.IntPtr device, ref EventCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pEvent);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyEvent(System.IntPtr device, uint @event, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetEventStatus(System.IntPtr device, uint @event);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkSetEvent(System.IntPtr device, uint @event);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkResetEvent(System.IntPtr device, uint @event);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateQueryPool(System.IntPtr device, ref QueryPoolCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pQueryPool);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyQueryPool(System.IntPtr device, uint queryPool, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetQueryPoolResults(System.IntPtr device, uint queryPool, uint firstQuery, uint queryCount, System.IntPtr dataSize, System.IntPtr pData, uint stride, uint flags);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateBuffer(System.IntPtr device, ref BufferCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pBuffer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyBuffer(System.IntPtr device, uint buffer, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateBufferView(System.IntPtr device, ref BufferViewCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pView);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyBufferView(System.IntPtr device, uint bufferView, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateImage(System.IntPtr device, ref ImageCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pImage);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyImage(System.IntPtr device, uint image, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetImageSubresourceLayout(System.IntPtr device, uint image, ref ImageSubresource pSubresource, ref SubresourceLayout pLayout);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateImageView(System.IntPtr device, ref ImageViewCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pView);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyImageView(System.IntPtr device, uint imageView, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateShaderModule(System.IntPtr device, ref ShaderModuleCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pShaderModule);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyShaderModule(System.IntPtr device, uint shaderModule, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreatePipelineCache(System.IntPtr device, ref PipelineCacheCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pPipelineCache);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyPipelineCache(System.IntPtr device, uint pipelineCache, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPipelineCacheData(System.IntPtr device, uint pipelineCache, ref UInt32 pDataSize, System.IntPtr pData);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkMergePipelineCaches(System.IntPtr device, uint dstCache, uint srcCacheCount, ref UInt32 pSrcCaches);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateGraphicsPipelines(System.IntPtr device, uint pipelineCache, uint createInfoCount, ref GraphicsPipelineCreateInfo pCreateInfos, ref AllocationCallbacks pAllocator, ref UInt32 pPipelines);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateComputePipelines(System.IntPtr device, uint pipelineCache, uint createInfoCount, ref ComputePipelineCreateInfo pCreateInfos, ref AllocationCallbacks pAllocator, ref UInt32 pPipelines);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyPipeline(System.IntPtr device, uint pipeline, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreatePipelineLayout(System.IntPtr device, ref PipelineLayoutCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pPipelineLayout);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyPipelineLayout(System.IntPtr device, uint pipelineLayout, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateSampler(System.IntPtr device, ref SamplerCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pSampler);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroySampler(System.IntPtr device, uint sampler, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateDescriptorSetLayout(System.IntPtr device, ref DescriptorSetLayoutCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pSetLayout);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyDescriptorSetLayout(System.IntPtr device, uint descriptorSetLayout, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateDescriptorPool(System.IntPtr device, ref DescriptorPoolCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pDescriptorPool);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyDescriptorPool(System.IntPtr device, uint descriptorPool, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkResetDescriptorPool(System.IntPtr device, uint descriptorPool, uint flags);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkAllocateDescriptorSets(System.IntPtr device, ref DescriptorSetAllocateInfo pAllocateInfo, ref UInt32 pDescriptorSets);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkFreeDescriptorSets(System.IntPtr device, uint descriptorPool, uint descriptorSetCount, ref UInt32 pDescriptorSets);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkUpdateDescriptorSets(System.IntPtr device, uint descriptorWriteCount, ref WriteDescriptorSet pDescriptorWrites, uint descriptorCopyCount, ref CopyDescriptorSet pDescriptorCopies);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateFramebuffer(System.IntPtr device, ref FramebufferCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pFramebuffer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyFramebuffer(System.IntPtr device, uint framebuffer, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateRenderPass(System.IntPtr device, ref RenderPassCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pRenderPass);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyRenderPass(System.IntPtr device, uint renderPass, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkGetRenderAreaGranularity(System.IntPtr device, uint renderPass, ref Extent2D pGranularity);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateCommandPool(System.IntPtr device, ref CommandPoolCreateInfo pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pCommandPool);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyCommandPool(System.IntPtr device, uint commandPool, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkResetCommandPool(System.IntPtr device, uint commandPool, uint flags);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkAllocateCommandBuffers(System.IntPtr device, ref CommandBufferAllocateInfo pAllocateInfo, ref IntPtr pCommandBuffers);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkFreeCommandBuffers(System.IntPtr device, uint commandPool, uint commandBufferCount, ref IntPtr pCommandBuffers);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkBeginCommandBuffer(System.IntPtr commandBuffer, ref CommandBufferBeginInfo pBeginInfo);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkEndCommandBuffer(System.IntPtr commandBuffer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkResetCommandBuffer(System.IntPtr commandBuffer, uint flags);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdBindPipeline(System.IntPtr commandBuffer, PipelineBindPoint pipelineBindPoint, uint pipeline);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetViewport(System.IntPtr commandBuffer, uint firstViewport, uint viewportCount, ref Viewport pViewports);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetScissor(System.IntPtr commandBuffer, uint firstScissor, uint scissorCount, ref Rect2D pScissors);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetLineWidth(System.IntPtr commandBuffer, float lineWidth);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetDepthBias(System.IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetBlendConstants(System.IntPtr commandBuffer, ref Single blendConstants);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetDepthBounds(System.IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetStencilCompareMask(System.IntPtr commandBuffer, uint faceMask, uint compareMask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetStencilWriteMask(System.IntPtr commandBuffer, uint faceMask, uint writeMask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetStencilReference(System.IntPtr commandBuffer, uint faceMask, uint reference);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdBindDescriptorSets(System.IntPtr commandBuffer, PipelineBindPoint pipelineBindPoint, uint layout, uint firstSet, uint descriptorSetCount, ref UInt32 pDescriptorSets, uint dynamicOffsetCount, ref UInt32 pDynamicOffsets);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdBindIndexBuffer(System.IntPtr commandBuffer, uint buffer, uint offset, IndexType indexType);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdBindVertexBuffers(System.IntPtr commandBuffer, uint firstBinding, uint bindingCount, ref UInt32 pBuffers, ref UInt32 pOffsets);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdDraw(System.IntPtr commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdDrawIndexed(System.IntPtr commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdDrawIndirect(System.IntPtr commandBuffer, uint buffer, uint offset, uint drawCount, uint stride);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdDrawIndexedIndirect(System.IntPtr commandBuffer, uint buffer, uint offset, uint drawCount, uint stride);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdDispatch(System.IntPtr commandBuffer, uint x, uint y, uint z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdDispatchIndirect(System.IntPtr commandBuffer, uint buffer, uint offset);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdCopyBuffer(System.IntPtr commandBuffer, uint srcBuffer, uint dstBuffer, uint regionCount, ref BufferCopy pRegions);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdCopyImage(System.IntPtr commandBuffer, uint srcImage, ImageLayout srcImageLayout, uint dstImage, ImageLayout dstImageLayout, uint regionCount, ref ImageCopy pRegions);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdBlitImage(System.IntPtr commandBuffer, uint srcImage, ImageLayout srcImageLayout, uint dstImage, ImageLayout dstImageLayout, uint regionCount, ref ImageBlit pRegions, Filter filter);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdCopyBufferToImage(System.IntPtr commandBuffer, uint srcBuffer, uint dstImage, ImageLayout dstImageLayout, uint regionCount, ref BufferImageCopy pRegions);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdCopyImageToBuffer(System.IntPtr commandBuffer, uint srcImage, ImageLayout srcImageLayout, uint dstBuffer, uint regionCount, ref BufferImageCopy pRegions);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdUpdateBuffer(System.IntPtr commandBuffer, uint dstBuffer, uint dstOffset, uint dataSize, ref UInt32 pData);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdFillBuffer(System.IntPtr commandBuffer, uint dstBuffer, uint dstOffset, uint size, uint data);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdClearColorImage(System.IntPtr commandBuffer, uint image, ImageLayout imageLayout, ref ClearColorValue pColor, uint rangeCount, ref ImageSubresourceRange pRanges);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdClearDepthStencilImage(System.IntPtr commandBuffer, uint image, ImageLayout imageLayout, ref ClearDepthStencilValue pDepthStencil, uint rangeCount, ref ImageSubresourceRange pRanges);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdClearAttachments(System.IntPtr commandBuffer, uint attachmentCount, ref ClearAttachment pAttachments, uint rectCount, ref ClearRect pRects);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdResolveImage(System.IntPtr commandBuffer, uint srcImage, ImageLayout srcImageLayout, uint dstImage, ImageLayout dstImageLayout, uint regionCount, ref ImageResolve pRegions);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdSetEvent(System.IntPtr commandBuffer, uint @event, uint stageMask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdResetEvent(System.IntPtr commandBuffer, uint @event, uint stageMask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdWaitEvents(System.IntPtr commandBuffer, uint eventCount, ref UInt32 pEvents, uint srcStageMask, uint dstStageMask, uint memoryBarrierCount, ref MemoryBarrier pMemoryBarriers, uint bufferMemoryBarrierCount, ref BufferMemoryBarrier pBufferMemoryBarriers, uint imageMemoryBarrierCount, ref ImageMemoryBarrier pImageMemoryBarriers);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdPipelineBarrier(System.IntPtr commandBuffer, uint srcStageMask, uint dstStageMask, uint dependencyFlags, uint memoryBarrierCount, ref MemoryBarrier pMemoryBarriers, uint bufferMemoryBarrierCount, ref BufferMemoryBarrier pBufferMemoryBarriers, uint imageMemoryBarrierCount, ref ImageMemoryBarrier pImageMemoryBarriers);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdBeginQuery(System.IntPtr commandBuffer, uint queryPool, uint query, uint flags);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdEndQuery(System.IntPtr commandBuffer, uint queryPool, uint query);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdResetQueryPool(System.IntPtr commandBuffer, uint queryPool, uint firstQuery, uint queryCount);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdWriteTimestamp(System.IntPtr commandBuffer, PipelineStageFlagBits pipelineStage, uint queryPool, uint query);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdCopyQueryPoolResults(System.IntPtr commandBuffer, uint queryPool, uint firstQuery, uint queryCount, uint dstBuffer, uint dstOffset, uint stride, uint flags);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdPushConstants(System.IntPtr commandBuffer, uint layout, uint stageFlags, uint offset, uint size, System.IntPtr pValues);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdBeginRenderPass(System.IntPtr commandBuffer, ref RenderPassBeginInfo pRenderPassBegin, SubpassContents contents);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdNextSubpass(System.IntPtr commandBuffer, SubpassContents contents);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdEndRenderPass(System.IntPtr commandBuffer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkCmdExecuteCommands(System.IntPtr commandBuffer, uint commandBufferCount, ref IntPtr pCommandBuffers);

        public enum ColorSpaceKHR
        {
            ColorspaceEndRange = 0,
            ColorspaceSRGBNonlinearKHR = 0,
            ColorspaceBeginRange = 0,
            ColorspaceMaxEnum = 2147483647,
            ColorspaceRangeSize = -1,
        }

        public enum PresentModeKHR
        {
            ModeImmediateKHR = 0,
            ModeBeginRange = 0,
            ModeMailboxKHR = 1,
            ModeFifoKHR = 2,
            ModeRangeSize = 2,
            ModeFifoRelaxedKHR = 3,
            ModeEndRange = 3,
            ModeMaxEnum = 2147483647,
        }

        public enum SurfaceTransformFlagBitsKHR
        {
            IdentityBitKHR = 1,
            Rotate90BitKHR = 2,
            Rotate180BitKHR = 4,
            Rotate270BitKHR = 8,
            HorizontalMirrorBitKHR = 16,
            HorizontalMirrorRotate90BitKHR = 32,
            HorizontalMirrorRotate180BitKHR = 64,
            HorizontalMirrorRotate270BitKHR = 128,
            InheritBitKHR = 256,
        }

        public enum CompositeAlphaFlagBitsKHR
        {
            OpaqueBitKHR = 1,
            PreMultipliedBitKHR = 2,
            PostMultipliedBitKHR = 4,
            InheritBitKHR = 8,
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SurfaceCapabilitiesKHR
        {
            public uint minImageCount;
            public uint maxImageCount;
            public Extent2D currentExtent;
            public Extent2D minImageExtent;
            public Extent2D maxImageExtent;
            public uint maxImageArrayLayers;
            public uint supportedTransforms;
            public SurfaceTransformFlagBitsKHR currentTransform;
            public uint supportedCompositeAlpha;
            public uint supportedUsageFlags;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SurfaceFormatKHR
        {
            public Format format;
            public ColorSpaceKHR colorSpace;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroySurfaceKHR(System.IntPtr instance, uint surface, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPhysicalDeviceSurfaceSupportKHR(System.IntPtr physicalDevice, uint queueFamilyIndex, uint surface, ref UInt32 pSupported);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPhysicalDeviceSurfaceCapabilitiesKHR(System.IntPtr physicalDevice, uint surface, ref SurfaceCapabilitiesKHR pSurfaceCapabilities);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(System.IntPtr physicalDevice, uint surface, ref UInt32 pSurfaceFormatCount, ref SurfaceFormatKHR pSurfaceFormats);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPhysicalDeviceSurfacePresentModesKHR(System.IntPtr physicalDevice, uint surface, ref UInt32 pPresentModeCount, ref PresentModeKHR pPresentModes);

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SwapchainCreateInfoKHR
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint surface;
            public uint minImageCount;
            public Format imageFormat;
            public ColorSpaceKHR imageColorSpace;
            public Extent2D imageExtent;
            public uint imageArrayLayers;
            public uint imageUsage;
            public SharingMode imageSharingMode;
            public uint queueFamilyIndexCount;
            public System.IntPtr pQueueFamilyIndices;
            public SurfaceTransformFlagBitsKHR preTransform;
            public CompositeAlphaFlagBitsKHR compositeAlpha;
            public PresentModeKHR presentMode;
            public uint clipped;
            public uint oldSwapchain;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PresentInfoKHR
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint waitSemaphoreCount;
            public System.IntPtr pWaitSemaphores;
            public uint swapchainCount;
            public System.IntPtr pSwapchains;
            public System.IntPtr pImageIndices;
            public System.IntPtr pResults;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateSwapchainKHR(System.IntPtr device, ref SwapchainCreateInfoKHR pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pSwapchain);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroySwapchainKHR(System.IntPtr device, uint swapchain, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetSwapchainImagesKHR(System.IntPtr device, uint swapchain, ref UInt32 pSwapchainImageCount, ref UInt32 pSwapchainImages);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkAcquireNextImageKHR(System.IntPtr device, uint swapchain, uint timeout, uint semaphore, uint fence, ref UInt32 pImageIndex);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkQueuePresentKHR(System.IntPtr queue, ref PresentInfoKHR pPresentInfo);

        public enum DisplayPlaneAlphaFlagBitsKHR
        {
            OpaqueBitKHR = 1,
            GlobalBitKHR = 2,
            PerPixelBitKHR = 4,
            PerPixelPremultipliedBitKHR = 8,
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplayPropertiesKHR
        {
            public uint display;
            [System.Runtime.InteropServices.MarshalAsAttribute((System.Runtime.InteropServices.UnmanagedType)20, SizeConst = (System.Int32)0, IidParameterIndex = (System.Int32)0)]
            public string displayName;
            public Extent2D physicalDimensions;
            public Extent2D physicalResolution;
            public uint supportedTransforms;
            public uint planeReorderPossible;
            public uint persistentContent;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplayModeParametersKHR
        {
            public Extent2D visibleRegion;
            public uint refreshRate;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplayModePropertiesKHR
        {
            public uint displayMode;
            public DisplayModeParametersKHR parameters;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplayModeCreateInfoKHR
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public DisplayModeParametersKHR parameters;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplayPlaneCapabilitiesKHR
        {
            public uint supportedAlpha;
            public Offset2D minSrcPosition;
            public Offset2D maxSrcPosition;
            public Extent2D minSrcExtent;
            public Extent2D maxSrcExtent;
            public Offset2D minDstPosition;
            public Offset2D maxDstPosition;
            public Extent2D minDstExtent;
            public Extent2D maxDstExtent;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplayPlanePropertiesKHR
        {
            public uint currentDisplay;
            public uint currentStackIndex;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplaySurfaceCreateInfoKHR
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public uint displayMode;
            public uint planeIndex;
            public uint planeStackIndex;
            public SurfaceTransformFlagBitsKHR transform;
            public float globalAlpha;
            public DisplayPlaneAlphaFlagBitsKHR alphaMode;
            public Extent2D imageExtent;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPhysicalDeviceDisplayPropertiesKHR(System.IntPtr physicalDevice, ref UInt32 pPropertyCount, ref DisplayPropertiesKHR pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetPhysicalDeviceDisplayPlanePropertiesKHR(System.IntPtr physicalDevice, ref UInt32 pPropertyCount, ref DisplayPlanePropertiesKHR pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetDisplayPlaneSupportedDisplaysKHR(System.IntPtr physicalDevice, uint planeIndex, ref UInt32 pDisplayCount, ref UInt32 pDisplays);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetDisplayModePropertiesKHR(System.IntPtr physicalDevice, uint display, ref UInt32 pPropertyCount, ref DisplayModePropertiesKHR pProperties);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateDisplayModeKHR(System.IntPtr physicalDevice, uint display, ref DisplayModeCreateInfoKHR pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pMode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkGetDisplayPlaneCapabilitiesKHR(System.IntPtr physicalDevice, uint mode, uint planeIndex, ref DisplayPlaneCapabilitiesKHR pCapabilities);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateDisplayPlaneSurfaceKHR(System.IntPtr instance, ref DisplaySurfaceCreateInfoKHR pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pSurface);

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DisplayPresentInfoKHR
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public Rect2D srcRect;
            public Rect2D dstRect;
            public uint persistent;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateSharedSwapchainsKHR(System.IntPtr device, uint swapchainCount, ref SwapchainCreateInfoKHR pCreateInfos, ref AllocationCallbacks pAllocator, ref UInt32 pSwapchains);

        public enum DebugReportObjectTypeEXT
        {
            TypeUnknownEXT = 0,
            TypeInstanceEXT = 1,
            TypePhysicalDeviceEXT = 2,
            TypeDeviceEXT = 3,
            TypeQueueEXT = 4,
            TypeSemaphoreEXT = 5,
            TypeCommandBufferEXT = 6,
            TypeFenceEXT = 7,
            TypeDeviceMemoryEXT = 8,
            TypeBufferEXT = 9,
            TypeImageEXT = 10,
            TypeEventEXT = 11,
            TypeQueryPoolEXT = 12,
            TypeBufferViewEXT = 13,
            TypeImageViewEXT = 14,
            TypeShaderModuleEXT = 15,
            TypePipelineCacheEXT = 16,
            TypePipelineLayoutEXT = 17,
            TypeRenderPassEXT = 18,
            TypePipelineEXT = 19,
            TypeDescriptorSetLayoutEXT = 20,
            TypeSamplerEXT = 21,
            TypeDescriptorPoolEXT = 22,
            TypeDescriptorSetEXT = 23,
            TypeFramebufferEXT = 24,
            TypeCommandPoolEXT = 25,
            TypeSurfaceKHR_EXT = 26,
            TypeSwapchainKHR_EXT = 27,
            TypeEXT = 28,
        }

        public enum DebugReportErrorEXT
        {
            ErrorNoneEXT = 0,
            ErrorCallbackRefEXT = 1,
        }

        public enum DebugReportFlagBitsEXT
        {
            InformationBitEXT = 1,
            WarningBitEXT = 2,
            PerformanceWarningBitEXT = 4,
            ErrorBitEXT = 8,
            BitEXT = 16,
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate uint PFN_vkDebugReportCallbackEXT(uint flags, DebugReportObjectTypeEXT objectType, uint @object, System.IntPtr location, int messageCode, string pLayerPrefix, string pMessage, System.IntPtr pUserData);

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct DebugReportCallbackCreateInfoEXT
        {
            public StructureType sType;
            public System.IntPtr pNext;
            public uint flags;
            public PFN_vkDebugReportCallbackEXT pfnCallback;
            public System.IntPtr pUserData;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate Result PFN_vkCreateDebugReportCallbackEXT(System.IntPtr instance, ref DebugReportCallbackCreateInfoEXT pCreateInfo, ref AllocationCallbacks pAllocator, ref UInt32 pCallback);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDestroyDebugReportCallbackEXT(System.IntPtr instance, uint callback, ref AllocationCallbacks pAllocator);

        [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute((System.Runtime.InteropServices.CallingConvention)3)]
        public delegate void PFN_vkDebugReportMessageEXT(System.IntPtr instance, uint flags, DebugReportObjectTypeEXT objectType, uint @object, System.IntPtr location, int messageCode, string pLayerPrefix, string pMessage);

    }
}