// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum OLEMISC
    {
        OLEMISC_RECOMPOSEONRESIZE = 0x1,
        OLEMISC_ONLYICONIC = 0x2,
        OLEMISC_INSERTNOTREPLACE = 0x4,
        OLEMISC_STATIC = 0x8,
        OLEMISC_CANTLINKINSIDE = 0x10,
        OLEMISC_CANLINKBYOLE1 = 0x20,
        OLEMISC_ISLINKOBJECT = 0x40,
        OLEMISC_INSIDEOUT = 0x80,
        OLEMISC_ACTIVATEWHENVISIBLE = 0x100,
        OLEMISC_RENDERINGISDEVICEINDEPENDENT = 0x200,
        OLEMISC_INVISIBLEATRUNTIME = 0x400,
        OLEMISC_ALWAYSRUN = 0x800,
        OLEMISC_ACTSLIKEBUTTON = 0x1000,
        OLEMISC_ACTSLIKELABEL = 0x2000,
        OLEMISC_NOUIACTIVATE = 0x4000,
        OLEMISC_ALIGNABLE = 0x8000,
        OLEMISC_SIMPLEFRAME = 0x10000,
        OLEMISC_SETCLIENTSITEFIRST = 0x20000,
        OLEMISC_IMEMODE = 0x40000,
        OLEMISC_IGNOREACTIVATEWHENVISIBLE = 0x80000,
        OLEMISC_WANTSTOMENUMERGE = 0x100000,
        OLEMISC_SUPPORTSMULTILEVELUNDO = 0x200000,
    }
}
