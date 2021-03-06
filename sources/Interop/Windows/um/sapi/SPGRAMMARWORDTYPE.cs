// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPGRAMMARWORDTYPE
    {
        SPWT_DISPLAY = 0,
        SPWT_LEXICAL = (SPWT_DISPLAY + 1),
        SPWT_PRONUNCIATION = (SPWT_LEXICAL + 1),
        SPWT_LEXICAL_NO_SPECIAL_CHARS = (SPWT_PRONUNCIATION + 1),
    }
}
