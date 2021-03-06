// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum INTERNETFEATURELIST
    {
        FEATURE_OBJECT_CACHING = 0,
        FEATURE_ZONE_ELEVATION = (FEATURE_OBJECT_CACHING + 1),
        FEATURE_MIME_HANDLING = (FEATURE_ZONE_ELEVATION + 1),
        FEATURE_MIME_SNIFFING = (FEATURE_MIME_HANDLING + 1),
        FEATURE_WINDOW_RESTRICTIONS = (FEATURE_MIME_SNIFFING + 1),
        FEATURE_WEBOC_POPUPMANAGEMENT = (FEATURE_WINDOW_RESTRICTIONS + 1),
        FEATURE_BEHAVIORS = (FEATURE_WEBOC_POPUPMANAGEMENT + 1),
        FEATURE_DISABLE_MK_PROTOCOL = (FEATURE_BEHAVIORS + 1),
        FEATURE_LOCALMACHINE_LOCKDOWN = (FEATURE_DISABLE_MK_PROTOCOL + 1),
        FEATURE_SECURITYBAND = (FEATURE_LOCALMACHINE_LOCKDOWN + 1),
        FEATURE_RESTRICT_ACTIVEXINSTALL = (FEATURE_SECURITYBAND + 1),
        FEATURE_VALIDATE_NAVIGATE_URL = (FEATURE_RESTRICT_ACTIVEXINSTALL + 1),
        FEATURE_RESTRICT_FILEDOWNLOAD = (FEATURE_VALIDATE_NAVIGATE_URL + 1),
        FEATURE_ADDON_MANAGEMENT = (FEATURE_RESTRICT_FILEDOWNLOAD + 1),
        FEATURE_PROTOCOL_LOCKDOWN = (FEATURE_ADDON_MANAGEMENT + 1),
        FEATURE_HTTP_USERNAME_PASSWORD_DISABLE = (FEATURE_PROTOCOL_LOCKDOWN + 1),
        FEATURE_SAFE_BINDTOOBJECT = (FEATURE_HTTP_USERNAME_PASSWORD_DISABLE + 1),
        FEATURE_UNC_SAVEDFILECHECK = (FEATURE_SAFE_BINDTOOBJECT + 1),
        FEATURE_GET_URL_DOM_FILEPATH_UNENCODED = (FEATURE_UNC_SAVEDFILECHECK + 1),
        FEATURE_TABBED_BROWSING = (FEATURE_GET_URL_DOM_FILEPATH_UNENCODED + 1),
        FEATURE_SSLUX = (FEATURE_TABBED_BROWSING + 1),
        FEATURE_DISABLE_NAVIGATION_SOUNDS = (FEATURE_SSLUX + 1),
        FEATURE_DISABLE_LEGACY_COMPRESSION = (FEATURE_DISABLE_NAVIGATION_SOUNDS + 1),
        FEATURE_FORCE_ADDR_AND_STATUS = (FEATURE_DISABLE_LEGACY_COMPRESSION + 1),
        FEATURE_XMLHTTP = (FEATURE_FORCE_ADDR_AND_STATUS + 1),
        FEATURE_DISABLE_TELNET_PROTOCOL = (FEATURE_XMLHTTP + 1),
        FEATURE_FEEDS = (FEATURE_DISABLE_TELNET_PROTOCOL + 1),
        FEATURE_BLOCK_INPUT_PROMPTS = (FEATURE_FEEDS + 1),
        FEATURE_ENTRY_COUNT = (FEATURE_BLOCK_INPUT_PROMPTS + 1),
    }
}
