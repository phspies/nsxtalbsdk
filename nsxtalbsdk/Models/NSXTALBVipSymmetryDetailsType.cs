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
    public class NSXTALBVipSymmetryDetailsType 
    {
        public NSXTALBVipSymmetryDetailsType()
        {
        }
        /// <summary>
        /// Maximum number of SEs assigned across all Virtual Services sharing this VIP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "max_num_se_assigned")]
        public int? MaxNumSeAssigned { get; set; }
        /// <summary>
        /// Maximum number of SEs requested across all Virtual Services sharing this VIP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "max_num_se_requested")]
        public int? MaxNumSeRequested { get; set; }
        /// <summary>
        /// Minimum number of SEs assigned across all Virtual Services sharing this VIP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "min_num_se_assigned")]
        public int? MinNumSeAssigned { get; set; }
        /// <summary>
        /// Minimum number of SEs requested across all Virtual Services sharing this VIP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "min_num_se_requested")]
        public int? MinNumSeRequested { get; set; }
        /// <summary>
        /// Number of Virtual Services sharing VsVip. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs")]
        public int? NumVs { get; set; }
        /// <summary>
        /// Reason for symmetric/asymmetric shared VIP event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// VIP ID. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// VsVip Name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vsvip_name")]
        public string? VsvipName { get; set; }
        /// <summary>
        /// VsVip UUID. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vsvip_uuid")]
        public string? VsvipUuid { get; set; }
    }
}
