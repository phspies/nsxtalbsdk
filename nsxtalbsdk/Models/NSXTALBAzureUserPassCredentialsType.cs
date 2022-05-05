using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAzureUserPassCredentialsType 
    {
        /// <summary>
        /// Password for Azure subscription. Required only if username is provided. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Tenant or the active directory associated with the subscription. Required for user name password authentication. Field
        /// introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_name")]
        public string? TenantName { get; set; }
        /// <summary>
        /// Username for Azure subscription. Required only for username password based authentication. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
