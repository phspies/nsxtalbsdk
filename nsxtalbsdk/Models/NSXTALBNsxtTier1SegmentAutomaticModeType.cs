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
    public class NSXTALBNsxtTier1SegmentAutomaticModeType 
    {
        public NSXTALBNsxtTier1SegmentAutomaticModeType()
        {
        }
        /// <summary>
        /// Uber IP subnet for the logical segments created automatically by Avi controller. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_segment_subnet", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType NsxtSegmentSubnet { get; set; }
        /// <summary>
        /// The number of SE data vNic's that can be connected to the Avi logical segment. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_se_per_segment")]
        public int? NumSePerSegment { get; set; }
        /// <summary>
        /// Tier1 logical router IDs. Field introduced in 20.1.1. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_lr_ids")]
        public IList<string> Tier1LrIds { get; set; }
    }
}
