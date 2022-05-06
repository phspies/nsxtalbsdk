using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbServiceType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// The federated application persistence associated with GslbService site persistence functionality. . It is a reference to
        /// an object of type ApplicationPersistenceProfile. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "application_persistence_profile_ref")]
        public string? ApplicationPersistenceProfileRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// GS member's overall health status is derived based on a combination of controller and datapath health-status inputs.
        /// Note that the datapath status is determined by the association of health monitor profiles. Only the controller provided
        /// status is determined through this configuration. .
        /// </summary>
        [JsonProperty(PropertyName = "controller_health_status_enabled")]
        public bool? ControllerHealthStatusEnabled { get; set; }
        /// <summary>
        /// Creator name. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Fully qualified domain name of the GSLB service. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
        /// <summary>
        /// Response to the client query when the GSLB service is DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "down_response")]
        public NSXTALBGslbServiceDownResponseType DownResponse { get; set; }
        /// <summary>
        /// Enable or disable the GSLB service. If the GSLB service is enabled, then the VIPs are sent in the DNS responses based on
        /// reachability and configured algorithm. If the GSLB service is disabled, then the VIPs are no longer available in the DNS
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Select list of pools belonging to this GSLB service. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<NSXTALBGslbPoolType> Groups { get; set; }
        /// <summary>
        /// Verify VS health by applying one or more health monitors.  Active monitors generate synthetic traffic from DNS Service
        /// Engine and to mark a VS up or down based on the response. . It is a reference to an object of type HealthMonitor.
        /// Maximum of 6 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "health_monitor_refs")]
        public IList<string> HealthMonitorRefs { get; set; }
        /// <summary>
        /// Health monitor probe can be executed for all the members or it can be executed only for third-party members. This
        /// operational mode is useful to reduce the number of health monitor probes in case of a hybrid scenario. In such a case,
        /// Avi members can have controller derived status while Non-Avi members can be probed by via health monitor probes in
        /// dataplane. Enum options - GSLB_SERVICE_HEALTH_MONITOR_ALL_MEMBERS, GSLB_SERVICE_HEALTH_MONITOR_ONLY_NON_AVI_MEMBERS.
        /// </summary>
        [JsonProperty(PropertyName = "health_monitor_scope")]
        public string? HealthMonitorScope { get; set; }
        /// <summary>
        /// This field is an internal field and is used in SE. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "hm_off")]
        public bool? HmOff { get; set; }
        /// <summary>
        /// This field indicates that this object is replicated across GSLB federation. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
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
        /// The minimum number of members to distribute traffic to. Allowed values are 1-65535. Special values are 0 - Disable.
        /// Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "min_members")]
        public int? MinMembers { get; set; }
        /// <summary>
        /// Name for the GSLB service.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Number of IP addresses of this GSLB service to be returned by the DNS Service. Enter 0 to return all IP addresses.
        /// Allowed values are 1-20. Special values are 0- Return all IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "num_dns_ip")]
        public int? NumDnsIp { get; set; }
        /// <summary>
        /// The load balancing algorithm will pick a GSLB pool within the GSLB service list of available pools. Enum options -
        /// GSLB_SERVICE_ALGORITHM_PRIORITY, GSLB_SERVICE_ALGORITHM_GEO. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_algorithm")]
        public string? PoolAlgorithm { get; set; }
        /// <summary>
        /// This field indicates that for a CNAME query, respond with resolved CNAMEs in the additional section with A records.
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "resolve_cname")]
        public bool? ResolveCname { get; set; }
        /// <summary>
        /// Enable site-persistence for the GslbService. . Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "site_persistence_enabled")]
        public bool? SitePersistenceEnabled { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// TTL value (in seconds) for records served for this GSLB service by the DNS Service. Allowed values are 0-86400. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public int? Ttl { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Use the client ip subnet from the EDNS option as source IPaddress for client geo-location and consistent hash algorithm.
        /// Default is true. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_edns_client_subnet")]
        public bool? UseEdnsClientSubnet { get; set; }
        /// <summary>
        /// UUID of the GSLB service.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Enable wild-card match of fqdn  if an exact match is not found in the DNS table, the longest match is chosen by
        /// wild-carding the fqdn in the DNS request. Default is false. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "wildcard_match")]
        public bool? WildcardMatch { get; set; }
    }
}
