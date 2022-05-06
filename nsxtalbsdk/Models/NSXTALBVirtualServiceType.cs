using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVirtualServiceType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// This configuration only applies if the VirtualService is in Legacy Active Standby HA mode and Load Distribution among
        /// Active Standby is enabled. This field is used to tag the VirtualService so that VirtualServices with the same tag will
        /// share the same Active ServiceEngine. VirtualServices with different tags will have different Active ServiceEngines. If
        /// one of the ServiceEngine's in the ServiceEngineGroup fails, all VirtualServices will end up using the same Active
        /// ServiceEngine. Redistribution of the VirtualServices can be either manual or automated when the failed ServiceEngine
        /// recovers. Redistribution is based on the auto redistribute property of the ServiceEngineGroup. Enum options -
        /// ACTIVE_STANDBY_SE_1, ACTIVE_STANDBY_SE_2.
        /// </summary>
        [JsonProperty(PropertyName = "active_standby_se_tag")]
        public string? ActiveStandbySeTag { get; set; }
        /// <summary>
        /// Keep advertising Virtual Service via BGP even if it is marked down by health monitor. This setting takes effect for
        /// future Virtual Service flaps. To advertise current VSes that are down, please disable and re-enable the Virtual Service.
        /// Field introduced in 20.1.1. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_down_vs")]
        public bool? AdvertiseDownVs { get; set; }
        /// <summary>
        /// Process request even if invalid client certificate is presented. Datascript APIs need to be used for processing of such
        /// requests. Field introduced in 18.2.3. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "allow_invalid_client_cert")]
        public bool? AllowInvalidClientCert { get; set; }
        /// <summary>
        /// Determines analytics settings for the application.
        /// </summary>
        [JsonProperty(PropertyName = "analytics_policy")]
        public NSXTALBAnalyticsPolicyType AnalyticsPolicy { get; set; }
        /// <summary>
        /// Specifies settings related to analytics. It is a reference to an object of type AnalyticsProfile.
        /// </summary>
        [JsonProperty(PropertyName = "analytics_profile_ref")]
        public string? AnalyticsProfileRef { get; set; }
        /// <summary>
        /// The name of the Contract/Graph associated with the Virtual Service. Should be in the <Contract name> <Graph name>
        /// format. This is applicable only for Service Integration mode with Cisco APIC Controller . Field deprecated in 21.1.1.
        /// Field introduced in 17.2.12,18.1.2. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apic_contract_graph")]
        public string? ApicContractGraph { get; set; }
        /// <summary>
        /// Enable application layer specific features for the Virtual Service. It is a reference to an object of type
        /// ApplicationProfile. Special default for Essentials edition is System-L4-Application.
        /// </summary>
        [JsonProperty(PropertyName = "application_profile_ref")]
        public string? ApplicationProfileRef { get; set; }
        /// <summary>
        /// Auto-allocate floating/elastic IP from the Cloud infrastructure. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_floating_ip")]
        public bool? AutoAllocateFloatingIp { get; set; }
        /// <summary>
        /// Auto-allocate VIP from the provided subnet. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_ip")]
        public bool? AutoAllocateIp { get; set; }
        /// <summary>
        /// Availability-zone to place the Virtual Service. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// (internal-use) FIP allocated by Avi in the Cloud infrastructure. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "avi_allocated_fip")]
        public bool? AviAllocatedFip { get; set; }
        /// <summary>
        /// (internal-use) VIP allocated by Avi in the Cloud infrastructure. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "avi_allocated_vip")]
        public bool? AviAllocatedVip { get; set; }
        /// <summary>
        /// (internal-use)Applicable for Azure only. Azure Availability set to which this VS is associated. Internally set by the
        /// cloud connector. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "azure_availability_set")]
        public string? AzureAvailabilitySet { get; set; }
        /// <summary>
        /// Select BGP peers, using peer label, for VsVip advertisement. Field introduced in 20.1.5. Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_peer_labels")]
        public IList<string> BgpPeerLabels { get; set; }
        /// <summary>
        /// Bot detection policy for the Virtual Service. It is a reference to an object of type BotDetectionPolicy. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "bot_policy_ref")]
        public string? BotPolicyRef { get; set; }
        /// <summary>
        /// (This is a beta feature). Sync Key-Value cache to the new SEs when VS is scaled out. For ex  SSL sessions are stored
        /// using VS's Key-Value cache. When the VS is scaled out, the SSL session information is synced to the new SE, allowing
        /// existing SSL sessions to be reused on the new SE. . Field introduced in 17.2.7, 18.1.1. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "bulk_sync_kvcache")]
        public bool? BulkSyncKvcache { get; set; }
        /// <summary>
        /// HTTP authentication configuration for protected resources. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_auth")]
        public NSXTALBHTTPClientAuthenticationParamsType ClientAuth { get; set; }
        /// <summary>
        /// close client connection on vs config update. Field introduced in 17.2.4. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "close_client_conn_on_config_update")]
        public bool? CloseClientConnOnConfigUpdate { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for VS. Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT. Allowed in
        /// Basic(Allowed values- CLOUD_NONE,CLOUD_NSXT) edition, Essentials(Allowed values- CLOUD_NONE,CLOUD_VCENTER) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_type")]
        public string? CloudType { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Rate limit the incoming connections to this virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "connections_rate_limit")]
        public NSXTALBRateProfileType ConnectionsRateLimit { get; set; }
        /// <summary>
        /// Profile used to match and rewrite strings in request and/or response body.
        /// </summary>
        [JsonProperty(PropertyName = "content_rewrite")]
        public NSXTALBContentRewriteProfileType ContentRewrite { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Select the algorithm for QoS fairness.  This determines how multiple Virtual Services sharing the same Service Engines
        /// will prioritize traffic over a congested network. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed
        /// values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "delay_fairness")]
        public bool? DelayFairness { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// (internal-use) Discovered networks providing reachability for client facing Virtual Service IP. This field is
        /// deprecated. It is a reference to an object of type Network. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_network_ref")]
        public IList<string> DiscoveredNetworkRef { get; set; }
        /// <summary>
        /// (internal-use) Discovered networks providing reachability for client facing Virtual Service IP. This field is used
        /// internally by Avi, not editable by the user. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_networks")]
        public IList<NSXTALBDiscoveredNetworkType> DiscoveredNetworks { get; set; }
        /// <summary>
        /// (internal-use) Discovered subnets providing reachability for client facing Virtual Service IP. This field is deprecated.
        /// Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_subnet")]
        public IList<NSXTALBIpAddrPrefixType> DiscoveredSubnet { get; set; }
        /// <summary>
        /// Service discovery specific data including fully qualified domain name, type and Time-To-Live of the DNS record. Note
        /// that only one of fqdn and dns_info setting is allowed. Maximum of 1000 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "dns_info")]
        public IList<NSXTALBDnsInfoType> DnsInfo { get; set; }
        /// <summary>
        /// DNS Policies applied on the dns traffic of the Virtual Service. Field introduced in 17.1.1. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dns_policies")]
        public IList<NSXTALBDnsPoliciesType> DnsPolicies { get; set; }
        /// <summary>
        /// Force placement on all SE's in service group (Mesos mode only). Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "east_west_placement")]
        public bool? EastWestPlacement { get; set; }
        /// <summary>
        /// Response traffic to clients will be sent back to the source MAC address of the connection, rather than statically sent
        /// to a default gateway. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition,
        /// Enterprise edition. Special default for Basic edition is false, Essentials edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "enable_autogw")]
        public bool? EnableAutogw { get; set; }
        /// <summary>
        /// Enable Route Health Injection using the BGP Config in the vrf context.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rhi")]
        public bool? EnableRhi { get; set; }
        /// <summary>
        /// Enable Route Health Injection for Source NAT'ted floating IP Address using the BGP Config in the vrf context.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rhi_snat")]
        public bool? EnableRhiSnat { get; set; }
        /// <summary>
        /// Enable or disable the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Error Page Profile to be used for this virtualservice.This profile is used to send the custom error page to the client
        /// generated by the proxy. It is a reference to an object of type ErrorPageProfile. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "error_page_profile_ref")]
        public string? ErrorPageProfileRef { get; set; }
        /// <summary>
        /// Floating IP to associate with this Virtual Service. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "floating_ip")]
        public NSXTALBIpAddrType FloatingIp { get; set; }
        /// <summary>
        /// If auto_allocate_floating_ip is True and more than one floating-ip subnets exist, then the subnet for the floating IP
        /// address allocation. This field is applicable only if the VirtualService belongs to an OpenStack or AWS cloud. In
        /// OpenStack or AWS cloud it is required when auto_allocate_floating_ip is selected. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "floating_subnet_uuid")]
        public string? FloatingSubnetUuid { get; set; }
        /// <summary>
        /// Criteria for flow distribution among SEs. Enum options - LOAD_AWARE, CONSISTENT_HASH_SOURCE_IP_ADDRESS,
        /// CONSISTENT_HASH_SOURCE_IP_ADDRESS_AND_PORT. Allowed in Basic(Allowed values- LOAD_AWARE) edition, Essentials(Allowed
        /// values- LOAD_AWARE) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "flow_dist")]
        public string? FlowDist { get; set; }
        /// <summary>
        /// Criteria for flow labelling. Enum options - NO_LABEL, APPLICATION_LABEL, SERVICE_LABEL.
        /// </summary>
        [JsonProperty(PropertyName = "flow_label_type")]
        public string? FlowLabelType { get; set; }
        /// <summary>
        /// DNS resolvable, fully qualified domain name of the virtualservice. Only one of 'fqdn' and 'dns_info' configuration is
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Translate the host name sent to the servers to this value.  Translate the host name sent from servers back to the value
        /// used by the client.
        /// </summary>
        [JsonProperty(PropertyName = "host_name_xlate")]
        public string? HostNameXlate { get; set; }
        /// <summary>
        /// HTTP Policies applied on the data traffic of the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "http_policies")]
        public IList<NSXTALBHTTPPoliciesType> HttpPolicies { get; set; }
        /// <summary>
        /// The config settings for the ICAP server when checking the HTTP request. It is a reference to an object of type
        /// IcapProfile. Field introduced in 20.1.1. Maximum of 1 items allowed. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "icap_request_profile_refs")]
        public IList<string> IcapRequestProfileRefs { get; set; }
        /// <summary>
        /// Ignore Pool servers network reachability constraints for Virtual Service placement.
        /// </summary>
        [JsonProperty(PropertyName = "ign_pool_net_reach")]
        public bool? IgnPoolNetReach { get; set; }
        /// <summary>
        /// IP Address of the Virtual Service. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// Subnet and/or Network for allocating VirtualService IP by IPAM Provider module. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ipam_network_subnet")]
        public NSXTALBIPNetworkSubnetType IpamNetworkSubnet { get; set; }
        /// <summary>
        /// Application-specific config for JWT validation. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_config")]
        public NSXTALBJWTValidationVsConfigType JwtConfig { get; set; }
        /// <summary>
        /// L4 Policies applied to the data traffic of the Virtual Service. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "l4_policies")]
        public IList<NSXTALBL4PoliciesType> L4Policies { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// Application-specific LDAP config. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ldap_vs_config")]
        public NSXTALBLDAPVSConfigType LdapVsConfig { get; set; }
        /// <summary>
        /// Limit potential DoS attackers who exceed max_cps_per_client significantly to a fraction of max_cps_per_client for a
        /// while.
        /// </summary>
        [JsonProperty(PropertyName = "limit_doser")]
        public bool? LimitDoser { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Maximum connections per second per client IP. Allowed values are 10-1000. Special values are 0- unlimited.
        /// </summary>
        [JsonProperty(PropertyName = "max_cps_per_client")]
        public int? MaxCpsPerClient { get; set; }
        /// <summary>
        /// Microservice representing the virtual service. It is a reference to an object of type MicroService.
        /// </summary>
        [JsonProperty(PropertyName = "microservice_ref")]
        public string? MicroserviceRef { get; set; }
        /// <summary>
        /// Minimum number of UP pools to mark VS up. Field introduced in 18.2.1, 17.2.12.
        /// </summary>
        [JsonProperty(PropertyName = "min_pools_up")]
        public int? MinPoolsUp { get; set; }
        /// <summary>
        /// Name for the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Determines network settings such as protocol, TCP or UDP, and related options for the protocol. It is a reference to an
        /// object of type NetworkProfile. Special default for Essentials edition is System-TCP-Fast-Path.
        /// </summary>
        [JsonProperty(PropertyName = "network_profile_ref")]
        public string? NetworkProfileRef { get; set; }
        /// <summary>
        /// Manually override the network on which the Virtual Service is placed. It is a reference to an object of type Network.
        /// Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        public string? NetworkRef { get; set; }
        /// <summary>
        /// Network security policies for the Virtual Service. It is a reference to an object of type NetworkSecurityPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "network_security_policy_ref")]
        public string? NetworkSecurityPolicyRef { get; set; }
        /// <summary>
        /// A list of NSX Groups representing the Clients which can access the Virtual IP of the Virtual Service. Field introduced
        /// in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_securitygroup")]
        public IList<string> NsxSecuritygroup { get; set; }
        /// <summary>
        /// VirtualService specific OAuth config. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "oauth_vs_config")]
        public NSXTALBOAuthVSConfigType OauthVsConfig { get; set; }
        /// <summary>
        /// Optional settings that determine performance limits like max connections or bandwdith etc.
        /// </summary>
        [JsonProperty(PropertyName = "performance_limits")]
        public NSXTALBPerformanceLimitsType PerformanceLimits { get; set; }
        /// <summary>
        /// The pool group is an object that contains pools. It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_ref")]
        public string? PoolGroupRef { get; set; }
        /// <summary>
        /// The pool is an object that contains destination servers and related attributes such as load-balancing and persistence.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// (internal-use) Network port assigned to the Virtual Service IP address. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "port_uuid")]
        public string? PortUuid { get; set; }
        /// <summary>
        /// Remove listening port if VirtualService is down.
        /// </summary>
        [JsonProperty(PropertyName = "remove_listening_port_on_vs_down")]
        public bool? RemoveListeningPortOnVsDown { get; set; }
        /// <summary>
        /// Rate limit the incoming requests to this virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "requests_rate_limit")]
        public NSXTALBRateProfileType RequestsRateLimit { get; set; }
        /// <summary>
        /// Application-specific SAML config. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "saml_sp_config")]
        public NSXTALBSAMLSPConfigType SamlSpConfig { get; set; }
        /// <summary>
        /// Disable re-distribution of flows across service engines for a virtual service. Enable if the network itself performs
        /// flow hashing with ECMP in environments such as GCP.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_ecmp")]
        public bool? ScaleoutEcmp { get; set; }
        /// <summary>
        /// The Service Engine Group to use for this Virtual Service. Moving to a new SE Group is disruptive to existing connections
        /// for this VS. It is a reference to an object of type ServiceEngineGroup.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        public string? SeGroupRef { get; set; }
        /// <summary>
        /// Security policy applied on the traffic of the Virtual Service. This policy is used to perform security actions such as
        /// Distributed Denial of Service (DDoS) attack mitigation, etc. It is a reference to an object of type SecurityPolicy.
        /// Field introduced in 18.2.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "security_policy_ref")]
        public string? SecurityPolicyRef { get; set; }
        /// <summary>
        /// Determines the network settings profile for the server side of TCP proxied connections.  Leave blank to use the same
        /// settings as the client to VS side of the connection. It is a reference to an object of type NetworkProfile.
        /// </summary>
        [JsonProperty(PropertyName = "server_network_profile_ref")]
        public string? ServerNetworkProfileRef { get; set; }
        /// <summary>
        /// Metadata pertaining to the Service provided by this virtual service. In Openshift/Kubernetes environments, egress pod
        /// info is stored. Any user input to this field will be overwritten by Avi Vantage.
        /// </summary>
        [JsonProperty(PropertyName = "service_metadata")]
        public string? ServiceMetadata { get; set; }
        /// <summary>
        /// Select pool based on destination port.
        /// </summary>
        [JsonProperty(PropertyName = "service_pool_select")]
        public IList<NSXTALBServicePoolSelectorType> ServicePoolSelect { get; set; }
        /// <summary>
        /// List of Services defined for this Virtual Service. Maximum of 2048 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<NSXTALBServiceType> Services { get; set; }
        /// <summary>
        /// Sideband configuration to be used for this virtualservice.It can be used for sending traffic to sideband VIPs for
        /// external inspection etc.
        /// </summary>
        [JsonProperty(PropertyName = "sideband_profile")]
        public NSXTALBSidebandProfileType SidebandProfile { get; set; }
        /// <summary>
        /// NAT'ted floating source IP Address(es) for upstream connection to servers. Maximum of 32 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "snat_ip")]
        public IList<NSXTALBIpAddrType> SnatIp { get; set; }
        /// <summary>
        /// GSLB pools used to manage site-persistence functionality. Each site-persistence pool contains the virtualservices in all
        /// the other sites, that is auto-generated by the GSLB manager. This is a read-only field for the user. It is a reference
        /// to an object of type Pool. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sp_pool_refs")]
        public IList<string> SpPoolRefs { get; set; }
        /// <summary>
        /// Select or create one or two certificates, EC and/or RSA, that will be presented to SSL/TLS terminated connections. It is
        /// a reference to an object of type SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_refs")]
        public IList<string> SslKeyAndCertificateRefs { get; set; }
        /// <summary>
        /// Determines the set of SSL versions and ciphers to accept for SSL/TLS terminated connections. It is a reference to an
        /// object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_ref")]
        public string? SslProfileRef { get; set; }
        /// <summary>
        /// Select SSL Profile based on client IP address match. Field introduced in 18.2.3. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_selectors")]
        public IList<NSXTALBSSLProfileSelectorType> SslProfileSelectors { get; set; }
        /// <summary>
        /// Expected number of SSL session cache entries (may be exceeded). Allowed values are 1024-16383.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_sess_cache_avg_size")]
        public int? SslSessCacheAvgSize { get; set; }
        /// <summary>
        /// Client Authentication and Authorization Policy for the virtualservice. Field deprecated in 18.2.3. Field introduced in
        /// 18.2.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sso_policy")]
        public NSXTALBSSOPolicyType SsoPolicy { get; set; }
        /// <summary>
        /// The SSO Policy attached to the virtualservice. It is a reference to an object of type SSOPolicy. Field introduced in
        /// 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sso_policy_ref")]
        public string? SsoPolicyRef { get; set; }
        /// <summary>
        /// List of static DNS records applied to this Virtual Service. These are static entries and no health monitoring is
        /// performed against the IP addresses. Maximum of 1000 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "static_dns_records")]
        public IList<NSXTALBDnsRecordType> StaticDnsRecords { get; set; }
        /// <summary>
        /// Subnet providing reachability for client facing Virtual Service IP. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// It represents subnet for the Virtual Service IP address allocation when auto_allocate_ip is True.It is only applicable
        /// in OpenStack or AWS cloud. This field is required if auto_allocate_ip is True. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_uuid")]
        public string? SubnetUuid { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Used for testing SE Datastore Upgrade 2.0 functionality. It is a reference to an object of type TestSeDatastoreLevel1.
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "test_se_datastore_level_1_ref")]
        public string? TestSeDatastoreLevel1Ref { get; set; }
        /// <summary>
        /// Topology Policies applied on the dns traffic of the Virtual Service based onGSLB Topology algorithm. Field introduced in
        /// 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "topology_policies")]
        public IList<NSXTALBDnsPoliciesType> TopologyPolicies { get; set; }
        /// <summary>
        /// Server network or list of servers for cloning traffic. It is a reference to an object of type TrafficCloneProfile. Field
        /// introduced in 17.1.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_clone_profile_ref")]
        public string? TrafficCloneProfileRef { get; set; }
        /// <summary>
        /// Knob to enable the Virtual Service traffic on its assigned service engines. This setting is effective only when the
        /// enabled flag is set to True. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_enabled")]
        public bool? TrafficEnabled { get; set; }
        /// <summary>
        /// Specify if this is a normal Virtual Service, or if it is the parent or child of an SNI-enabled virtual hosted Virtual
        /// Service. Enum options - VS_TYPE_NORMAL, VS_TYPE_VH_PARENT, VS_TYPE_VH_CHILD. Allowed in Basic(Allowed values-
        /// VS_TYPE_NORMAL,VS_TYPE_VH_PARENT) edition, Essentials(Allowed values- VS_TYPE_NORMAL) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Use Bridge IP as VIP on each Host in Mesos deployments. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "use_bridge_ip_as_vip")]
        public bool? UseBridgeIpAsVip { get; set; }
        /// <summary>
        /// Use the Virtual IP as the SNAT IP for health monitoring and sending traffic to the backend servers instead of the
        /// Service Engine interface IP. The caveat of enabling this option is that the VirtualService cannot be configued in an
        /// Active-Active HA mode. DNS based Multi VIP solution has to be used for HA & Non-disruptive Upgrade purposes. Field
        /// introduced in 17.1.9,17.2.3. Allowed in Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "use_vip_as_snat")]
        public bool? UseVipAsSnat { get; set; }
        /// <summary>
        /// UUID of the VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// The exact name requested from the client's SNI-enabled TLS hello domain name field. If this is a match, the parent VS
        /// will forward the connection to this child VS.
        /// </summary>
        [JsonProperty(PropertyName = "vh_domain_name")]
        public IList<string> VhDomainName { get; set; }
        /// <summary>
        /// Host and path match criteria to select this child VS. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vh_matches")]
        public IList<NSXTALBVHMatchType> VhMatches { get; set; }
        /// <summary>
        /// Specifies the Virtual Service acting as Virtual Hosting (SNI) parent. It is a reference to an object of type
        /// VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vh_parent_vs_ref")]
        public string? VhParentVsRef { get; set; }
        /// <summary>
        /// Specify if the Virtual Hosting VS is of type SNI or Enhanced. Enum options - VS_TYPE_VH_SNI, VS_TYPE_VH_ENHANCED. Field
        /// introduced in 20.1.3. Allowed in Basic(Allowed values- VS_TYPE_VH_ENHANCED) edition, Enterprise edition. Special default
        /// for Basic edition is VS_TYPE_VH_ENHANCED, Enterprise is VS_TYPE_VH_SNI.
        /// </summary>
        [JsonProperty(PropertyName = "vh_type")]
        public string? VhType { get; set; }
        /// <summary>
        /// List of Virtual Service IPs. While creating a 'Shared VS',please use vsvip_ref to point to the shared entities. Field
        /// introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public IList<NSXTALBVipType> Vip { get; set; }
        /// <summary>
        /// Virtual Routing Context that the Virtual Service is bound to. This is used to provide the isolation of the set of
        /// networks the application is attached to. It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_context_ref")]
        public string? VrfContextRef { get; set; }
        /// <summary>
        /// Datascripts applied on the data traffic of the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "vs_datascripts")]
        public IList<NSXTALBVSDataScriptsType> VsDatascripts { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for VsVip. Internally set by cloud connector. Field introduced in 17.2.9, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "vsvip_cloud_config_cksum")]
        public string? VsvipCloudConfigCksum { get; set; }
        /// <summary>
        /// Mostly used during the creation of Shared VS, this field refers to entities that can be shared across Virtual Services.
        /// It is a reference to an object of type VsVip. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vsvip_ref")]
        public string? VsvipRef { get; set; }
        /// <summary>
        /// WAF policy for the Virtual Service. It is a reference to an object of type WafPolicy. Field introduced in 17.2.1.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "waf_policy_ref")]
        public string? WafPolicyRef { get; set; }
        /// <summary>
        /// The Quality of Service weight to assign to traffic transmitted from this Virtual Service.  A higher weight will
        /// prioritize traffic versus other Virtual Services sharing the same Service Engines. Allowed values are 1-128. Allowed in
        /// Basic(Allowed values- 1) edition, Essentials(Allowed values- 1) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }
    }
}
