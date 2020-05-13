// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct QUOTA_LIMITS
    {
        [NativeTypeName("SIZE_T")]
        public UIntPtr PagedPoolLimit;

        [NativeTypeName("SIZE_T")]
        public UIntPtr NonPagedPoolLimit;

        [NativeTypeName("SIZE_T")]
        public UIntPtr MinimumWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public UIntPtr MaximumWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public UIntPtr PagefileLimit;

        public LARGE_INTEGER TimeLimit;
    }
}