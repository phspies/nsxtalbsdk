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
    public class NSXTALBApplicationProfileType 
    {
        public NSXTALBApplicationProfileType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Specifies app service type for an application. Enum options - APP_SERVICE_TYPE_L7_HORIZON, APP_SERVICE_TYPE_L4_BLAST,
        /// APP_SERVICE_TYPE_L4_PCOIP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "app_service_type")]
        public string? AppServiceType { get; set; }
        /// <summary>
        /// Checksum of application profiles. Internally set by cloud connector. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Name of the application profile creator. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Specifies various DNS service related controls for virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "dns_service_profile")]
        public NSXTALBDnsServiceApplicationProfileType DnsServiceProfile { get; set; }
        /// <summary>
        /// Specifies various security related controls for virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "dos_rl_profile")]
        public NSXTALBDosRateLimitProfileType DosRlProfile { get; set; }
        /// <summary>
        /// Specifies the HTTP application proxy profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "http_profile")]
        public NSXTALBHTTPApplicationProfileType HttpProfile { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// The name of the application profile.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Specifies if client IP needs to be preserved for backend connection. Not compatible with Connection Multiplexing.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_client_ip")]
        public bool? PreserveClientIp { get; set; }
        /// <summary>
        /// Specifies if we need to preserve client port while preserving client IP for backend connections. Field introduced in
        /// 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_client_port")]
        public bool? PreserveClientPort { get; set; }
        /// <summary>
        /// Specifies if destination IP and port needs to be preserved for backend connection. Field introduced in 20.1.1. Allowed
        /// in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_dest_ip_port")]
        public bool? PreserveDestIpPort { get; set; }
        /// <summary>
        /// Specifies various SIP service related controls for virtual service. Field introduced in 17.2.8, 18.1.3, 18.2.1. Allowed
        /// in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sip_service_profile")]
        public NSXTALBSipServiceApplicationProfileType SipServiceProfile { get; set; }
        /// <summary>
        /// Specifies the TCP application proxy profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_app_profile")]
        public NSXTALBTCPApplicationProfileType TcpAppProfile { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Specifies which application layer proxy is enabled for the virtual service. Enum options - APPLICATION_PROFILE_TYPE_L4,
        /// APPLICATION_PROFILE_TYPE_HTTP, APPLICATION_PROFILE_TYPE_SYSLOG, APPLICATION_PROFILE_TYPE_DNS,
        /// APPLICATION_PROFILE_TYPE_SSL, APPLICATION_PROFILE_TYPE_SIP. Allowed in Basic(Allowed values-
        /// APPLICATION_PROFILE_TYPE_L4,APPLICATION_PROFILE_TYPE_HTTP) edition, Essentials(Allowed values-
        /// APPLICATION_PROFILE_TYPE_L4) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the application profile.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
