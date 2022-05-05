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
    public class NSXTALBManagementNetworkConfigType 
    {
        /// <summary>
        /// Management overlay segment to use for Avi Service Engines. This should be set only when transport zone is of type
        /// OVERLAY. Field introduced in 20.1.5. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "overlay_segment")]
        public NSXTALBTier1LogicalRouterInfoType OverlaySegment { get; set; }
        /// <summary>
        /// Management transport zone path for Avi Service Engines. Example-
        /// /infra/sites/default/enforcement-points/default/transport-zones/xxx-xxx-xxxx. Field introduced in 20.1.5. Allowed in
        /// Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TransportZone { get; set; }
        /// <summary>
        /// Management transport zone type overlay or vlan. Enum options - OVERLAY, VLAN. Field introduced in 20.1.5. Allowed in
        /// Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "tz_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TzType { get; set; }
        /// <summary>
        /// Management vlan segment path to use for Avi Service Engines. Example- /infra/segments/vlanls. This should be set only
        /// when transport zone is of type VLAN. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_segment")]
        public string? VlanSegment { get; set; }
    }
}
