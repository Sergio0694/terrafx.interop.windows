// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5D1ABFD6-450A-4D92-9EFC-D6B6CBC1F4DA")]
    [NativeTypeName("struct IMFMediaSourceExtensionLiveSeekableRange : IUnknown")]
    public unsafe partial struct IMFMediaSourceExtensionLiveSeekableRange
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionLiveSeekableRange*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionLiveSeekableRange*, uint>)(lpVtbl[1]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionLiveSeekableRange*, uint>)(lpVtbl[2]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLiveSeekableRange(double start, double end)
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionLiveSeekableRange*, double, double, int>)(lpVtbl[3]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this), start, end);
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearLiveSeekableRange()
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionLiveSeekableRange*, int>)(lpVtbl[4]))((IMFMediaSourceExtensionLiveSeekableRange*)Unsafe.AsPointer(ref this));
        }
    }
}
