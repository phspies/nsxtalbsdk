using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIpamDnsAwsProfileType
    {
        /// <summary>
        /// AWS access key ID.
        /// </summary>
        [JsonProperty(PropertyName = "access_key_id")]
        public string? AccessKeyId { get; set; }
        /// <summary>
        /// A list of subnets used for source IP allocation for egress services in Openshift/k8s on Aws. Field introduced in 18.2.3.
        /// Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "egress_service_subnets")]
        public IList<string> EgressServiceSubnets { get; set; }
        /// <summary>
        /// IAM assume role for cross-account access. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "iam_assume_role")]
        public string? IamAssumeRole { get; set; }
        /// <summary>
        /// If enabled and the virtual service is not floating ip capable, vip will be published to both private and public zones.
        /// This flag is applicable only for AWS DNS profile. Field introduced in 17.2.10.
        /// </summary>
        [JsonProperty(PropertyName = "publish_vip_to_public_zone")]
        public bool? PublishVipToPublicZone { get; set; }
        /// <summary>
        /// AWS region.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// AWS secret access key.
        /// </summary>
        [JsonProperty(PropertyName = "secret_access_key")]
        public string? SecretAccessKey { get; set; }
        /// <summary>
        /// Default TTL for all records. Allowed values are 1-172800. Field introduced in 17.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public int? Ttl { get; set; }
        /// <summary>
        /// Usable domains to pick from Amazon Route 53. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "usable_domains")]
        public IList<string> UsableDomains { get; set; }
        /// <summary>
        /// Usable networks for Virtual IP. If VirtualService does not specify a network and auto_allocate_ip is set, then the first
        /// available network from this list will be chosen for IP allocation. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "usable_network_uuids")]
        public IList<string> UsableNetworkUuids { get; set; }
        /// <summary>
        /// Use IAM roles instead of access and secret key.
        /// </summary>
        [JsonProperty(PropertyName = "use_iam_roles")]
        public bool? UseIamRoles { get; set; }
        /// <summary>
        /// VPC name.
        /// </summary>
        [JsonProperty(PropertyName = "vpc")]
        public string? Vpc { get; set; }
        /// <summary>
        /// VPC ID.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VpcId { get; set; }
        /// <summary>
        /// Network configuration for Virtual IP per AZ. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<NSXTALBAwsZoneNetworkType> Zones { get; set; }
    }
}
