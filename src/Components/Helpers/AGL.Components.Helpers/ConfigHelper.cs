using System;
using System.Configuration;

namespace AGL.Components.Helpers
{
    public static class ConfigHelper
    {
        /// <summary>
        /// Gets appSettings configuration value for specified key.
        /// Throws a specific ConfigurationErrorsException which includes the key
        /// that was missing in the configuration file.
        /// </summary>
        /// <typeparam name="T">Generic T</typeparam>
        /// <param name="key">Key for config value</param>
        /// <returns>The configuration value for the specified key</returns>
        public static T GetValue<T>(string key)
        {
            if (ConfigurationManager.AppSettings[key] == null)
            {
                throw new ConfigurationErrorsException(
                    string.Format("AppSettings Configuration value missing for key '{0}'.", key));
            }

            // deal with special case type - eg. bool
            if (typeof(T) == typeof(bool))
                return (T)((object)ConfigurationManager.AppSettings[key].Equals("true", StringComparison.OrdinalIgnoreCase));

            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));

        }

    }
}
