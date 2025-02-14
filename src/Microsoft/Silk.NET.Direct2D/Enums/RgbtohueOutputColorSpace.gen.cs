// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE")]
    public enum RgbtohueOutputColorSpace : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"HueSaturationValue\"")]
        [NativeName("Name", "D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_HUE_SATURATION_VALUE")]
        RgbtohueOutputColorSpaceHueSaturationValue = 0x0,
        [Obsolete("Deprecated in favour of \"HueSaturationLightness\"")]
        [NativeName("Name", "D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_HUE_SATURATION_LIGHTNESS")]
        RgbtohueOutputColorSpaceHueSaturationLightness = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_FORCE_DWORD")]
        RgbtohueOutputColorSpaceForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_HUE_SATURATION_VALUE")]
        HueSaturationValue = 0x0,
        [NativeName("Name", "D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_HUE_SATURATION_LIGHTNESS")]
        HueSaturationLightness = 0x1,
        [NativeName("Name", "D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
