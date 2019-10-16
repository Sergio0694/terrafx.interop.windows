// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct METAHEADER
    {
        [NativeTypeName("WORD")]
        public ushort mtType;

        [NativeTypeName("WORD")]
        public ushort mtHeaderSize;

        [NativeTypeName("WORD")]
        public ushort mtVersion;

        [NativeTypeName("DWORD")]
        public uint mtSize;

        [NativeTypeName("WORD")]
        public ushort mtNoObjects;

        [NativeTypeName("DWORD")]
        public uint mtMaxRecord;

        [NativeTypeName("WORD")]
        public ushort mtNoParameters;
    }
}