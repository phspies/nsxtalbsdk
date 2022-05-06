using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCloudFlavorType
    {
        /// <summary>
        /// cost of CloudFlavor.
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public string? Cost { get; set; }
        /// <summary>
        /// Number of disk_gb.
        /// </summary>
        [JsonProperty(PropertyName = "disk_gb")]
        public int? DiskGb { get; set; }
        /// <summary>
        /// Placeholder for description of property enhanced_nw of obj type CloudFlavor field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "enhanced_nw")]
        public bool? EnhancedNw { get; set; }
        /// <summary>
        /// id of CloudFlavor.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Id { get; set; }
        /// <summary>
        /// If a vm flavor is recommended for requested se_usage_type.Set to True if the chosen VM flavor is recommended for
        /// requested se_usage_type.Else set to False. Field introduced in 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_recommended")]
        public bool? IsRecommended { get; set; }
        /// <summary>
        /// Maximum number of IPv6 addresses that can be configured per NIC. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_ip6s_per_nic")]
        public int? MaxIp6sPerNic { get; set; }
        /// <summary>
        /// Number of max_ips_per_nic.
        /// </summary>
        [JsonProperty(PropertyName = "max_ips_per_nic")]
        public int? MaxIpsPerNic { get; set; }
        /// <summary>
        /// Number of max_nics.
        /// </summary>
        [JsonProperty(PropertyName = "max_nics")]
        public int? MaxNics { get; set; }
        /// <summary>
        /// Placeholder for description of property meta of obj type CloudFlavor field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "meta")]
        public IList<NSXTALBCloudMetaType> Meta { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property public of obj type CloudFlavor field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "public")]
        public bool? Public { get; set; }
        /// <summary>
        /// Number of ram_mb.
        /// </summary>
        [JsonProperty(PropertyName = "ram_mb")]
        public int? RamMb { get; set; }
        /// <summary>
        /// Number of vcpus.
        /// </summary>
        [JsonProperty(PropertyName = "vcpus")]
        public int? Vcpus { get; set; }
    }
}
