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
    public class NSXTALBPoolType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Name of container cloud application that constitutes A pool in a A-B pool configuration, if different from VS app. Field
        /// deprecated in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "a_pool")]
        public string? APool { get; set; }
        /// <summary>
        /// A/B pool configuration. Field deprecated in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ab_pool")]
        public NSXTALBAbPoolType AbPool { get; set; }
        /// <summary>
        /// Priority of this pool in a A-B pool pair. Internally used. Field deprecated in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ab_priority")]
        public int? AbPriority { get; set; }
        /// <summary>
        /// Determines analytics settings for the pool. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "analytics_policy")]
        public NSXTALBPoolAnalyticsPolicyType AnalyticsPolicy { get; set; }
        /// <summary>
        /// Specifies settings related to analytics. It is a reference to an object of type AnalyticsProfile. Field introduced in
        /// 18.1.4,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "analytics_profile_ref")]
        public string? AnalyticsProfileRef { get; set; }
        /// <summary>
        /// Synchronize Cisco APIC EPG members with pool servers. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_epg_name")]
        public string? ApicEpgName { get; set; }
        /// <summary>
        /// Allows the option to append port to hostname in the host header while sending a request to the server. By default, port
        /// is appended for non-default ports. This setting will apply for Pool's 'Rewrite Host Header to Server Name', 'Rewrite
        /// Host Header to SNI' features and Server's 'Rewrite Host Header' settings as well as HTTP healthmonitors attached to
        /// pools. Enum options - NON_DEFAULT_80_443, NEVER, ALWAYS. Field introduced in 21.1.1. Allowed in Basic(Allowed values-
        /// NEVER) edition, Essentials(Allowed values- NEVER) edition, Enterprise edition. Special default for Basic edition is
        /// NEVER, Essentials edition is NEVER, Enterprise is NON_DEFAULT_80_443.
        /// </summary>
        [JsonProperty(PropertyName = "append_port")]
        public string? AppendPort { get; set; }
        /// <summary>
        /// Persistence will ensure the same user sticks to the same server for a desired duration of time. It is a reference to an
        /// object of type ApplicationPersistenceProfile.
        /// </summary>
        [JsonProperty(PropertyName = "application_persistence_profile_ref")]
        public string? ApplicationPersistenceProfileRef { get; set; }
        /// <summary>
        /// If configured then Avi will trigger orchestration of pool server creation and deletion. It is a reference to an object
        /// of type AutoScaleLaunchConfig.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_launch_config_ref")]
        public string? AutoscaleLaunchConfigRef { get; set; }
        /// <summary>
        /// Network Ids for the launch configuration.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_networks")]
        public IList<string> AutoscaleNetworks { get; set; }
        /// <summary>
        /// Reference to Server Autoscale Policy. It is a reference to an object of type ServerAutoScalePolicy.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_policy_ref")]
        public string? AutoscalePolicyRef { get; set; }
        /// <summary>
        /// Inline estimation of capacity of servers. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values-
        /// false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "capacity_estimation")]
        public bool? CapacityEstimation { get; set; }
        /// <summary>
        /// The maximum time-to-first-byte of a server. Allowed values are 1-5000. Special values are 0 - Automatic. Unit is
        /// MILLISECONDS. Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "capacity_estimation_ttfb_thresh")]
        public int? CapacityEstimationTtfbThresh { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for Pool. Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Connnection pool properties. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "conn_pool_properties")]
        public NSXTALBConnPoolPropertiesType ConnPoolProperties { get; set; }
        /// <summary>
        /// Duration for which new connections will be gradually ramped up to a server recently brought online.  Useful for LB
        /// algorithms that are least connection based. Allowed values are 1-300. Special values are 0 - Immediate. Unit is MIN.
        /// Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition. Special default
        /// for Basic edition is 0, Essentials edition is 0, Enterprise is 10.
        /// </summary>
        [JsonProperty(PropertyName = "connection_ramp_duration")]
        public int? ConnectionRampDuration { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Traffic sent to servers will use this destination server port unless overridden by the server's specific port attribute.
        /// The SSL checkbox enables Avi to server encryption. Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "default_server_port")]
        public int? DefaultServerPort { get; set; }
        /// <summary>
        /// Indicates whether existing IPs are disabled(false) or deleted(true) on dns hostname refreshDetail -- On a dns refresh,
        /// some IPs set on pool may no longer be returned by the resolver. These IPs are deleted from the pool when this knob is
        /// set to true. They are disabled, if the knob is set to false. Field introduced in 18.2.3. Allowed in Basic(Allowed
        /// values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "delete_server_on_dns_refresh")]
        public bool? DeleteServerOnDnsRefresh { get; set; }
        /// <summary>
        /// A description of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Comma separated list of domain names which will be used to verify the common names or subject alternative names
        /// presented by server certificates. It is performed only when common name check host_check_enabled is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        public IList<string> DomainName { get; set; }
        /// <summary>
        /// Inherited config from VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "east_west")]
        public bool? EastWest { get; set; }
        /// <summary>
        /// Enable HTTP/2 for traffic from VirtualService to all backend servers in this pool. Field introduced in 20.1.1. Allowed
        /// in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_http2")]
        public bool? EnableHttp2 { get; set; }
        /// <summary>
        /// Enable or disable the pool.  Disabling will terminate all open connections and pause health monitors.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Names of external auto-scale groups for pool servers. Currently available only for AWS and Azure. Field introduced in
        /// 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "external_autoscale_groups")]
        public IList<string> ExternalAutoscaleGroups { get; set; }
        /// <summary>
        /// Enable an action - Close Connection, HTTP Redirect or Local HTTP Response - when a pool failure happens. By default, a
        /// connection will be closed, in case the pool experiences a failure.
        /// </summary>
        [JsonProperty(PropertyName = "fail_action")]
        public NSXTALBFailActionType FailAction { get; set; }
        /// <summary>
        /// Periodicity of feedback for fewest tasks server selection algorithm. Allowed values are 1-300. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "fewest_tasks_feedback_delay")]
        public int? FewestTasksFeedbackDelay { get; set; }
        /// <summary>
        /// Used to gracefully disable a server. Virtual service waits for the specified time before terminating the existing
        /// connections  to the servers that are disabled. Allowed values are 1-7200. Special values are 0 - Immediate, -1 -
        /// Infinite. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_disable_timeout")]
        public int? GracefulDisableTimeout { get; set; }
        /// <summary>
        /// Indicates if the pool is a site-persistence pool. . Field introduced in 17.2.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_sp_enabled")]
        public bool? GslbSpEnabled { get; set; }
        /// <summary>
        /// Verify server health by applying one or more health monitors.  Active monitors generate synthetic traffic from each
        /// Service Engine and mark a server up or down based on the response. The Passive monitor listens only to client to server
        /// communication. It raises or lowers the ratio of traffic destined to a server based on successful responses. It is a
        /// reference to an object of type HealthMonitor. Maximum of 50 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "health_monitor_refs")]
        public IList<string> HealthMonitorRefs { get; set; }
        /// <summary>
        /// Horizon UAG configuration. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "horizon_profile")]
        public NSXTALBHorizonProfileType HorizonProfile { get; set; }
        /// <summary>
        /// Enable common name check for server certificate. If enabled and no explicit domain name is specified, Avi will use the
        /// incoming host header to do the match.
        /// </summary>
        [JsonProperty(PropertyName = "host_check_enabled")]
        public bool? HostCheckEnabled { get; set; }
        /// <summary>
        /// HTTP2 pool properties. Field introduced in 21.1.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "http2_properties")]
        public NSXTALBHTTP2PoolPropertiesType Http2Properties { get; set; }
        /// <summary>
        /// Ignore the server port in building the load balancing state.Applicable only for consistent hash load balancing algorithm
        /// or Disable Port translation (use_service_port) use cases. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_server_port")]
        public bool? IgnoreServerPort { get; set; }
        /// <summary>
        /// The Passive monitor will monitor client to server connections and requests and adjust traffic load to servers based on
        /// successful responses.  This may alter the expected behavior of the LB method, such as Round Robin.
        /// </summary>
        [JsonProperty(PropertyName = "inline_health_monitor")]
        public bool? InlineHealthMonitor { get; set; }
        /// <summary>
        /// Use list of servers from Ip Address Group. It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "ipaddrgroup_ref")]
        public string? IpaddrgroupRef { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// The load balancing algorithm will pick a server within the pool's list of available servers. Values
        /// LB_ALGORITHM_NEAREST_SERVER and LB_ALGORITHM_TOPOLOGY are only allowed for GSLB pool. Enum options -
        /// LB_ALGORITHM_LEAST_CONNECTIONS, LB_ALGORITHM_ROUND_ROBIN, LB_ALGORITHM_FASTEST_RESPONSE, LB_ALGORITHM_CONSISTENT_HASH,
        /// LB_ALGORITHM_LEAST_LOAD, LB_ALGORITHM_FEWEST_SERVERS, LB_ALGORITHM_RANDOM, LB_ALGORITHM_FEWEST_TASKS,
        /// LB_ALGORITHM_NEAREST_SERVER, LB_ALGORITHM_CORE_AFFINITY, LB_ALGORITHM_TOPOLOGY. Allowed in Basic(Allowed values-
        /// LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN,LB_ALGORITHM_CONSISTENT_HASH) edition, Essentials(Allowed
        /// values- LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN,LB_ALGORITHM_CONSISTENT_HASH) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm")]
        public string? LbAlgorithm { get; set; }
        /// <summary>
        /// HTTP header name to be used for the hash key.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm_consistent_hash_hdr")]
        public string? LbAlgorithmConsistentHashHdr { get; set; }
        /// <summary>
        /// Degree of non-affinity for core affinity based server selection. Allowed values are 1-65535. Field introduced in 17.1.3.
        /// Allowed in Basic(Allowed values- 2) edition, Essentials(Allowed values- 2) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm_core_nonaffinity")]
        public int? LbAlgorithmCoreNonaffinity { get; set; }
        /// <summary>
        /// Criteria used as a key for determining the hash between the client and  server. Enum options -
        /// LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS, LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS_AND_PORT,
        /// LB_ALGORITHM_CONSISTENT_HASH_URI, LB_ALGORITHM_CONSISTENT_HASH_CUSTOM_HEADER,
        /// LB_ALGORITHM_CONSISTENT_HASH_CUSTOM_STRING, LB_ALGORITHM_CONSISTENT_HASH_CALLID. Allowed in Basic(Allowed values-
        /// LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS) edition, Essentials(Allowed values-
        /// LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm_hash")]
        public string? LbAlgorithmHash { get; set; }
        /// <summary>
        /// Allow server lookup by name. Field introduced in 17.1.11,17.2.4. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "lookup_server_by_name")]
        public bool? LookupServerByName { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// The maximum number of concurrent connections allowed to each server within the pool. NOTE  applied value will be no less
        /// than the number of service engines that the pool is placed on. If set to 0, no limit is applied.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_connections_per_server")]
        public int? MaxConcurrentConnectionsPerServer { get; set; }
        /// <summary>
        /// Rate Limit connections to each server.
        /// </summary>
        [JsonProperty(PropertyName = "max_conn_rate_per_server")]
        public NSXTALBRateProfileType MaxConnRatePerServer { get; set; }
        /// <summary>
        /// Minimum number of health monitors in UP state to mark server UP. Field introduced in 18.2.1, 17.2.12. Allowed in Basic
        /// edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "min_health_monitors_up")]
        public int? MinHealthMonitorsUp { get; set; }
        /// <summary>
        /// Minimum number of servers in UP state for marking the pool UP. Field introduced in 18.2.1, 17.2.12.
        /// </summary>
        [JsonProperty(PropertyName = "min_servers_up")]
        public int? MinServersUp { get; set; }
        /// <summary>
        /// The name of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// (internal-use) Networks designated as containing servers for this pool.  The servers may be further narrowed down by a
        /// filter. This field is used internally by Avi, not editable by the user.
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<NSXTALBNetworkFilterType> Networks { get; set; }
        /// <summary>
        /// A list of NSX Groups where the Servers for the Pool are created . Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_securitygroup")]
        public IList<string> NsxSecuritygroup { get; set; }
        /// <summary>
        /// Avi will validate the SSL certificate present by a server against the selected PKI Profile. It is a reference to an
        /// object of type PKIProfile.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_ref")]
        public string? PkiProfileRef { get; set; }
        /// <summary>
        /// Manually select the networks and subnets used to provide reachability to the pool's servers.  Specify the Subnet using
        /// the following syntax  10-1-1-0/24. Use static routes in VRF configuration when pool servers are not directly connected
        /// but routable from the service engine.
        /// </summary>
        [JsonProperty(PropertyName = "placement_networks")]
        public IList<NSXTALBPlacementNetworkType> PlacementNetworks { get; set; }
        /// <summary>
        /// Header name for custom header persistence. Field deprecated in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_name")]
        public string? PrstHdrName { get; set; }
        /// <summary>
        /// Minimum number of requests to be queued when pool is full. Allowed in Basic(Allowed values- 128) edition,
        /// Essentials(Allowed values- 128) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "request_queue_depth")]
        public int? RequestQueueDepth { get; set; }
        /// <summary>
        /// Enable request queue when pool is full. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values-
        /// false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "request_queue_enabled")]
        public bool? RequestQueueEnabled { get; set; }
        /// <summary>
        /// This field is used as a flag to create a job for JobManager. Field introduced in 18.2.10,20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "resolve_pool_by_dns")]
        public bool? ResolvePoolByDns { get; set; }
        /// <summary>
        /// Rewrite incoming Host Header to server name of the server to which the request is proxied.  Enabling this feature
        /// rewrites Host Header for requests to all servers in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_host_header_to_server_name")]
        public bool? RewriteHostHeaderToServerName { get; set; }
        /// <summary>
        /// If SNI server name is specified, rewrite incoming host header to the SNI server name.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_host_header_to_sni")]
        public bool? RewriteHostHeaderToSni { get; set; }
        /// <summary>
        /// Enable to do routing when this pool is selected to send traffic. No servers present in routing pool. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "routing_pool")]
        public bool? RoutingPool { get; set; }
        /// <summary>
        /// Server AutoScale. Not used anymore. Field deprecated in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "server_auto_scale")]
        public bool? ServerAutoScale { get; set; }
        /// <summary>
        /// Field deprecated in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_count")]
        public int? ServerCount { get; set; }
        /// <summary>
        /// Server graceful disable timeout behaviour. Enum options - DISALLOW_NEW_CONNECTION,
        /// ALLOW_NEW_CONNECTION_IF_PERSISTENCE_PRESENT. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_disable_type")]
        public string? ServerDisableType { get; set; }
        /// <summary>
        /// Fully qualified DNS hostname which will be used in the TLS SNI extension in server connections if SNI is enabled. If no
        /// value is specified, Avi will use the incoming host header instead.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        public string? ServerName { get; set; }
        /// <summary>
        /// Server reselect configuration for HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "server_reselect")]
        public NSXTALBHTTPServerReselectType ServerReselect { get; set; }
        /// <summary>
        /// Server timeout value specifies the time within which a server connection needs to be established and a request-response
        /// exchange completes between AVI and the server. Value of 0 results in using default timeout of 60 minutes. Allowed values
        /// are 0-21600000. Field introduced in 18.1.5,18.2.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "server_timeout")]
        public int? ServerTimeout { get; set; }
        /// <summary>
        /// The pool directs load balanced traffic to this list of destination servers. The servers can be configured by IP address,
        /// name, network or via IP Address Group. Maximum of 5000 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        public IList<NSXTALBServerType> Servers { get; set; }
        /// <summary>
        /// Metadata pertaining to the service provided by this Pool. In Openshift/Kubernetes environments, app metadata info is
        /// stored. Any user input to this field will be overwritten by Avi Vantage. Field introduced in 17.2.14,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_metadata")]
        public string? ServiceMetadata { get; set; }
        /// <summary>
        /// Enable TLS SNI for server connections. If disabled, Avi will not send the SNI extension as part of the handshake.
        /// </summary>
        [JsonProperty(PropertyName = "sni_enabled")]
        public bool? SniEnabled { get; set; }
        /// <summary>
        /// Service Engines will present a client SSL certificate to the server. It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_ref")]
        public string? SslKeyAndCertificateRef { get; set; }
        /// <summary>
        /// When enabled, Avi re-encrypts traffic to the backend servers. The specific SSL profile defines which ciphers and SSL
        /// versions will be supported. It is a reference to an object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_ref")]
        public string? SslProfileRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// This tier1_lr field should be set same as VirtualService associated for NSX-T. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_lr")]
        public string? Tier1Lr { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Do not translate the client's destination port when sending the connection to the server. Monitor port needs to be
        /// specified for health monitors. Allowed in Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "use_service_port")]
        public bool? UseServicePort { get; set; }
        /// <summary>
        /// This applies only when use_service_port is set to true. If enabled, SSL mode of the connection to the server is decided
        /// by the SSL mode on the Virtualservice service port, on which the request was received. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_service_ssl_mode")]
        public bool? UseServiceSslMode { get; set; }
        /// <summary>
        /// UUID of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Virtual Routing Context that the pool is bound to. This is used to provide the isolation of the set of networks the pool
        /// is attached to. The pool inherits the Virtual Routing Conext of the Virtual Service, and this field is used only
        /// internally, and is set by pb-transform. It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_ref")]
        public string? VrfRef { get; set; }
    }
}
