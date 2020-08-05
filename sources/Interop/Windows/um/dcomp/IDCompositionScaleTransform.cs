// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71FDE914-40EF-45EF-BD51-68B037C339F9")]
    [NativeTypeName("struct IDCompositionScaleTransform : IDCompositionTransform")]
    public unsafe partial struct IDCompositionScaleTransform
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, uint>)(lpVtbl[1]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, uint>)(lpVtbl[2]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScaleX(float scaleX)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, float, int>)(lpVtbl[3]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScaleX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScaleY(float scaleY)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, float, int>)(lpVtbl[5]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetScaleY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, float, int>)(lpVtbl[7]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, float, int>)(lpVtbl[9]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
