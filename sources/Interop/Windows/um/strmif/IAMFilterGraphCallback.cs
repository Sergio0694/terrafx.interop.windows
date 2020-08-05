// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IAMFilterGraphCallback : IUnknown")]
    public unsafe partial struct IAMFilterGraphCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMFilterGraphCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMFilterGraphCallback*, uint>)(lpVtbl[1]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMFilterGraphCallback*, uint>)(lpVtbl[2]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UnableToRender([NativeTypeName("IPin *")] IPin* pPin)
        {
            return ((delegate* stdcall<IAMFilterGraphCallback*, IPin*, int>)(lpVtbl[3]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this), pPin);
        }
    }
}
