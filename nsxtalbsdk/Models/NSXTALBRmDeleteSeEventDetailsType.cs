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
    public class NSXTALBRmDeleteSeEventDetailsType 
    {
        /// <summary>
        /// cloud_name of RmDeleteSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// host_name of RmDeleteSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public string? HostName { get; set; }
        /// <summary>
        /// Unique object identifier of host.
        /// </summary>
        [JsonProperty(PropertyName = "host_uuid")]
        public string? HostUuid { get; set; }
        /// <summary>
        /// reason of RmDeleteSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_cookie of RmDeleteSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_cookie")]
        public string? SeCookie { get; set; }
        /// <summary>
        /// se_grp_name of RmDeleteSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_name")]
        public string? SeGrpName { get; set; }
        /// <summary>
        /// Unique object identifier of se_grp.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_uuid")]
        public string? SeGrpUuid { get; set; }
        /// <summary>
        /// se_name of RmDeleteSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// Number of status_code.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public long? StatusCode { get; set; }
    }
}
