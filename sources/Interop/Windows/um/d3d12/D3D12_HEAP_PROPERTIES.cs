// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_HEAP_PROPERTIES
    {
        public D3D12_HEAP_TYPE Type;

        public D3D12_CPU_PAGE_PROPERTY CPUPageProperty;

        public D3D12_MEMORY_POOL MemoryPoolPreference;

        [NativeTypeName("UINT")]
        public uint CreationNodeMask;

        [NativeTypeName("UINT")]
        public uint VisibleNodeMask;
    }
}
