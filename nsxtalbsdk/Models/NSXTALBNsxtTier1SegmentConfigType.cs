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
    public class NSXTALBNsxtTier1SegmentConfigType 
    {
        public NSXTALBNsxtTier1SegmentConfigType()
        {
        }
        /// <summary>
        /// Avi controller creates and manages logical segments for a Tier-1 LR. Field introduced in 20.1.1. Allowed in Basic
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "automatic")]
        public NSXTALBNsxtTier1SegmentAutomaticModeType Automatic { get; set; }
        /// <summary>
        /// Avi Admin selects an available logical segment (created by NSX-T admin) associated with a Tier-1 LR. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "manual")]
        public NSXTALBNsxtTier1SegmentManualModeType Manual { get; set; }
        /// <summary>
        /// Config Mode for selecting the placement logical segments for Avi ServiceEngine data path. Enum options -
        /// TIER1_SEGMENT_MANUAL, TIER1_SEGMENT_AUTOMATIC. Field introduced in 20.1.1. Allowed in Basic(Allowed values-
        /// TIER1_SEGMENT_MANUAL) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "segment_config_mode", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SegmentConfigMode { get; set; }
    }
}
