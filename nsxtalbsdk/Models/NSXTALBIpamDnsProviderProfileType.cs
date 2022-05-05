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
    public class NSXTALBIpamDnsProviderProfileType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// If this flag is set, only allocate IP from networks in the Virtual Service VRF. Applicable for Avi Vantage IPAM only.
        /// Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "allocate_ip_in_vrf")]
        public bool? AllocateIpInVrf { get; set; }
        /// <summary>
        /// Provider details if type is AWS.
        /// </summary>
        [JsonProperty(PropertyName = "aws_profile")]
        public NSXTALBIpamDnsAwsProfileType AwsProfile { get; set; }
        /// <summary>
        /// Provider details if type is Microsoft Azure. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "azure_profile")]
        public NSXTALBIpamDnsAzureProfileType AzureProfile { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Provider details if type is Custom. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "custom_profile")]
        public NSXTALBIpamDnsCustomProfileType CustomProfile { get; set; }
        /// <summary>
        /// Provider details if type is Google Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "gcp_profile")]
        public NSXTALBIpamDnsGCPProfileType GcpProfile { get; set; }
        /// <summary>
        /// Provider details if type is Infoblox.
        /// </summary>
        [JsonProperty(PropertyName = "infoblox_profile")]
        public NSXTALBIpamDnsInfobloxProfileType InfobloxProfile { get; set; }
        /// <summary>
        /// Provider details if type is Avi.
        /// </summary>
        [JsonProperty(PropertyName = "internal_profile")]
        public NSXTALBIpamDnsInternalProfileType InternalProfile { get; set; }
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
        /// Name for the IPAM/DNS Provider profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Provider details for Oracle Cloud. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "oci_profile")]
        public NSXTALBIpamDnsOCIProfileType OciProfile { get; set; }
        /// <summary>
        /// Provider details if type is OpenStack.
        /// </summary>
        [JsonProperty(PropertyName = "openstack_profile")]
        public NSXTALBIpamDnsOpenstackProfileType OpenstackProfile { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_configuration")]
        public NSXTALBProxyConfigurationType ProxyConfiguration { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Provider details for Tencent Cloud. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "tencent_profile")]
        public NSXTALBIpamDnsTencentProfileType TencentProfile { get; set; }
        /// <summary>
        /// Provider Type for the IPAM/DNS Provider profile. Enum options - IPAMDNS_TYPE_INFOBLOX, IPAMDNS_TYPE_AWS,
        /// IPAMDNS_TYPE_OPENSTACK, IPAMDNS_TYPE_GCP, IPAMDNS_TYPE_INFOBLOX_DNS, IPAMDNS_TYPE_CUSTOM, IPAMDNS_TYPE_CUSTOM_DNS,
        /// IPAMDNS_TYPE_AZURE, IPAMDNS_TYPE_OCI, IPAMDNS_TYPE_TENCENT, IPAMDNS_TYPE_INTERNAL, IPAMDNS_TYPE_INTERNAL_DNS,
        /// IPAMDNS_TYPE_AWS_DNS, IPAMDNS_TYPE_AZURE_DNS. Allowed in Basic(Allowed values- IPAMDNS_TYPE_INTERNAL) edition,
        /// Essentials(Allowed values- IPAMDNS_TYPE_INTERNAL) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the IPAM/DNS Provider profile.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
