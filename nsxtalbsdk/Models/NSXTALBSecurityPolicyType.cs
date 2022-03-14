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
    public class NSXTALBSecurityPolicyType 
    {
        public NSXTALBSecurityPolicyType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Security policy is used to specify various configuration information used to perform Distributed Denial of Service
        /// (DDoS) attacks detection and mitigation. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Source ports and port ranges to deny in DNS Amplification attacks. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_amplification_denyports")]
        public NSXTALBPortMatchGenericType DnsAmplificationDenyports { get; set; }
        /// <summary>
        /// Attacks utilizing the DNS protocol operations. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_attacks")]
        public NSXTALBDnsAttacksType DnsAttacks { get; set; }
        /// <summary>
        /// Index of the dns policy to use for the mitigation rules applied to the dns attacks. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_policy_index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int DnsPolicyIndex { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// The name of the security policy. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Index of the network security policy to use for the mitigation rules applied to the attacks. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "network_security_policy_index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int NetworkSecurityPolicyIndex { get; set; }
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only, or detect and mitigate the attacks. Enum options - DETECTION,
        /// MITIGATION. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "oper_mode")]
        public string? OperMode { get; set; }
        /// <summary>
        /// Attacks utilizing the TCP protocol operations. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_attacks")]
        public NSXTALBTcpAttacksType TcpAttacks { get; set; }
        /// <summary>
        /// Tenancy of the security policy. It is a reference to an object of type Tenant. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Attacks utilizing the UDP protocol operations. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "udp_attacks")]
        public NSXTALBUdpAttacksType UdpAttacks { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// The UUID of the security policy. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
