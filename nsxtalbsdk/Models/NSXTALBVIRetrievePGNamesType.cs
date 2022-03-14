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
    public class NSXTALBVIRetrievePGNamesType 
    {
        public NSXTALBVIRetrievePGNamesType()
        {
        }
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// datacenter of VIRetrievePGNames.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter")]
        public string? Datacenter { get; set; }
        /// <summary>
        /// password of VIRetrievePGNames.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// username of VIRetrievePGNames.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// vcenter_url of VIRetrievePGNames.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url")]
        public string? VcenterUrl { get; set; }
    }
}
