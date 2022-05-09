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
    public class NSXTALBOpenStackClusterSetupType 
    {
        /// <summary>
        /// admin_tenant of OpenStackClusterSetup.
        /// </summary>
        [JsonProperty(PropertyName = "admin_tenant")]
        public string? AdminTenant { get; set; }
        /// <summary>
        /// auth_url of OpenStackClusterSetup.
        /// </summary>
        [JsonProperty(PropertyName = "auth_url")]
        public string? AuthUrl { get; set; }
        /// <summary>
        /// cc_id of OpenStackClusterSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of OpenStackClusterSetup.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// keystone_host of OpenStackClusterSetup.
        /// </summary>
        [JsonProperty(PropertyName = "keystone_host")]
        [System.ComponentModel.DataAnnotations.Required]
        public string KeystoneHost { get; set; }
        /// <summary>
        /// Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        public string? Privilege { get; set; }
    }
}
