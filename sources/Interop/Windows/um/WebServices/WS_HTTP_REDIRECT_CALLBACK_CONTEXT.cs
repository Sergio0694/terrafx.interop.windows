// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_HTTP_REDIRECT_CALLBACK_CONTEXT
    {
        [NativeTypeName("WS_HTTP_REDIRECT_CALLBACK")]
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, int> callback;

        [NativeTypeName("void *")]
        public void* state;
    }
}
