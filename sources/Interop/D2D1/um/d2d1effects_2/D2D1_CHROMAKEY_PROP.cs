// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_CHROMAKEY_PROP : uint
    {
        D2D1_CHROMAKEY_PROP_COLOR = 0,
        D2D1_CHROMAKEY_PROP_TOLERANCE = 1,
        D2D1_CHROMAKEY_PROP_INVERT_ALPHA = 2,
        D2D1_CHROMAKEY_PROP_FEATHER = 3,
        D2D1_CHROMAKEY_PROP_FORCE_DWORD = 0xFFFFFFFF,
    }
}