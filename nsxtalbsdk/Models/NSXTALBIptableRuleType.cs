using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIptableRuleType
    {
        /// <summary>
        /// Enum options - ACCEPT, DROP, REJECT, DNAT, MASQUERADE.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Action { get; set; }
        /// <summary>
        /// Placeholder for description of property dnat_ip of obj type IptableRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dnat_ip")]
        public NSXTALBIpAddrType DnatIp { get; set; }
        /// <summary>
        /// Placeholder for description of property dst_ip of obj type IptableRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dst_ip")]
        public NSXTALBIpAddrPrefixType DstIp { get; set; }
        /// <summary>
        /// Placeholder for description of property dst_port of obj type IptableRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dst_port")]
        public NSXTALBPortRangeType DstPort { get; set; }
        /// <summary>
        /// input_interface of IptableRule.
        /// </summary>
        [JsonProperty(PropertyName = "input_interface")]
        public string? InputInterface { get; set; }
        /// <summary>
        /// output_interface of IptableRule.
        /// </summary>
        [JsonProperty(PropertyName = "output_interface")]
        public string? OutputInterface { get; set; }
        /// <summary>
        /// Enum options - PROTO_TCP, PROTO_UDP, PROTO_ICMP, PROTO_ALL.
        /// </summary>
        [JsonProperty(PropertyName = "proto")]
        public string? Proto { get; set; }
        /// <summary>
        /// Placeholder for description of property src_ip of obj type IptableRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "src_ip")]
        public NSXTALBIpAddrPrefixType SrcIp { get; set; }
        /// <summary>
        /// Placeholder for description of property src_port of obj type IptableRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "src_port")]
        public NSXTALBPortRangeType SrcPort { get; set; }
        /// <summary>
        /// tag of IptableRule.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
    }
}
