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
    public class NSXTALBSystemConfigurationType 
    {
        public NSXTALBSystemConfigurationType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Placeholder for description of property admin_auth_configuration of obj type SystemConfiguration field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "admin_auth_configuration")]
        public NSXTALBAdminAuthConfigurationType AdminAuthConfiguration { get; set; }
        /// <summary>
        /// Common criteria mode's current state. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "common_criteria_mode")]
        public bool? CommonCriteriaMode { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Controller metrics event dynamic thresholds can be set here. CONTROLLER_CPU_HIGH and CONTROLLER_MEM_HIGH evets can take
        /// configured dynamic thresholds. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "controller_analytics_policy")]
        public NSXTALBControllerAnalyticsPolicyType ControllerAnalyticsPolicy { get; set; }
        /// <summary>
        /// Specifies the default license tier which would be used by new Clouds. Enum options - ENTERPRISE_16, ENTERPRISE,
        /// ENTERPRISE_18, BASIC, ESSENTIALS, ENTERPRISE_WITH_CLOUD_SERVICES. Field introduced in 17.2.5. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition. Special default for Basic edition is BASIC, Essentials edition is ESSENTIALS,
        /// Enterprise is ENTERPRISE_WITH_CLOUD_SERVICES.
        /// </summary>
        [JsonProperty(PropertyName = "default_license_tier")]
        public string? DefaultLicenseTier { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_configuration of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dns_configuration")]
        public NSXTALBDNSConfigurationType DnsConfiguration { get; set; }
        /// <summary>
        /// DNS virtualservices hosting FQDN records for applications across Avi Vantage. If no virtualservices are provided, Avi
        /// Vantage will provide DNS services for configured applications. Switching back to Avi Vantage from DNS virtualservices is
        /// not allowed. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "dns_virtualservice_refs")]
        public IList<string> DnsVirtualserviceRefs { get; set; }
        /// <summary>
        /// Placeholder for description of property docker_mode of obj type SystemConfiguration field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "docker_mode")]
        public bool? DockerMode { get; set; }
        /// <summary>
        /// Placeholder for description of property email_configuration of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "email_configuration")]
        public NSXTALBEmailConfigurationType EmailConfiguration { get; set; }
        /// <summary>
        /// Enable CORS Header. Field introduced in 20.1.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_cors")]
        public bool? EnableCors { get; set; }
        /// <summary>
        /// FIPS mode current state. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fips_mode")]
        public bool? FipsMode { get; set; }
        /// <summary>
        /// Placeholder for description of property global_tenant_config of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "global_tenant_config")]
        public NSXTALBTenantConfigurationType GlobalTenantConfig { get; set; }
        /// <summary>
        /// Placeholder for description of property linux_configuration of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "linux_configuration")]
        public NSXTALBLinuxConfigurationType LinuxConfiguration { get; set; }
        /// <summary>
        /// Configure Ip Access control for controller to restrict open access.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_ip_access_control")]
        public NSXTALBMgmtIpAccessControlType MgmtIpAccessControl { get; set; }
        /// <summary>
        /// Placeholder for description of property ntp_configuration of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ntp_configuration")]
        public NSXTALBNTPConfigurationType NtpConfiguration { get; set; }
        /// <summary>
        /// Placeholder for description of property portal_configuration of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "portal_configuration")]
        public NSXTALBPortalConfigurationType PortalConfiguration { get; set; }
        /// <summary>
        /// Placeholder for description of property proxy_configuration of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "proxy_configuration")]
        public NSXTALBProxyConfigurationType ProxyConfiguration { get; set; }
        /// <summary>
        /// Configure Secure Channel properties. Field introduced in 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "secure_channel_configuration")]
        public NSXTALBSecureChannelConfigurationType SecureChannelConfiguration { get; set; }
        /// <summary>
        /// Placeholder for description of property snmp_configuration of obj type SystemConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "snmp_configuration")]
        public NSXTALBSnmpConfigurationType SnmpConfiguration { get; set; }
        /// <summary>
        /// Allowed Ciphers list for SSH to the management interface on the Controller and Service Engines. If this is not
        /// specified, all the default ciphers are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_ciphers")]
        public IList<string> SshCiphers { get; set; }
        /// <summary>
        /// Allowed HMAC list for SSH to the management interface on the Controller and Service Engines. If this is not specified,
        /// all the default HMACs are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_hmacs")]
        public IList<string> SshHmacs { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// This flag is set once the Initial Controller Setup workflow is complete. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "welcome_workflow_complete")]
        public bool? WelcomeWorkflowComplete { get; set; }
    }
}
