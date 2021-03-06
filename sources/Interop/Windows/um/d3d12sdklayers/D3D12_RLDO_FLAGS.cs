// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_RLDO_FLAGS
    {
        D3D12_RLDO_NONE = 0,
        D3D12_RLDO_SUMMARY = 0x1,
        D3D12_RLDO_DETAIL = 0x2,
        D3D12_RLDO_IGNORE_INTERNAL = 0x4,
    }
}
