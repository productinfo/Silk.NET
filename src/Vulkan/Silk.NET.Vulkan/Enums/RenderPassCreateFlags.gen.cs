// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkRenderPassCreateFlags")]
    public enum RenderPassCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Reserved0BitKhr\"")]
        [NativeName("Name", "VK_RENDER_PASS_CREATE_RESERVED_0_BIT_KHR")]
        RenderPassCreateReserved0BitKhr = 1,
        [Obsolete("Deprecated in favour of \"TransformBitQCom\"")]
        [NativeName("Name", "VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM")]
        RenderPassCreateTransformBitQCom = 2,
        [NativeName("Name", "VK_RENDER_PASS_CREATE_RESERVED_0_BIT_KHR")]
        Reserved0BitKhr = 1,
        [NativeName("Name", "VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM")]
        TransformBitQCom = 2,
    }
}
