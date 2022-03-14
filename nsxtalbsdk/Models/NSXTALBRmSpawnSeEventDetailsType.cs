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
    public class NSXTALBRmSpawnSeEventDetailsType 
    {
        /// <summary>
        /// availability_zone of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// cloud_name of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// Field introduced in 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "flavor_name")]
        public string? FlavorName { get; set; }
        /// <summary>
        /// host_name of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public string? HostName { get; set; }
        /// <summary>
        /// Unique object identifier of host.
        /// </summary>
        [JsonProperty(PropertyName = "host_uuid")]
        public string? HostUuid { get; set; }
        /// <summary>
        /// Number of memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public int? Memory { get; set; }
        /// <summary>
        /// network_names of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "network_names")]
        public IList<string> NetworkNames { get; set; }
        /// <summary>
        /// networks of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// reason of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_cookie of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_cookie")]
        public string? SeCookie { get; set; }
        /// <summary>
        /// se_grp_name of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_name")]
        public string? SeGrpName { get; set; }
        /// <summary>
        /// Unique object identifier of se_grp.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_uuid")]
        public string? SeGrpUuid { get; set; }
        /// <summary>
        /// se_name of RmSpawnSeEventDetails.
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
        /// <summary>
        /// Number of vcpus.
        /// </summary>
        [JsonProperty(PropertyName = "vcpus")]
        public int? Vcpus { get; set; }
        /// <summary>
        /// vs_name of RmSpawnSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
