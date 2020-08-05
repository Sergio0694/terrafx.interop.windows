// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("14056589-E16C-11D2-BB90-00C04F8EE6C0")]
    [NativeTypeName("struct ISpObjectToken : ISpDataKey")]
    public unsafe partial struct ISpObjectToken
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpObjectToken*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpObjectToken*, uint>)(lpVtbl[1]))((ISpObjectToken*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpObjectToken*, uint>)(lpVtbl[2]))((ISpObjectToken*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pData)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, uint, int>)(lpVtbl[7]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, uint*, int>)(lpVtbl[8]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, int>)(lpVtbl[11]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, int>)(lpVtbl[12]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszValueName);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
        {
            return ((delegate* stdcall<ISpObjectToken*, uint, ushort**, int>)(lpVtbl[13]))((ISpObjectToken*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
        {
            return ((delegate* stdcall<ISpObjectToken*, uint, ushort**, int>)(lpVtbl[14]))((ISpObjectToken*)Unsafe.AsPointer(ref this), Index, ppszValueName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("LPCWSTR")] ushort* pszTokenId, [NativeTypeName("BOOL")] int fCreateIfNotExist)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, ushort*, int, int>)(lpVtbl[15]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszCategoryId, pszTokenId, fCreateIfNotExist);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort**, int>)(lpVtbl[16]))((ISpObjectToken*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCategory([NativeTypeName("ISpObjectTokenCategory **")] ISpObjectTokenCategory** ppTokenCategory)
        {
            return ((delegate* stdcall<ISpObjectToken*, ISpObjectTokenCategory**, int>)(lpVtbl[17]))((ISpObjectToken*)Unsafe.AsPointer(ref this), ppTokenCategory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpObjectToken*, IUnknown*, uint, Guid*, void**, int>)(lpVtbl[18]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pUnkOuter, dwClsContext, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszFileNameSpecifier, [NativeTypeName("ULONG")] uint nFolder, [NativeTypeName("LPWSTR *")] ushort** ppszFilePath)
        {
            return ((delegate* stdcall<ISpObjectToken*, Guid*, ushort*, ushort*, uint, ushort**, int>)(lpVtbl[19]))((ISpObjectToken*)Unsafe.AsPointer(ref this), clsidCaller, pszValueName, pszFileNameSpecifier, nFolder, ppszFilePath);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszKeyName, [NativeTypeName("BOOL")] int fDeleteFile)
        {
            return ((delegate* stdcall<ISpObjectToken*, Guid*, ushort*, int, int>)(lpVtbl[20]))((ISpObjectToken*)Unsafe.AsPointer(ref this), clsidCaller, pszKeyName, fDeleteFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int Remove([NativeTypeName("const CLSID *")] Guid* pclsidCaller)
        {
            return ((delegate* stdcall<ISpObjectToken*, Guid*, int>)(lpVtbl[21]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pclsidCaller);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, [NativeTypeName("void *")] void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, [NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("BOOL *")] int* pfSupported)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, void*, uint, IUnknown*, int*, int>)(lpVtbl[22]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, punkObject, pfSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, [NativeTypeName("void *")] void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, [NativeTypeName("IUnknown *")] IUnknown* punkObject)
        {
            return ((delegate* stdcall<ISpObjectToken*, IntPtr, ushort*, ushort*, void*, uint, IUnknown*, int>)(lpVtbl[23]))((ISpObjectToken*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData, punkObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesAttributes([NativeTypeName("LPCWSTR")] ushort* pszAttributes, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return ((delegate* stdcall<ISpObjectToken*, ushort*, int*, int>)(lpVtbl[24]))((ISpObjectToken*)Unsafe.AsPointer(ref this), pszAttributes, pfMatches);
        }
    }
}
