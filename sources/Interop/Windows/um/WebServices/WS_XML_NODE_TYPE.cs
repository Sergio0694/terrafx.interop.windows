// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WS_XML_NODE_TYPE
    {
        WS_XML_NODE_TYPE_ELEMENT = 1,
        WS_XML_NODE_TYPE_TEXT = 2,
        WS_XML_NODE_TYPE_END_ELEMENT = 3,
        WS_XML_NODE_TYPE_COMMENT = 4,
        WS_XML_NODE_TYPE_CDATA = 6,
        WS_XML_NODE_TYPE_END_CDATA = 7,
        WS_XML_NODE_TYPE_EOF = 8,
        WS_XML_NODE_TYPE_BOF = 9,
    }
}
