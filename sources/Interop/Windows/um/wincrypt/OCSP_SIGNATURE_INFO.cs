// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct OCSP_SIGNATURE_INFO
    {
        public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

        public CRYPT_BIT_BLOB Signature;

        [NativeTypeName("DWORD")]
        public uint cCertEncoded;

        [NativeTypeName("PCERT_BLOB")]
        public CRYPTOAPI_BLOB* rgCertEncoded;
    }
}
