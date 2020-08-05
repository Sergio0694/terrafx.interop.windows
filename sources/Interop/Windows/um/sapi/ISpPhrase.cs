// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1A5C0354-B621-4B5A-8791-D306ED379E53")]
    [NativeTypeName("struct ISpPhrase : IUnknown")]
    public unsafe partial struct ISpPhrase
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpPhrase*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhrase*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpPhrase*, uint>)(lpVtbl[1]))((ISpPhrase*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpPhrase*, uint>)(lpVtbl[2]))((ISpPhrase*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPhrase([NativeTypeName("SPPHRASE **")] SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* stdcall<ISpPhrase*, SPPHRASE**, int>)(lpVtbl[3]))((ISpPhrase*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSerializedPhrase([NativeTypeName("SPSERIALIZEDPHRASE **")] SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* stdcall<ISpPhrase*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpPhrase*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("BOOL")] int fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, [NativeTypeName("BYTE *")] byte* pbDisplayAttributes)
        {
            return ((delegate* stdcall<ISpPhrase*, uint, uint, int, ushort**, byte*, int>)(lpVtbl[5]))((ISpPhrase*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* stdcall<ISpPhrase*, uint, int>)(lpVtbl[6]))((ISpPhrase*)Unsafe.AsPointer(ref this), dwValueTypes);
        }
    }
}
