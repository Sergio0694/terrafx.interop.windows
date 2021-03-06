// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_LOGOTYPE_IMAGE
    {
        public CERT_LOGOTYPE_DETAILS LogotypeDetails;

        [NativeTypeName("PCERT_LOGOTYPE_IMAGE_INFO")]
        public CERT_LOGOTYPE_IMAGE_INFO* pLogotypeImageInfo;
    }
}
