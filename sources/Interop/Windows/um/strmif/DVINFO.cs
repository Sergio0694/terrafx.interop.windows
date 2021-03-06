// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DVINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwDVAAuxSrc;

        [NativeTypeName("DWORD")]
        public uint dwDVAAuxCtl;

        [NativeTypeName("DWORD")]
        public uint dwDVAAuxSrc1;

        [NativeTypeName("DWORD")]
        public uint dwDVAAuxCtl1;

        [NativeTypeName("DWORD")]
        public uint dwDVVAuxSrc;

        [NativeTypeName("DWORD")]
        public uint dwDVVAuxCtl;

        [NativeTypeName("DWORD [2]")]
        public fixed uint dwDVReserved[2];
    }
}
