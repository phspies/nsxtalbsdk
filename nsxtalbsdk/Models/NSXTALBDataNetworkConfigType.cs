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
    public class NSXTALBDataNetworkConfigType 
    {
        public NSXTALBDataNetworkConfigType()
        {
        }
        /// <summary>
        /// Nsxt tier1 segment configuration for Avi Service Engine data path. This should be set only when transport zone is of
        /// type OVERLAY. Field introduced in 20.1.5. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_segment_config")]
        public NSXTALBNsxtTier1SegmentConfigType Tier1SegmentConfig { get; set; }
        /// <summary>
        /// Data transport zone path for Avi Service Engines. Example-
        /// /infra/sites/default/enforcement-points/default/transport-zones/xxx-xxx-xxxx. Field introduced in 20.1.5. Allowed in
        /// Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string TransportZone { get; set; }
        /// <summary>
        /// Data transport zone type overlay or vlan. Enum options - OVERLAY, VLAN. Field introduced in 20.1.5. Allowed in Basic
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "tz_type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string TzType { get; set; }
        /// <summary>
        /// Data vlan segments path to use for Avi Service Engines. Example- /infra/segments/vlanls. This should be set only when
        /// transport zone is of type VLAN. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_segments")]
        public IList<string> VlanSegments { get; set; }
    }
}
