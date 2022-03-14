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
    public class NSXTALBIpamDnsOpenstackProfileType 
    {
        /// <summary>
        /// Keystone's hostname or IP address.
        /// </summary>
        [JsonProperty(PropertyName = "keystone_host")]
        public string? KeystoneHost { get; set; }
        /// <summary>
        /// The password Avi Vantage will use when authenticating to Keystone.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Region name.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// OpenStack tenant name.
        /// </summary>
        [JsonProperty(PropertyName = "tenant")]
        public string? Tenant { get; set; }
        /// <summary>
        /// The username Avi Vantage will use when authenticating to Keystone.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Network to be used for VIP allocation.
        /// </summary>
        [JsonProperty(PropertyName = "vip_network_name")]
        public string? VipNetworkName { get; set; }
    }
}
