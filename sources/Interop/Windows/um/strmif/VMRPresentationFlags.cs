// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VMRPresentationFlags
    {
        VMRSample_SyncPoint = 0x1,
        VMRSample_Preroll = 0x2,
        VMRSample_Discontinuity = 0x4,
        VMRSample_TimeValid = 0x8,
        VMRSample_SrcDstRectsValid = 0x10,
    }
}
