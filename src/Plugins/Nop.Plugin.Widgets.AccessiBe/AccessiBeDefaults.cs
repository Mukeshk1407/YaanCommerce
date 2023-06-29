﻿using Nop.Core;

namespace Nop.Plugin.Widgets.AccessiBe
{
    /// <summary>
    /// Represents plugin default vaues and constants
    /// </summary>
    public class AccessiBeDefaults
    {
        /// <summary>
        /// Gets the plugin system name
        /// </summary>
        public static string SystemName => "Widgets.AccessiBe";

        /// <summary>
        /// Gets the user agent used to request third-party services
        /// </summary>
        public static string UserAgent => $"yaancommerce-{NopVersion.CURRENT_VERSION}";

        /// <summary>
        /// Gets the configuration route name
        /// </summary>
        public static string ConfigurationRouteName => "Plugin.Widgets.AccessiBe.Configure";
    }
}