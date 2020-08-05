// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70423839-6ACC-4B23-B079-21DBF08156A5")]
    [NativeTypeName("struct IEncoderAPI : IUnknown")]
    public unsafe partial struct IEncoderAPI
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, void**, int>)(lpVtbl[0]))((IEncoderAPI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEncoderAPI*, uint>)(lpVtbl[1]))((IEncoderAPI*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEncoderAPI*, uint>)(lpVtbl[2]))((IEncoderAPI*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSupported([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, int>)(lpVtbl[3]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsAvailable([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, int>)(lpVtbl[4]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* ValueMin, [NativeTypeName("VARIANT *")] VARIANT* ValueMax, [NativeTypeName("VARIANT *")] VARIANT* SteppingDelta)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT **")] VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[7]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[8]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* stdcall<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[9]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }
    }
}
