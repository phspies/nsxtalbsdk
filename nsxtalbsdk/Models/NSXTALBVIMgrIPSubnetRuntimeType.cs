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
    public class NSXTALBVIMgrIPSubnetRuntimeType 
    {
        public NSXTALBVIMgrIPSubnetRuntimeType()
        {
        }
        /// <summary>
        /// If true, capable of floating/elastic IP association.
        /// </summary>
        [JsonProperty(PropertyName = "fip_available")]
        public bool? FipAvailable { get; set; }
        /// <summary>
        /// If fip_available is True, this is list of supported FIP subnets, possibly empty if Cloud does not support such a network
        /// list.
        /// </summary>
        [JsonProperty(PropertyName = "fip_subnet_uuids")]
        public IList<string> FipSubnetUuids { get; set; }
        /// <summary>
        /// If fip_available is True, the list of associated FloatingIP subnets, possibly empty if unsupported or implictly defined
        /// by the Cloud. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "floatingip_subnets")]
        public IList<NSXTALBFloatingIpSubnetType> FloatingipSubnets { get; set; }
        /// <summary>
        /// ip_subnet of VIMgrIPSubnetRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "ip_subnet")]
        public string? IpSubnet { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property prefix of obj type VIMgrIPSubnetRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Prefix { get; set; }
        /// <summary>
        /// True if prefix is primary IP on interface, else false.
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public bool? Primary { get; set; }
        /// <summary>
        /// Number of ref_count.
        /// </summary>
        [JsonProperty(PropertyName = "ref_count")]
        public int? RefCount { get; set; }
        /// <summary>
        /// Number of se_ref_count.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref_count")]
        public int? SeRefCount { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
