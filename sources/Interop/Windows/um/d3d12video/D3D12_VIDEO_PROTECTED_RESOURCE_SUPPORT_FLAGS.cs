// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS
    {
        D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_NONE = 0,
        D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_SUPPORTED = 0x1,
    }
}
