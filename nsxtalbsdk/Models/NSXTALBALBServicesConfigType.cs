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
    public class NSXTALBALBServicesConfigType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Default values to be used for Application Signature sync. Field introduced in 20.1.4. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "app_signature_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBAppSignatureConfigType AppSignatureConfig { get; set; }
        /// <summary>
        /// Information about the default contact for this controller cluster. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "asset_contact")]
        public NSXTALBALBServicesUserType AssetContact { get; set; }
        /// <summary>
        /// Default values to be used for pulse case management. Field introduced in 21.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "case_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBCaseConfigType CaseConfig { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Information about the portal features opted in for controller. Field introduced in 20.1.1. Allowed in Enterprise
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "feature_opt_in_status", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBPortalFeatureOptInType FeatureOptInStatus { get; set; }
        /// <summary>
        /// Default values to be used for IP Reputation sync. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpReputationConfigType IpReputationConfig { get; set; }
        /// <summary>
        /// Mode helps log collection and upload. Enum options - MODE_UNKNOWN, SALESFORCE, SYSTEST, MYVMWARE. Field introduced in
        /// 20.1.2. Allowed in Basic(Allowed values- SALESFORCE,MYVMWARE,SYSTEST) edition, Essentials(Allowed values-
        /// SALESFORCE,MYVMWARE,SYSTEST) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// Time interval in minutes. Allowed values are 5-60. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "polling_interval")]
        public int? PollingInterval { get; set; }
        /// <summary>
        /// The FQDN or IP address of the customer portal. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "portal_url", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PortalUrl { get; set; }
        /// <summary>
        /// Saas licensing configuration. Field introduced in 21.1.3. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "saas_licensing_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBSaasLicensingInfoType SaasLicensingConfig { get; set; }
        /// <summary>
        /// Split proxy configuration to connect external pulse services. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "split_proxy_configuration", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBProxyConfigurationType SplitProxyConfiguration { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// By default, pulse uses proxy added in system configuration. If pulse needs to use a seperate proxy, set this flag to
        /// true and configure split proxy configuration. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_split_proxy")]
        public bool? UseSplitProxy { get; set; }
        /// <summary>
        /// Secure the controller to PULSE communication over TLS. Field introduced in 20.1.3. Allowed in Basic edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "use_tls")]
        public bool? UseTls { get; set; }
        /// <summary>
        /// Default values to be used for user agent DB Service. Field introduced in 21.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "user_agent_db_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBUserAgentDBConfigType UserAgentDbConfig { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Default values to be used for pulse waf management. Field introduced in 21.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "waf_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBWafCrsConfigType WafConfig { get; set; }
    }
}
