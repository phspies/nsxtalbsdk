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
    public class NSXTALBNsxtSegmentRuntimeType 
    {
        public NSXTALBNsxtSegmentRuntimeType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Nsxt segment belongs to cloud. It is a reference to an object of type Cloud. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// V6 DHCP ranges configured in Nsxt. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp6_ranges")]
        public IList<string> Dhcp6Ranges { get; set; }
        /// <summary>
        /// IP address management scheme for this Segment associated network. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_enabled")]
        public bool? DhcpEnabled { get; set; }
        /// <summary>
        /// DHCP ranges configured in Nsxt. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_ranges")]
        public IList<string> DhcpRanges { get; set; }
        /// <summary>
        /// Segment object name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Network Name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nw_name")]
        public string? NwName { get; set; }
        /// <summary>
        /// Corresponding network object in Avi. It is a reference to an object of type Network. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nw_ref")]
        public string? NwRef { get; set; }
        /// <summary>
        /// Opaque network Id. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "opaque_network_id")]
        public string? OpaqueNetworkId { get; set; }
        /// <summary>
        /// Segment Gateway. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "segment_gw")]
        public string? SegmentGw { get; set; }
        /// <summary>
        /// V6 segment Gateway. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "segment_gw6")]
        public string? SegmentGw6 { get; set; }
        /// <summary>
        /// Segment Id. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "segment_id")]
        public string? SegmentId { get; set; }
        /// <summary>
        /// Segment name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "segname")]
        public string? Segname { get; set; }
        /// <summary>
        /// Segment Cidr. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string? Subnet { get; set; }
        /// <summary>
        /// V6 Segment Cidr. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public string? Subnet6 { get; set; }
        /// <summary>
        /// Nsxt segment belongs to tenant. It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Tier1 router Id. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_id")]
        public string? Tier1Id { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Uuid. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Segment Vlan ids. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_ids")]
        public IList<string> VlanIds { get; set; }
        /// <summary>
        /// Corresponding vrf context object in Avi. It is a reference to an object of type VrfContext. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_context_ref")]
        public string? VrfContextRef { get; set; }
    }
}
