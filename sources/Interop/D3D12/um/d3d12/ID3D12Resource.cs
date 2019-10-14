// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("696442BE-A72E-4059-BC79-5B5C98040FAD")]
    public unsafe partial struct ID3D12Resource
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Resource* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Resource* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Resource* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12Resource* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12Resource* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12Resource* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12Resource* pThis, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12Resource* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Map(ID3D12Resource* pThis, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pReadRange, [NativeTypeName("void **")] void** ppData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Unmap(ID3D12Resource* pThis, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_RESOURCE_DESC* _GetDesc(ID3D12Resource* pThis, D3D12_RESOURCE_DESC* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public delegate ulong _GetGPUVirtualAddress(ID3D12Resource* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteToSubresource(ID3D12Resource* pThis, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadFromSubresource(ID3D12Resource* pThis, [NativeTypeName("void *")] void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHeapProperties(ID3D12Resource* pThis, [NativeTypeName("D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, [NativeTypeName("D3D12_HEAP_FLAGS *")] D3D12_HEAP_FLAGS* pHeapFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12Resource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12Resource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12Resource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ID3D12Resource*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D12Resource*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pReadRange, [NativeTypeName("void **")] void** ppData)
        {
            return Marshal.GetDelegateForFunctionPointer<_Map>(lpVtbl->Map)((ID3D12Resource*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
        }

        public void Unmap([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange)
        {
            Marshal.GetDelegateForFunctionPointer<_Unmap>(lpVtbl->Unmap)((ID3D12Resource*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
        }

        public D3D12_RESOURCE_DESC GetDesc()
        {
            D3D12_RESOURCE_DESC result;
            return *Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D12Resource*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong GetGPUVirtualAddress()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGPUVirtualAddress>(lpVtbl->GetGPUVirtualAddress)((ID3D12Resource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteToSubresource([NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteToSubresource>(lpVtbl->WriteToSubresource)((ID3D12Resource*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFromSubresource([NativeTypeName("void *")] void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReadFromSubresource>(lpVtbl->ReadFromSubresource)((ID3D12Resource*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeapProperties([NativeTypeName("D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, [NativeTypeName("D3D12_HEAP_FLAGS *")] D3D12_HEAP_FLAGS* pHeapFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHeapProperties>(lpVtbl->GetHeapProperties)((ID3D12Resource*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (UINT, const D3D12_RANGE *, void **) __attribute__((stdcall))")]
            public IntPtr Map;

            [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
            public IntPtr Unmap;

            [NativeTypeName("D3D12_RESOURCE_DESC () __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS () __attribute__((stdcall))")]
            public IntPtr GetGPUVirtualAddress;

            [NativeTypeName("HRESULT (UINT, const D3D12_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr WriteToSubresource;

            [NativeTypeName("HRESULT (void *, UINT, UINT, UINT, const D3D12_BOX *) __attribute__((stdcall))")]
            public IntPtr ReadFromSubresource;

            [NativeTypeName("HRESULT (D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS *) __attribute__((stdcall))")]
            public IntPtr GetHeapProperties;
        }
    }
}
