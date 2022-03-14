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
    public class NSXTALBServiceEngineGroupType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Enable accelerated networking option for Azure SE. Accelerated networking enables single root I/O virtualization
        /// (SR-IOV) to a SE VM. This improves networking performance. Field introduced in 17.2.14,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "accelerated_networking")]
        public bool? AcceleratedNetworking { get; set; }
        /// <summary>
        /// Service Engines in active/standby mode for HA failover.
        /// </summary>
        [JsonProperty(PropertyName = "active_standby")]
        public bool? ActiveStandby { get; set; }
        /// <summary>
        /// Indicates the percent of config memory used for config updates. Allowed values are 0-90. Field deprecated in 18.1.2.
        /// Field introduced in 18.1.1. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "additional_config_memory")]
        public int? AdditionalConfigMemory { get; set; }
        /// <summary>
        /// Advertise reach-ability of backend server networks via ADC through BGP for default gateway feature. Field deprecated in
        /// 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_backend_networks")]
        public bool? AdvertiseBackendNetworks { get; set; }
        /// <summary>
        /// Enable aggressive failover configuration for ha. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed
        /// values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "aggressive_failure_detection")]
        public bool? AggressiveFailureDetection { get; set; }
        /// <summary>
        /// In compact placement, Virtual Services are placed on existing SEs until max_vs_per_se limit is reached. Enum options -
        /// PLACEMENT_ALGO_PACKED, PLACEMENT_ALGO_DISTRIBUTED.
        /// </summary>
        [JsonProperty(PropertyName = "algo")]
        public string? Algo { get; set; }
        /// <summary>
        /// Allow SEs to be created using burst license. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "allow_burst")]
        public bool? AllowBurst { get; set; }
        /// <summary>
        /// A percent value of total SE memory reserved for applicationcaching. This is an SE bootup property and requires SE
        /// restart.Requires SE Reboot. Allowed values are 0 - 100. Special values are 0- disable. Field introduced in 18.2.3. Unit
        /// is PERCENT. Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// Special default for Basic edition is 0, Essentials edition is 0, Enterprise is 10.
        /// </summary>
        [JsonProperty(PropertyName = "app_cache_percent")]
        public int? AppCachePercent { get; set; }
        /// <summary>
        /// The max memory that can be allocated for the app cache. This value will act as an upper bound on the cache size
        /// specified in app_cache_percent. Special values are 0- disable. Field introduced in 20.1.1. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "app_cache_threshold")]
        public int? AppCacheThreshold { get; set; }
        /// <summary>
        /// A percent value of total SE memory reserved for Application learning. This is an SE bootup property and requires SE
        /// restart. Allowed values are 0 - 10. Field introduced in 18.2.3. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "app_learning_memory_percent")]
        public int? AppLearningMemoryPercent { get; set; }
        /// <summary>
        /// Amount of SE memory in GB until which shared memory is collected in core archive. Field introduced in 17.1.3. Unit is
        /// GB.
        /// </summary>
        [JsonProperty(PropertyName = "archive_shm_limit")]
        public int? ArchiveShmLimit { get; set; }
        /// <summary>
        /// SSL handshakes will be handled by dedicated SSL Threads.Requires SE Reboot. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "async_ssl")]
        public bool? AsyncSsl { get; set; }
        /// <summary>
        /// Number of Async SSL threads per se_dp.Requires SE Reboot. Allowed values are 1-16.
        /// </summary>
        [JsonProperty(PropertyName = "async_ssl_threads")]
        public int? AsyncSslThreads { get; set; }
        /// <summary>
        /// If set, Virtual Services will be automatically migrated when load on an SE is less than minimum or more than maximum
        /// thresholds. Only Alerts are generated when the auto_rebalance is not set. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "auto_rebalance")]
        public bool? AutoRebalance { get; set; }
        /// <summary>
        /// Capacities of SE for auto rebalance for each criteria. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "auto_rebalance_capacity_per_se")]
        public int? AutoRebalanceCapacityPerSe { get; set; }
        /// <summary>
        /// Set of criteria for SE Auto Rebalance. Enum options - SE_AUTO_REBALANCE_CPU, SE_AUTO_REBALANCE_PPS,
        /// SE_AUTO_REBALANCE_MBPS, SE_AUTO_REBALANCE_OPEN_CONNS, SE_AUTO_REBALANCE_CPS. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "auto_rebalance_criteria")]
        public IList<string> AutoRebalanceCriteria { get; set; }
        /// <summary>
        /// Frequency of rebalance, if 'Auto rebalance' is enabled. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "auto_rebalance_interval")]
        public int? AutoRebalanceInterval { get; set; }
        /// <summary>
        /// Redistribution of virtual services from the takeover SE to the replacement SE can cause momentary traffic loss. If the
        /// auto-redistribute load option is left in its default off state, any desired rebalancing requires calls to REST API.
        /// Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "auto_redistribute_active_standby_load")]
        public bool? AutoRedistributeActiveStandbyLoad { get; set; }
        /// <summary>
        /// Availability zones for Virtual Service High Availability. It is a reference to an object of type AvailabilityZone. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone_refs")]
        public IList<string> AvailabilityZoneRefs { get; set; }
        /// <summary>
        /// Control if dispatcher core also handles TCP flows in baremetal SE. Field introduced in 21.1.3. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "baremetal_dispatcher_handles_flows")]
        public bool? BaremetalDispatcherHandlesFlows { get; set; }
        /// <summary>
        /// Enable BGP peer monitoring based failover. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_peer_monitor_failover_enabled")]
        public bool? BgpPeerMonitorFailoverEnabled { get; set; }
        /// <summary>
        /// BGP peer state update interval. Allowed values are 5-100. Field introduced in 17.2.14,18.1.5,18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_state_update_interval")]
        public int? BgpStateUpdateInterval { get; set; }
        /// <summary>
        /// Excess Service Engine capacity provisioned for HA failover.
        /// </summary>
        [JsonProperty(PropertyName = "buffer_se")]
        public int? BufferSe { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Compress IP rules into a single subnet based IP rule for each north-south IPAM subnet configured in PCAP mode in
        /// OpenShift/Kubernetes node. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "compress_ip_rules_for_each_ns_subnet")]
        public bool? CompressIpRulesForEachNsSubnet { get; set; }
        /// <summary>
        /// Enable config debugs on all cores of SE. Field introduced in 17.2.13,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "config_debugs_on_all_cores")]
        public bool? ConfigDebugsOnAllCores { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Percentage of memory for connection state. This will come at the expense of memory used for HTTP in-memory cache.
        /// Allowed values are 10-90. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "connection_memory_percentage")]
        public int? ConnectionMemoryPercentage { get; set; }
        /// <summary>
        /// Include shared memory for app cache in core file.Requires SE Reboot. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "core_shm_app_cache")]
        public bool? CoreShmAppCache { get; set; }
        /// <summary>
        /// Include shared memory for app learning in core file.Requires SE Reboot. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "core_shm_app_learning")]
        public bool? CoreShmAppLearning { get; set; }
        /// <summary>
        /// Placeholder for description of property cpu_reserve of obj type ServiceEngineGroup field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "cpu_reserve")]
        public bool? CpuReserve { get; set; }
        /// <summary>
        /// Allocate all the CPU cores for the Service Engine Virtual Machines  on the same CPU socket. Applicable only for vCenter
        /// Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_socket_affinity")]
        public bool? CpuSocketAffinity { get; set; }
        /// <summary>
        /// Custom Security Groups to be associated with data vNics for SE instances in OpenStack and AWS Clouds. Field introduced
        /// in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "custom_securitygroups_data")]
        public IList<string> CustomSecuritygroupsData { get; set; }
        /// <summary>
        /// Custom Security Groups to be associated with management vNic for SE instances in OpenStack and AWS Clouds. Field
        /// introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "custom_securitygroups_mgmt")]
        public IList<string> CustomSecuritygroupsMgmt { get; set; }
        /// <summary>
        /// Custom tag will be used to create the tags for SE instance in AWS. Note this is not the same as the prefix for SE name.
        /// </summary>
        [JsonProperty(PropertyName = "custom_tag")]
        public IList<NSXTALBCustomTagType> CustomTag { get; set; }
        /// <summary>
        /// Subnet used to spin up the data nic for Service Engines, used only for Azure cloud. Overrides the cloud level setting
        /// for Service Engine subnet. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "data_network_id")]
        public string? DataNetworkId { get; set; }
        /// <summary>
        /// Number of instructions before datascript times out. Allowed values are 0-100000000. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "datascript_timeout")]
        public long? DatascriptTimeout { get; set; }
        /// <summary>
        /// If activated, IPv6 address and route discovery are deactivated.Requires SE reboot. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "deactivate_ipv6_discovery")]
        public bool? DeactivateIpv6Discovery { get; set; }
        /// <summary>
        /// Deactivate filtering of packets to KNI interface. To be used under surveillance of Avi Support. Field introduced in
        /// 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "deactivate_kni_filtering_at_dispatcher")]
        public bool? DeactivateKniFilteringAtDispatcher { get; set; }
        /// <summary>
        /// Dedicate the core that handles packet receive/transmit from the network to just the dispatching function. Don't use it
        /// for TCP/IP and SSL functions.
        /// </summary>
        [JsonProperty(PropertyName = "dedicated_dispatcher_core")]
        public bool? DedicatedDispatcherCore { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// By default, Avi creates and manages security groups along with custom sg provided by user. Set this to True to disallow
        /// Avi to create and manage new security groups. Avi will only make use of custom security groups provided by user. This
        /// option is supported for AWS and OpenStack cloud types. Field introduced in 17.2.13,18.1.4,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_avi_securitygroups")]
        public bool? DisableAviSecuritygroups { get; set; }
        /// <summary>
        /// Stop using TCP/UDP and IP checksum offload features of NICs. Field introduced in 17.1.14, 17.2.5, 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_csum_offloads")]
        public bool? DisableCsumOffloads { get; set; }
        /// <summary>
        /// Disable Flow Probes for Scaled out VS'es. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "disable_flow_probes")]
        public bool? DisableFlowProbes { get; set; }
        /// <summary>
        /// Disable Generic Receive Offload (GRO) in DPDK poll-mode driver packet receive path.  GRO is on by default on NICs that
        /// do not support LRO (Large Receive Offload) or do not gain performance boost from LRO. Field introduced in 17.2.5,
        /// 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_gro")]
        public bool? DisableGro { get; set; }
        /// <summary>
        /// If set, disable the config memory check done in service engine. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "disable_se_memory_check")]
        public bool? DisableSeMemoryCheck { get; set; }
        /// <summary>
        /// Disable TCP Segmentation Offload (TSO) in DPDK poll-mode driver packet transmit path. TSO is on by default on NICs that
        /// support it. Field introduced in 17.2.5, 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_tso")]
        public bool? DisableTso { get; set; }
        /// <summary>
        /// Amount of disk space for each of the Service Engine virtual machines. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "disk_per_se")]
        public int? DiskPerSe { get; set; }
        /// <summary>
        /// Use both the active and standby Service Engines for Virtual Service placement in the legacy active standby HA mode.
        /// Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "distribute_load_active_standby")]
        public bool? DistributeLoadActiveStandby { get; set; }
        /// <summary>
        /// Distributes queue ownership among cores so multiple cores handle dispatcher duties. Requires SE Reboot. Deprecated from
        /// 18.2.8, instead use max_queues_per_vnic. Field introduced in 17.2.8. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "distribute_queues")]
        public bool? DistributeQueues { get; set; }
        /// <summary>
        /// Distributes vnic ownership among cores so multiple cores handle dispatcher duties.Requires SE Reboot. Field introduced
        /// in 18.2.5. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "distribute_vnics")]
        public bool? DistributeVnics { get; set; }
        /// <summary>
        /// Timeout for downstream to become writable. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "downstream_send_timeout")]
        public int? DownstreamSendTimeout { get; set; }
        /// <summary>
        /// Dequeue interval for receive queue from se_dp in aggressive mode. Allowed values are 1-1000. Field introduced in 21.1.1.
        /// Unit is MILLISECONDS. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_deq_interval_msec")]
        public int? DpAggressiveDeqIntervalMsec { get; set; }
        /// <summary>
        /// Enqueue interval for request queue to se_dp in aggressive mode. Allowed values are 1-1000. Field introduced in 21.1.1.
        /// Unit is MILLISECONDS. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_enq_interval_msec")]
        public int? DpAggressiveEnqIntervalMsec { get; set; }
        /// <summary>
        /// Frequency of SE - SE HB messages when aggressive failure mode detection is enabled. Field introduced in 20.1.3. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_hb_frequency")]
        public int? DpAggressiveHbFrequency { get; set; }
        /// <summary>
        /// Consecutive HB failures after which failure is reported to controller,when aggressive failure mode detection is enabled.
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_hb_timeout_count")]
        public int? DpAggressiveHbTimeoutCount { get; set; }
        /// <summary>
        /// Dequeue interval for receive queue from se_dp. Allowed values are 1-1000. Field introduced in 21.1.1. Unit is
        /// MILLISECONDS. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dp_deq_interval_msec")]
        public int? DpDeqIntervalMsec { get; set; }
        /// <summary>
        /// Enqueue interval for request queue to se_dp. Allowed values are 1-1000. Field introduced in 21.1.1. Unit is
        /// MILLISECONDS. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dp_enq_interval_msec")]
        public int? DpEnqIntervalMsec { get; set; }
        /// <summary>
        /// Frequency of SE - SE HB messages when aggressive failure mode detection is not enabled. Field introduced in 20.1.3. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dp_hb_frequency")]
        public int? DpHbFrequency { get; set; }
        /// <summary>
        /// Consecutive HB failures after which failure is reported to controller, when aggressive failure mode detection is not
        /// enabled. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "dp_hb_timeout_count")]
        public int? DpHbTimeoutCount { get; set; }
        /// <summary>
        /// Enable GratArp for VIP_IP. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_gratarp_permanent")]
        public bool? EnableGratarpPermanent { get; set; }
        /// <summary>
        /// Enable HSM luna engine logs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_hsm_log")]
        public bool? EnableHsmLog { get; set; }
        /// <summary>
        /// (This is a beta feature). Enable HSM key priming. If enabled, key handles on the hsm will be synced to SE before
        /// processing client connections. Field introduced in 17.2.7, 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_hsm_priming")]
        public bool? EnableHsmPriming { get; set; }
        /// <summary>
        /// Applicable only for Azure cloud with Basic SKU LB. If set, additional Azure LBs will be automatically created if
        /// resources in existing LB are exhausted. Field introduced in 17.2.10, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "enable_multi_lb")]
        public bool? EnableMultiLb { get; set; }
        /// <summary>
        /// Enable TX ring support in pcap mode of operation. TSO feature is not supported with TX Ring enabled. Deprecated from
        /// 18.2.8, instead use pcap_tx_mode. Requires SE Reboot. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable_pcap_tx_ring")]
        public bool? EnablePcapTxRing { get; set; }
        /// <summary>
        /// Enable routing for this ServiceEngineGroup . Field deprecated in 18.2.5. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_routing")]
        public bool? EnableRouting { get; set; }
        /// <summary>
        /// Enable VIP on all interfaces of SE. Field deprecated in 18.2.5. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vip_on_all_interfaces")]
        public bool? EnableVipOnAllInterfaces { get; set; }
        /// <summary>
        /// Use Virtual MAC address for interfaces on which floating interface IPs are placed. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vmac")]
        public bool? EnableVmac { get; set; }
        /// <summary>
        /// End local ephemeral port number for outbound connections. Field introduced in 17.2.13, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "ephemeral_portrange_end")]
        public int? EphemeralPortrangeEnd { get; set; }
        /// <summary>
        /// Start local ephemeral port number for outbound connections. Field introduced in 17.2.13, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "ephemeral_portrange_start")]
        public int? EphemeralPortrangeStart { get; set; }
        /// <summary>
        /// Multiplier for extra config to support large VS/Pool config.
        /// </summary>
        [JsonProperty(PropertyName = "extra_config_multiplier")]
        public double? ExtraConfigMultiplier { get; set; }
        /// <summary>
        /// Extra config memory to support large Geo DB configuration. Field introduced in 17.1.1. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "extra_shared_config_memory")]
        public int? ExtraSharedConfigMemory { get; set; }
        /// <summary>
        /// If ServiceEngineGroup is configured for Legacy 1+1 Active Standby HA Mode, Floating IP's will be advertised only by the
        /// Active SE in the Pair. Virtual Services in this group must be disabled/enabled for any changes to the Floating IP's to
        /// take effect. Only active SE hosting VS tagged with Active Standby SE 1 Tag will advertise this floating IP when manual
        /// load distribution is enabled. Field deprecated in 18.2.5. Maximum of 32 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "floating_intf_ip")]
        public IList<NSXTALBIpAddrType> FloatingIntfIp { get; set; }
        /// <summary>
        /// If ServiceEngineGroup is configured for Legacy 1+1 Active Standby HA Mode, Floating IP's will be advertised only by the
        /// Active SE in the Pair. Virtual Services in this group must be disabled/enabled for any changes to the Floating IP's to
        /// take effect. Only active SE hosting VS tagged with Active Standby SE 2 Tag will advertise this floating IP when manual
        /// load distribution is enabled. Field deprecated in 18.2.5. Maximum of 32 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "floating_intf_ip_se_2")]
        public IList<NSXTALBIpAddrType> FloatingIntfIpSe2 { get; set; }
        /// <summary>
        /// Maximum number of flow table entries that have not completed TCP three-way handshake yet. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_table_new_syn_max_entries")]
        public int? FlowTableNewSynMaxEntries { get; set; }
        /// <summary>
        /// Number of entries in the free list. Field introduced in 17.2.10, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "free_list_size")]
        public int? FreeListSize { get; set; }
        /// <summary>
        /// Google Cloud Platform, Service Engine Group Configuration. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gcp_config")]
        public NSXTALBGCPSeGroupConfigType GcpConfig { get; set; }
        /// <summary>
        /// GratArp periodicity for VIP-IP. Allowed values are 5-30. Field introduced in 18.2.3. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "gratarp_permanent_periodicity")]
        public int? GratarpPermanentPeriodicity { get; set; }
        /// <summary>
        /// High Availability mode for all the Virtual Services using this Service Engine group. Enum options - HA_MODE_SHARED_PAIR,
        /// HA_MODE_SHARED, HA_MODE_LEGACY_ACTIVE_STANDBY. Allowed in Basic(Allowed values- HA_MODE_LEGACY_ACTIVE_STANDBY) edition,
        /// Essentials(Allowed values- HA_MODE_LEGACY_ACTIVE_STANDBY) edition, Enterprise edition. Special default for Basic edition
        /// is HA_MODE_LEGACY_ACTIVE_STANDBY, Essentials edition is HA_MODE_LEGACY_ACTIVE_STANDBY, Enterprise is HA_MODE_SHARED.
        /// </summary>
        [JsonProperty(PropertyName = "ha_mode")]
        public string? HaMode { get; set; }
        /// <summary>
        /// Configuration to handle per packet attack handling.For example, DNS Reflection Attack is a type of attack where a
        /// response packet is sent to the DNS VS.This configuration tells if such packets should be dropped without further
        /// processing. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "handle_per_pkt_attack")]
        public bool? HandlePerPktAttack { get; set; }
        /// <summary>
        /// It is a reference to an object of type HardwareSecurityModuleGroup.
        /// </summary>
        [JsonProperty(PropertyName = "hardwaresecuritymodulegroup_ref")]
        public string? HardwaresecuritymodulegroupRef { get; set; }
        /// <summary>
        /// Minimum required heap memory to apply any configuration. Allowed values are 0-100. Field introduced in 18.1.2. Unit is
        /// MB.
        /// </summary>
        [JsonProperty(PropertyName = "heap_minimum_config_memory")]
        public int? HeapMinimumConfigMemory { get; set; }
        /// <summary>
        /// Enable active health monitoring from the standby SE for all placed virtual services. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition. Special default for Basic edition is
        /// false, Essentials edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "hm_on_standby")]
        public bool? HmOnStandby { get; set; }
        /// <summary>
        /// Key of a (Key, Value) pair identifying a label for a set of Nodes usually in Container Clouds. Needs to be specified
        /// together with host_attribute_value. SEs can be configured differently including HA modes across different SE Groups. May
        /// also be used for isolation between different classes of VirtualServices. VirtualServices' SE Group may be specified via
        /// annotations/labels. A OpenShift/Kubernetes namespace maybe annotated with a matching SE Group label as
        /// openshift.io/node-selector  apptype=prod. When multiple SE Groups are used in a Cloud with host attributes
        /// specified,just a single SE Group can exist as a match-all SE Group without a host_attribute_key.
        /// </summary>
        [JsonProperty(PropertyName = "host_attribute_key")]
        public string? HostAttributeKey { get; set; }
        /// <summary>
        /// Value of a (Key, Value) pair identifying a label for a set of Nodes usually in Container Clouds. Needs to be specified
        /// together with host_attribute_key.
        /// </summary>
        [JsonProperty(PropertyName = "host_attribute_value")]
        public string? HostAttributeValue { get; set; }
        /// <summary>
        /// Enable the host gateway monitor when service engine is deployed as docker container. Disabled by default. Field
        /// introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "host_gateway_monitor")]
        public bool? HostGatewayMonitor { get; set; }
        /// <summary>
        /// Enable Javascript console logs on the client browser when collecting client insights. Field introduced in 21.1.1.
        /// Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "http_rum_console_log")]
        public bool? HttpRumConsoleLog { get; set; }
        /// <summary>
        /// Minimum response size content length to sample for client insights. Field introduced in 21.1.1. Allowed in Basic(Allowed
        /// values- 64) edition, Essentials(Allowed values- 64) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "http_rum_min_content_length")]
        public int? HttpRumMinContentLength { get; set; }
        /// <summary>
        /// Toggles SE hybrid only mode of operation in DPDK mode with RSS configured;where-in each SE datapath instance operates as
        /// an independent standalonehybrid instance performing both dispatcher and proxy function. Requires reboot. Field
        /// introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "hybrid_rss_mode")]
        public bool? HybridRssMode { get; set; }
        /// <summary>
        /// Override default hypervisor. Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor")]
        public string? Hypervisor { get; set; }
        /// <summary>
        /// Ignore docker mac change. Field introduced in 21.1.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_docker_mac_change")]
        public bool? IgnoreDockerMacChange { get; set; }
        /// <summary>
        /// Ignore RTT samples if it is above threshold. Field introduced in 17.1.6,17.2.2. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_rtt_threshold")]
        public int? IgnoreRttThreshold { get; set; }
        /// <summary>
        /// Program SE security group ingress rules to allow VIP data access from remote CIDR type. Enum options -
        /// SG_INGRESS_ACCESS_NONE, SG_INGRESS_ACCESS_ALL, SG_INGRESS_ACCESS_VPC. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "ingress_access_data")]
        public string? IngressAccessData { get; set; }
        /// <summary>
        /// Program SE security group ingress rules to allow SSH/ICMP management access from remote CIDR type. Enum options -
        /// SG_INGRESS_ACCESS_NONE, SG_INGRESS_ACCESS_ALL, SG_INGRESS_ACCESS_VPC. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "ingress_access_mgmt")]
        public string? IngressAccessMgmt { get; set; }
        /// <summary>
        /// Instance/Flavor name for SE instance.
        /// </summary>
        [JsonProperty(PropertyName = "instance_flavor")]
        public string? InstanceFlavor { get; set; }
        /// <summary>
        /// Additional information associated with instance_flavor. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "instance_flavor_info")]
        public NSXTALBCloudFlavorType InstanceFlavorInfo { get; set; }
        /// <summary>
        /// Iptable Rules. Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "iptables")]
        public IList<NSXTALBIptableRuleSetType> Iptables { get; set; }
        /// <summary>
        /// Port ranges for any servers running in inband LinuxServer clouds. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "kni_allowed_server_ports")]
        public IList<NSXTALBKniPortRangeType> KniAllowedServerPorts { get; set; }
        /// <summary>
        /// Number of L7 connections that can be cached per core. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "l7_conns_per_core")]
        public int? L7ConnsPerCore { get; set; }
        /// <summary>
        /// Number of reserved L7 listener connections per core. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "l7_resvd_listen_conns_per_core")]
        public int? L7ResvdListenConnsPerCore { get; set; }
        /// <summary>
        /// Labels associated with this SE group. Field introduced in 20.1.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// Number of requests to dispatch from the request. queue at a regular interval. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "lbaction_num_requests_to_dispatch")]
        public int? LbactionNumRequestsToDispatch { get; set; }
        /// <summary>
        /// Maximum retries per request in the request queue. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "lbaction_rq_per_request_max_retries")]
        public int? LbactionRqPerRequestMaxRetries { get; set; }
        /// <summary>
        /// Select core with least load for new flow.
        /// </summary>
        [JsonProperty(PropertyName = "least_load_core_selection")]
        public bool? LeastLoadCoreSelection { get; set; }
        /// <summary>
        /// Specifies the license tier which would be used. This field by default inherits the value from cloud. Enum options -
        /// ENTERPRISE_16, ENTERPRISE, ENTERPRISE_18, BASIC, ESSENTIALS, ENTERPRISE_WITH_CLOUD_SERVICES. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "license_tier")]
        public string? LicenseTier { get; set; }
        /// <summary>
        /// If no license type is specified then default license enforcement for the cloud type is chosen. Enum options -
        /// LIC_BACKEND_SERVERS, LIC_SOCKETS, LIC_CORES, LIC_HOSTS, LIC_SE_BANDWIDTH, LIC_METERED_SE_BANDWIDTH. Field introduced in
        /// 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "license_type")]
        public string? LicenseType { get; set; }
        /// <summary>
        /// Flag to indicate if log files are compressed upon full on the Service Engine. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_compress_logs")]
        public bool? LogAgentCompressLogs { get; set; }
        /// <summary>
        /// Enable debug logs by default on Service Engine. This includes all other debugging logs. Debug logs can also be explcitly
        /// enabled from the CLI shell. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_debug_enabled")]
        public bool? LogAgentDebugEnabled { get; set; }
        /// <summary>
        /// Maximum application log file size before rollover. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_appl")]
        public int? LogAgentFileSzAppl { get; set; }
        /// <summary>
        /// Maximum connection log file size before rollover. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_conn")]
        public int? LogAgentFileSzConn { get; set; }
        /// <summary>
        /// Maximum debug log file size before rollover. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_debug")]
        public int? LogAgentFileSzDebug { get; set; }
        /// <summary>
        /// Maximum event log file size before rollover. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_event")]
        public int? LogAgentFileSzEvent { get; set; }
        /// <summary>
        /// Minimum storage allocated for logs irrespective of memory and cores. Field introduced in 21.1.1. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_log_storage_min_sz")]
        public int? LogAgentLogStorageMinSz { get; set; }
        /// <summary>
        /// Maximum concurrent rsync requests initiated from log-agent to the Controller. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_concurrent_rsync")]
        public int? LogAgentMaxConcurrentRsync { get; set; }
        /// <summary>
        /// Excess percentage threshold of disk size to trigger cleanup of logs on the Service Engine. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_storage_excess_percent")]
        public int? LogAgentMaxStorageExcessPercent { get; set; }
        /// <summary>
        /// Maximum storage on the disk not allocated for logs on the Service Engine. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_storage_ignore_percent")]
        public double? LogAgentMaxStorageIgnorePercent { get; set; }
        /// <summary>
        /// Minimum storage allocated to any given VirtualService on the Service Engine. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_min_storage_per_vs")]
        public int? LogAgentMinStoragePerVs { get; set; }
        /// <summary>
        /// Internal timer to stall log-agent and prevent it from hogging CPU cycles on the Service Engine. Field introduced in
        /// 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_sleep_interval")]
        public int? LogAgentSleepInterval { get; set; }
        /// <summary>
        /// Enable trace logs by default on Service Engine. Configuration operations are logged along with other important logs by
        /// Service Engine. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_trace_enabled")]
        public bool? LogAgentTraceEnabled { get; set; }
        /// <summary>
        /// Timeout to purge unknown Virtual Service logs from the Service Engine. Field introduced in 21.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_unknown_vs_timer")]
        public int? LogAgentUnknownVsTimer { get; set; }
        /// <summary>
        /// Maximum disk capacity (in MB) to be allocated to an SE. This is exclusively used for debug and log data. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "log_disksz")]
        public int? LogDisksz { get; set; }
        /// <summary>
        /// SE will log memory allocation related failure to the se_trace file, wherever available. Field introduced in 20.1.2.
        /// Allowed in Basic(Allowed values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "log_malloc_failure")]
        public bool? LogMallocFailure { get; set; }
        /// <summary>
        /// Maximum number of file names in a log message. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_message_max_file_list_size")]
        public int? LogMessageMaxFileListSize { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.7. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Maximum number of external health monitors that can run concurrently in a service engine. This helps control the CPU and
        /// memory use by external health monitors. Special values are 0- Value will be internally calculated based on cpu and
        /// memory. Field introduced in 18.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_external_hm")]
        public int? MaxConcurrentExternalHm { get; set; }
        /// <summary>
        /// When CPU usage on an SE exceeds this threshold, Virtual Services hosted on this SE may be rebalanced to other SEs to
        /// reduce load. A new SE may be created as part of this process. Allowed values are 40-90. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "max_cpu_usage")]
        public int? MaxCpuUsage { get; set; }
        /// <summary>
        /// Max bytes that can be allocated in a single mempool. Field introduced in 18.1.5. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "max_memory_per_mempool")]
        public int? MaxMemoryPerMempool { get; set; }
        /// <summary>
        /// Configures the maximum number of se_dp processes that handles traffic. If not configured, defaults to the number of CPUs
        /// on the SE. If decreased, it will only take effect after SE reboot. Allowed values are 1-128. Field introduced in 20.1.1.
        /// Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "max_num_se_dps")]
        public int? MaxNumSeDps { get; set; }
        /// <summary>
        /// Applicable to Azure platform only. Maximum number of public IPs per Azure LB. . Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "max_public_ips_per_lb")]
        public int? MaxPublicIpsPerLb { get; set; }
        /// <summary>
        /// Maximum number of queues per vnic Setting to '0' utilises all queues that are distributed across dispatcher cores.
        /// Allowed values are 0,1,2,4,8,16. Field introduced in 18.2.7, 20.1.1. Allowed in Basic(Allowed values- 1) edition,
        /// Essentials(Allowed values- 1) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "max_queues_per_vnic")]
        public int? MaxQueuesPerVnic { get; set; }
        /// <summary>
        /// Applicable to Azure platform only. Maximum number of rules per Azure LB. . Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "max_rules_per_lb")]
        public int? MaxRulesPerLb { get; set; }
        /// <summary>
        /// Maximum number of active Service Engines for the Virtual Service. Allowed values are 1-64.
        /// </summary>
        [JsonProperty(PropertyName = "max_scaleout_per_vs")]
        public int? MaxScaleoutPerVs { get; set; }
        /// <summary>
        /// Maximum number of Services Engines in this group. Allowed values are 0-1000.
        /// </summary>
        [JsonProperty(PropertyName = "max_se")]
        public int? MaxSe { get; set; }
        /// <summary>
        /// Maximum of number of 4 KB pages allocated to the Linux kernel GRO subsystem for packet coalescing. This parameter is
        /// limited to supported kernels only. Requires SE Reboot. Allowed values are 1-17. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "max_skb_frags")]
        public int? MaxSkbFrags { get; set; }
        /// <summary>
        /// Maximum number of Virtual Services that can be placed on a single Service Engine. Allowed values are 1-1000.
        /// </summary>
        [JsonProperty(PropertyName = "max_vs_per_se")]
        public int? MaxVsPerSe { get; set; }
        /// <summary>
        /// Placeholder for description of property mem_reserve of obj type ServiceEngineGroup field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "mem_reserve")]
        public bool? MemReserve { get; set; }
        /// <summary>
        /// Indicates the percent of memory reserved for config updates. Allowed values are 0-100. Field introduced in 18.1.2. Unit
        /// is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "memory_for_config_update")]
        public int? MemoryForConfigUpdate { get; set; }
        /// <summary>
        /// Amount of memory for each of the Service Engine virtual machines. Changes to this setting do not affect existing SEs.
        /// </summary>
        [JsonProperty(PropertyName = "memory_per_se")]
        public int? MemoryPerSe { get; set; }
        /// <summary>
        /// Management network to use for Avi Service Engines. It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_network_ref")]
        public string? MgmtNetworkRef { get; set; }
        /// <summary>
        /// Management subnet to use for Avi Service Engines.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_subnet")]
        public NSXTALBIpAddrPrefixType MgmtSubnet { get; set; }
        /// <summary>
        /// When CPU usage on an SE falls below the minimum threshold, Virtual Services hosted on the SE may be consolidated onto
        /// other underutilized SEs. After consolidation, unused Service Engines may then be eligible for deletion. . Allowed values
        /// are 20-60. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "min_cpu_usage")]
        public int? MinCpuUsage { get; set; }
        /// <summary>
        /// Minimum number of active Service Engines for the Virtual Service. Allowed values are 1-64.
        /// </summary>
        [JsonProperty(PropertyName = "min_scaleout_per_vs")]
        public int? MinScaleoutPerVs { get; set; }
        /// <summary>
        /// Minimum number of Services Engines in this group (relevant for SE AutoRebalance only). Allowed values are 0-1000. Field
        /// introduced in 17.2.13,18.1.3,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "min_se")]
        public int? MinSe { get; set; }
        /// <summary>
        /// Indicates the percent of memory reserved for connections. Allowed values are 0-100. Field introduced in 18.1.2. Unit is
        /// PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "minimum_connection_memory")]
        public int? MinimumConnectionMemory { get; set; }
        /// <summary>
        /// Required available config memory to apply any configuration. Allowed values are 0-90. Field deprecated in 18.1.2. Field
        /// introduced in 18.1.1. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "minimum_required_config_memory")]
        public int? MinimumRequiredConfigMemory { get; set; }
        /// <summary>
        /// Number of threads to use for log streaming. Allowed values are 1-100. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "n_log_streaming_threads")]
        public int? NLogStreamingThreads { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Idle timeout in seconds for nat tcp flows in closed state. Allowed values are 1-3600. Field deprecated in 18.2.5. Field
        /// introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "nat_flow_tcp_closed_timeout")]
        public int? NatFlowTcpClosedTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for nat tcp flows in established state. Allowed values are 1-3600. Field deprecated in 18.2.5.
        /// Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "nat_flow_tcp_established_timeout")]
        public int? NatFlowTcpEstablishedTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for nat tcp flows in half closed state. Allowed values are 1-3600. Field deprecated in 18.2.5.
        /// Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "nat_flow_tcp_half_closed_timeout")]
        public int? NatFlowTcpHalfClosedTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for nat tcp flows in handshake state. Allowed values are 1-3600. Field deprecated in 18.2.5.
        /// Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "nat_flow_tcp_handshake_timeout")]
        public int? NatFlowTcpHandshakeTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for nat udp flows in noresponse state. Allowed values are 1-3600. Field deprecated in 18.2.5.
        /// Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "nat_flow_udp_noresponse_timeout")]
        public int? NatFlowUdpNoresponseTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for nat udp flows in response state. Allowed values are 1-3600. Field deprecated in 18.2.5.
        /// Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "nat_flow_udp_response_timeout")]
        public int? NatFlowUdpResponseTimeout { get; set; }
        /// <summary>
        /// Number of threads to poll for netlink messages excluding the thread for default namespace. Requires SE Reboot. Allowed
        /// values are 1-32. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "netlink_poller_threads")]
        public int? NetlinkPollerThreads { get; set; }
        /// <summary>
        /// Socket buffer size for the netlink sockets. Requires SE Reboot. Allowed values are 1-128. Field introduced in 21.1.1.
        /// Unit is MEGA_BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "netlink_sock_buf_size")]
        public int? NetlinkSockBufSize { get; set; }
        /// <summary>
        /// Free the connection stack. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ngx_free_connection_stack")]
        public bool? NgxFreeConnectionStack { get; set; }
        /// <summary>
        /// This setting limits the number of non-significant logs generated per second per core on this SE. Default is 100 logs per
        /// second. Set it to zero (0) to deactivate throttling. Field introduced in 17.1.3. Unit is PER_SECOND.
        /// </summary>
        [JsonProperty(PropertyName = "non_significant_log_throttle")]
        public int? NonSignificantLogThrottle { get; set; }
        /// <summary>
        /// Dequeue interval for receive queue from NS HELPER. Allowed values are 1-1000. Field introduced in 21.1.1. Unit is
        /// MILLISECONDS. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ns_helper_deq_interval_msec")]
        public int? NsHelperDeqIntervalMsec { get; set; }
        /// <summary>
        /// Number of dispatcher cores (0,1,2,4,8 or 16). If set to 0, then number of dispatcher cores is deduced
        /// automatically.Requires SE Reboot. Allowed values are 0,1,2,4,8,16. Field introduced in 17.2.12, 18.1.3, 18.2.1. Allowed
        /// in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "num_dispatcher_cores")]
        public int? NumDispatcherCores { get; set; }
        /// <summary>
        /// Number of queues to each dispatcher. Allowed values are 2-8. Special values are 0 - auto-compute, 1 - single-queue.
        /// Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_dispatcher_queues")]
        public int? NumDispatcherQueues { get; set; }
        /// <summary>
        /// Number of changes in num flow cores sum to ignore.
        /// </summary>
        [JsonProperty(PropertyName = "num_flow_cores_sum_changes_to_ignore")]
        public int? NumFlowCoresSumChangesToIgnore { get; set; }
        /// <summary>
        /// Configuration knobs for InterSE Object Distribution. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "objsync_config")]
        public NSXTALBObjSyncConfigType ObjsyncConfig { get; set; }
        /// <summary>
        /// TCP port on SE management interface for InterSE Object Distribution. Supported only for externally managed security
        /// groups. Not supported on full access deployments. Requires SE reboot. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "objsync_port")]
        public int? ObjsyncPort { get; set; }
        /// <summary>
        /// Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "openstack_availability_zone")]
        public string? OpenstackAvailabilityZone { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1. Maximum of 5 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "openstack_availability_zones")]
        public IList<string> OpenstackAvailabilityZones { get; set; }
        /// <summary>
        /// Avi Management network name.
        /// </summary>
        [JsonProperty(PropertyName = "openstack_mgmt_network_name")]
        public string? OpenstackMgmtNetworkName { get; set; }
        /// <summary>
        /// Management network UUID.
        /// </summary>
        [JsonProperty(PropertyName = "openstack_mgmt_network_uuid")]
        public string? OpenstackMgmtNetworkUuid { get; set; }
        /// <summary>
        /// Amount of extra memory to be reserved for use by the Operating System on a Service Engine. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "os_reserved_memory")]
        public int? OsReservedMemory { get; set; }
        /// <summary>
        /// Determines the PCAP transmit mode of operation. Requires SE Reboot. Enum options - PCAP_TX_AUTO, PCAP_TX_SOCKET,
        /// PCAP_TX_RING. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pcap_tx_mode")]
        public string? PcapTxMode { get; set; }
        /// <summary>
        /// In PCAP mode, reserve a configured portion of TX ring resources for itself and the remaining portion for the RX ring to
        /// achieve better balance in terms of queue depth. Requires SE Reboot. Allowed values are 10-100. Field introduced in
        /// 20.1.3. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "pcap_tx_ring_rd_balancing_factor")]
        public int? PcapTxRingRdBalancingFactor { get; set; }
        /// <summary>
        /// Per-app SE mode is designed for deploying dedicated load balancers per app (VS). In this mode, each SE is limited to a
        /// max of 2 VSs. vCPUs in per-app SEs count towards licensing usage at 25% rate. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "per_app")]
        public bool? PerApp { get; set; }
        /// <summary>
        /// Enable/Disable per VS level admission control.Enabling this feature will cause the connection and packet throttling on a
        /// particular VS that has high packet buffer consumption. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "per_vs_admission_control")]
        public bool? PerVsAdmissionControl { get; set; }
        /// <summary>
        /// If placement mode is 'Auto', Virtual Services are automatically placed on Service Engines. Enum options -
        /// PLACEMENT_MODE_AUTO.
        /// </summary>
        [JsonProperty(PropertyName = "placement_mode")]
        public string? PlacementMode { get; set; }
        /// <summary>
        /// Enable or deactivate real time SE metrics.
        /// </summary>
        [JsonProperty(PropertyName = "realtime_se_metrics")]
        public NSXTALBMetricsRealTimeUpdateType RealtimeSeMetrics { get; set; }
        /// <summary>
        /// Reboot the VM or host on kernel panic. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "reboot_on_panic")]
        public bool? RebootOnPanic { get; set; }
        /// <summary>
        /// Reboot the system if the SE is stopped. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "reboot_on_stop")]
        public bool? RebootOnStop { get; set; }
        /// <summary>
        /// Time interval to re-sync SE's time with wall clock time. Allowed values are 8-600000. Field introduced in 20.1.1. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "resync_time_interval")]
        public int? ResyncTimeInterval { get; set; }
        /// <summary>
        /// SDB pipeline flush interval. Allowed values are 1-10000. Field introduced in 21.1.1. Unit is MILLISECONDS. Allowed in
        /// Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sdb_flush_interval")]
        public int? SdbFlushInterval { get; set; }
        /// <summary>
        /// SDB pipeline size. Allowed values are 1-10000. Field introduced in 21.1.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sdb_pipeline_size")]
        public int? SdbPipelineSize { get; set; }
        /// <summary>
        /// SDB scan count. Allowed values are 1-1000. Field introduced in 21.1.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sdb_scan_count")]
        public int? SdbScanCount { get; set; }
        /// <summary>
        /// Select the SE bandwidth for the bandwidth license. Enum options - SE_BANDWIDTH_UNLIMITED, SE_BANDWIDTH_25M,
        /// SE_BANDWIDTH_200M, SE_BANDWIDTH_1000M, SE_BANDWIDTH_10000M. Field introduced in 17.2.5. Allowed in Basic(Allowed values-
        /// SE_BANDWIDTH_UNLIMITED) edition, Essentials(Allowed values- SE_BANDWIDTH_UNLIMITED) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_bandwidth_type")]
        public string? SeBandwidthType { get; set; }
        /// <summary>
        /// Delay the cleanup of flowtable entry. To be used under surveillance of Avi Support. Field introduced in 20.1.2. Allowed
        /// in Basic(Allowed values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_delayed_flow_delete")]
        public bool? SeDelayedFlowDelete { get; set; }
        /// <summary>
        /// Duration to preserve unused Service Engine virtual machines before deleting them. If traffic to a Virtual Service were
        /// to spike up abruptly, this SE would still be available to be utilized again rather than creating a new SE. If this value
        /// is set to 0, Controller will never delete any SEs and administrator has to manually cleanup unused SEs. Allowed values
        /// are 0-525600. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "se_deprovision_delay")]
        public int? SeDeprovisionDelay { get; set; }
        /// <summary>
        /// Placeholder for description of property se_dos_profile of obj type ServiceEngineGroup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_dos_profile")]
        public NSXTALBDosThresholdProfileType SeDosProfile { get; set; }
        /// <summary>
        /// Internal only. Used to simulate SE - SE HB failure. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_hm_drops")]
        public int? SeDpHmDrops { get; set; }
        /// <summary>
        /// Number of jiffies between polling interface state. Field introduced in 21.1.3. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_if_state_poll_interval")]
        public int? SeDpIfStatePollInterval { get; set; }
        /// <summary>
        /// Toggle support to run SE datapath instances in isolation on exclusive CPUs. This improves latency and performance.
        /// However, this could reduce the total number of se_dp instances created on that SE instance. Supported for >= 8 CPUs.
        /// Requires SE reboot. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_isolation")]
        public bool? SeDpIsolation { get; set; }
        /// <summary>
        /// Number of CPUs for non se-dp tasks in SE datapath isolation mode. Translates Total cpus minus 'num_non_dp_cpus' for
        /// datapath use. It is recommended to reserve an even number of CPUs for hyper-threaded processors. Requires SE reboot.
        /// Allowed values are 1-8. Special values are 0- auto. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_isolation_num_non_dp_cpus")]
        public int? SeDpIsolationNumNonDpCpus { get; set; }
        /// <summary>
        /// Internal buffer full indicator on the Service Engine beyond which the unfiltered logs are abandoned. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_log_nf_enqueue_percent")]
        public int? SeDpLogNfEnqueuePercent { get; set; }
        /// <summary>
        /// Internal buffer full indicator on the Service Engine beyond which the user filtered logs are abandoned. Field introduced
        /// in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_log_udf_enqueue_percent")]
        public int? SeDpLogUdfEnqueuePercent { get; set; }
        /// <summary>
        /// The highest supported SE-SE Heartbeat protocol version. This version is reported by Secondary SE to Primary SE in
        /// Heartbeat response messages. Allowed values are 1-3. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_max_hb_version")]
        public int? SeDpMaxHbVersion { get; set; }
        /// <summary>
        /// Time (in seconds) service engine waits for after generating a Vnic transmit queue stall event before resetting theNIC.
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_queue_stall_event_sleep")]
        public int? SeDpVnicQueueStallEventSleep { get; set; }
        /// <summary>
        /// Number of consecutive transmit failures to look for before generating a Vnic transmit queue stall event. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_queue_stall_threshold")]
        public int? SeDpVnicQueueStallThreshold { get; set; }
        /// <summary>
        /// Time (in milliseconds) to wait for network/NIC recovery on detecting a transmit queue stall after which service engine
        /// resets the NIC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_queue_stall_timeout")]
        public int? SeDpVnicQueueStallTimeout { get; set; }
        /// <summary>
        /// Number of consecutive transmit queue stall events in se_dp_vnic_stall_se_restart_window to look for before restarting
        /// SE. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_restart_on_queue_stall_count")]
        public int? SeDpVnicRestartOnQueueStallCount { get; set; }
        /// <summary>
        /// Window of time (in seconds) during which se_dp_vnic_restart_on_queue_stall_count number of consecutive stalls results in
        /// a SE restart. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_stall_se_restart_window")]
        public int? SeDpVnicStallSeRestartWindow { get; set; }
        /// <summary>
        /// Determines if DPDK pool mode driver should be used or not   0  Automatically determine based on hypervisor/NIC type 1 
        /// Unconditionally use DPDK poll mode driver 2  Don't use DPDK poll mode driver.Requires SE Reboot. Allowed values are 0-2.
        /// Field introduced in 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_dpdk_pmd")]
        public int? SeDpdkPmd { get; set; }
        /// <summary>
        /// Enable core dump on assert. Field introduced in 21.1.3. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_dump_core_on_assert")]
        public bool? SeDumpCoreOnAssert { get; set; }
        /// <summary>
        /// Use this to emulate more/less cpus than is actually available. One datapath process is started for each core. Field
        /// introduced in 21.1.3. Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_emulated_cores")]
        public int? SeEmulatedCores { get; set; }
        /// <summary>
        /// Flow probe retry count if no replies are received.Requires SE Reboot. Allowed values are 0-5. Field introduced in
        /// 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_flow_probe_retries")]
        public int? SeFlowProbeRetries { get; set; }
        /// <summary>
        /// Timeout in milliseconds for flow probe retries.Requires SE Reboot. Allowed values are 20-50. Field introduced in 18.2.5.
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_flow_probe_retry_timer")]
        public int? SeFlowProbeRetryTimer { get; set; }
        /// <summary>
        /// Timeout in milliseconds for flow probe entries. Allowed values are 10-200. Field deprecated in 18.2.5. Field introduced
        /// in 18.1.4, 18.2.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_flow_probe_timer")]
        public int? SeFlowProbeTimer { get; set; }
        /// <summary>
        /// Analytics Policy for ServiceEngineGroup. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_analytics_policy")]
        public NSXTALBSeGroupAnalyticsPolicyType SeGroupAnalyticsPolicy { get; set; }
        /// <summary>
        /// Controls the distribution of SE data path processes on CPUs which support hyper-threading. Requires hyper-threading to
        /// be enabled at host level. Requires SE Reboot. For more details please refer to SE placement KB. Enum options -
        /// SE_CPU_HT_AUTO, SE_CPU_HT_SPARSE_DISPATCHER_PRIORITY, SE_CPU_HT_SPARSE_PROXY_PRIORITY, SE_CPU_HT_PACKED_CORES. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_hyperthreaded_mode")]
        public string? SeHyperthreadedMode { get; set; }
        /// <summary>
        /// Determines if SE-SE IPC messages are encapsulated in an IP header       0        Automatically determine based on
        /// hypervisor type    1        Use IP encap unconditionally    ~[0,1]   Don't use IP encapRequires SE Reboot. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_ip_encap_ipc")]
        public int? SeIpEncapIpc { get; set; }
        /// <summary>
        /// UDP Port for SE_DP IPC in Docker bridge mode. Field deprecated in 20.1.1. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_ipc_udp_port")]
        public int? SeIpcUdpPort { get; set; }
        /// <summary>
        /// This knob controls the resource availability and burst size used between SE datapath and KNI. This helps in minimising
        /// packet drops when there is higher KNI traffic (non-VIP traffic from and to Linux). The factor takes the following values
        /// 0-default.     1-doubles the burst size and KNI resources.     2-quadruples the burst size and KNI resources. Allowed
        /// values are 0-2. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_kni_burst_factor")]
        public int? SeKniBurstFactor { get; set; }
        /// <summary>
        /// Determines if SE-SE IPC messages use SE interface IP instead of VIP        0        Automatically determine based on
        /// hypervisor type    1        Use SE interface IP unconditionally    ~[0,1]   Don't use SE interface IPRequires SE Reboot.
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_l3_encap_ipc")]
        public int? SeL3EncapIpc { get; set; }
        /// <summary>
        /// Internal flag that blocks dataplane until all application logs are flushed to log-agent process. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_app_blocking_dequeue")]
        public bool? SeLogBufferAppBlockingDequeue { get; set; }
        /// <summary>
        /// Internal flag that blocks dataplane until all connection logs are flushed to log-agent process. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_conn_blocking_dequeue")]
        public bool? SeLogBufferConnBlockingDequeue { get; set; }
        /// <summary>
        /// Internal flag that blocks dataplane until all outstanding events are flushed to log-agent process. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_events_blocking_dequeue")]
        public bool? SeLogBufferEventsBlockingDequeue { get; set; }
        /// <summary>
        /// Enable or disable Large Receive Optimization for vnics. Requires SE Reboot. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_lro")]
        public bool? SeLro { get; set; }
        /// <summary>
        /// The retry count for the multi-producer enqueue before yielding the CPU. To be used under surveillance of Avi Support.
        /// Field introduced in 20.1.3. Allowed in Basic(Allowed values- 500) edition, Essentials(Allowed values- 500) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_mp_ring_retry_count")]
        public int? SeMpRingRetryCount { get; set; }
        /// <summary>
        /// MTU for the VNICs of SEs in the SE group. Allowed values are 512-9000. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_mtu")]
        public int? SeMtu { get; set; }
        /// <summary>
        /// Prefix to use for virtual machine name of Service Engines.
        /// </summary>
        [JsonProperty(PropertyName = "se_name_prefix")]
        public string? SeNamePrefix { get; set; }
        /// <summary>
        /// Internal use only. Used to artificially reduce the available number of packet buffers. Field introduced in 21.1.3.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_packet_buffer_max")]
        public int? SePacketBufferMax { get; set; }
        /// <summary>
        /// Enables lookahead mode of packet receive in PCAP mode. Introduced to overcome an issue with hv_netvsc driver. Lookahead
        /// mode attempts to ensure that application and kernel's view of the receive rings are consistent. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_lookahead")]
        public bool? SePcapLookahead { get; set; }
        /// <summary>
        /// Max number of packets the pcap interface can hold and if the value is 0 the optimum value will be chosen. The optimum
        /// value will be chosen based on SE-memory, Cloud Type and Number of Interfaces.Requires SE Reboot. Field introduced in
        /// 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_pkt_count")]
        public int? SePcapPktCount { get; set; }
        /// <summary>
        /// Max size of each packet in the pcap interface. Requires SE Reboot. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_pkt_sz")]
        public int? SePcapPktSz { get; set; }
        /// <summary>
        /// Bypass the kernel's traffic control layer, to deliver packets directly to the driver. Enabling this feature results in
        /// egress packets not being captured in host tcpdump. Note   brief packet reordering or loss may occur upon toggle. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_qdisc_bypass")]
        public bool? SePcapQdiscBypass { get; set; }
        /// <summary>
        /// Frequency in seconds at which periodically a PCAP reinit check is triggered. May be used in conjunction with the
        /// configuration pcap_reinit_threshold. (Valid range   15 mins - 12 hours, 0 - disables). Allowed values are 900-43200.
        /// Special values are 0- disable. Field introduced in 17.2.13, 18.1.3, 18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_reinit_frequency")]
        public int? SePcapReinitFrequency { get; set; }
        /// <summary>
        /// Threshold for input packet receive errors in PCAP mode exceeding which a PCAP reinit is triggered. If not set, an
        /// unconditional reinit is performed. This value is checked every pcap_reinit_frequency interval. Field introduced in
        /// 17.2.13, 18.1.3, 18.2.1. Unit is METRIC_COUNT.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_reinit_threshold")]
        public int? SePcapReinitThreshold { get; set; }
        /// <summary>
        /// TCP port on SE where echo service will be run. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_probe_port")]
        public int? SeProbePort { get; set; }
        /// <summary>
        /// UDP Port for punted packets in Docker bridge mode. Field deprecated in 20.1.1. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_remote_punt_udp_port")]
        public int? SeRemotePuntUdpPort { get; set; }
        /// <summary>
        /// Rate limiter properties. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_rl_prop")]
        public NSXTALBRateLimiterPropertiesType SeRlProp { get; set; }
        /// <summary>
        /// Enable routing via Service Engine Datapath. When disabled, routing is done by the Linux kernel. IP Routing needs to be
        /// enabled in Service Engine Group for SE Routing to be effective. Field deprecated in 18.2.5. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_routing")]
        public bool? SeRouting { get; set; }
        /// <summary>
        /// Minimum time to wait on server between taking sampleswhen sampling the navigation timing data from the end user client.
        /// Field introduced in 18.2.6. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_nav_interval")]
        public int? SeRumSamplingNavInterval { get; set; }
        /// <summary>
        /// Percentage of navigation timing data from the end user client, used for sampling to get client insights. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_nav_percent")]
        public int? SeRumSamplingNavPercent { get; set; }
        /// <summary>
        /// Minimum time to wait on server between taking sampleswhen sampling the resource timing data from the end user client.
        /// Field introduced in 18.2.6. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_res_interval")]
        public int? SeRumSamplingResInterval { get; set; }
        /// <summary>
        /// Percentage of resource timing data from the end user client used for sampling to get client insight. Field introduced in
        /// 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_res_percent")]
        public int? SeRumSamplingResPercent { get; set; }
        /// <summary>
        /// Sideband traffic will be handled by a dedicated core.Requires SE Reboot. Field introduced in 16.5.2, 17.1.9, 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_sb_dedicated_core")]
        public bool? SeSbDedicatedCore { get; set; }
        /// <summary>
        /// Number of Sideband threads per SE.Requires SE Reboot. Allowed values are 1-128. Field introduced in 16.5.2, 17.1.9,
        /// 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_sb_threads")]
        public int? SeSbThreads { get; set; }
        /// <summary>
        /// Multiplier for SE threads based on vCPU. Allowed values are 1-10. Allowed in Basic(Allowed values- 1) edition,
        /// Essentials(Allowed values- 1) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_thread_multiplier")]
        public int? SeThreadMultiplier { get; set; }
        /// <summary>
        /// Traceroute port range. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "se_tracert_port_range")]
        public NSXTALBPortRangeType SeTracertPortRange { get; set; }
        /// <summary>
        /// Determines if Direct Secondary Return (DSR) from secondary SE is active or not  0  Automatically determine based on
        /// hypervisor type. 1  Enable tunnel mode - DSR is unconditionally disabled. 2  Disable tunnel mode - DSR is
        /// unconditionally enabled. Tunnel mode can be enabled or disabled at run-time. Allowed values are 0-2. Field introduced in
        /// 17.1.1. Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_tunnel_mode")]
        public int? SeTunnelMode { get; set; }
        /// <summary>
        /// UDP Port for tunneled packets from secondary to primary SE in Docker bridge mode.Requires SE Reboot. Field introduced in
        /// 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_tunnel_udp_port")]
        public int? SeTunnelUdpPort { get; set; }
        /// <summary>
        /// Number of packets to batch for transmit to the nic. Requires SE Reboot. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_tx_batch_size")]
        public int? SeTxBatchSize { get; set; }
        /// <summary>
        /// Once the TX queue of the dispatcher reaches this threshold, hardware queues are not polled for further packets. To be
        /// used under surveillance of Avi Support. Allowed values are 512-32768. Field introduced in 20.1.2. Allowed in
        /// Basic(Allowed values- 2048) edition, Essentials(Allowed values- 2048) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_txq_threshold")]
        public int? SeTxqThreshold { get; set; }
        /// <summary>
        /// Determines if SE-SE IPC messages are encapsulated in a UDP header  0  Automatically determine based on hypervisor type.
        /// 1  Use UDP encap unconditionally.Requires SE Reboot. Allowed values are 0-1. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_udp_encap_ipc")]
        public int? SeUdpEncapIpc { get; set; }
        /// <summary>
        /// Determines if DPDK library should be used or not   0  Automatically determine based on hypervisor type 1  Use DPDK if
        /// PCAP is not enabled 2  Don't use DPDK. Allowed values are 0-2. Field introduced in 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_use_dpdk")]
        public int? SeUseDpdk { get; set; }
        /// <summary>
        /// Configure the frequency in milliseconds of software transmit spillover queue flush when enabled. This is necessary to
        /// flush any packets in the spillover queue in the absence of a packet transmit in the normal course of operation. Allowed
        /// values are 50-500. Special values are 0- disable. Field introduced in 20.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_vnic_tx_sw_queue_flush_frequency")]
        public int? SeVnicTxSwQueueFlushFrequency { get; set; }
        /// <summary>
        /// Configure the size of software transmit spillover queue when enabled. Requires SE Reboot. Allowed values are 128-2048.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_vnic_tx_sw_queue_size")]
        public int? SeVnicTxSwQueueSize { get; set; }
        /// <summary>
        /// Maximum number of aggregated vs heartbeat packets to send in a batch. Allowed values are 1-256. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_vs_hb_max_pkts_in_batch")]
        public int? SeVsHbMaxPktsInBatch { get; set; }
        /// <summary>
        /// Maximum number of virtualservices for which heartbeat messages are aggregated in one packet. Allowed values are 1-1024.
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_vs_hb_max_vs_in_pkt")]
        public int? SeVsHbMaxVsInPkt { get; set; }
        /// <summary>
        /// Enable SEs to elect a primary amongst themselves in the absence of a connectivity to controller. Field introduced in
        /// 18.1.2. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "self_se_election")]
        public bool? SelfSeElection { get; set; }
        /// <summary>
        /// Timeout for sending SE_READY without NS HELPER registration completion. Allowed values are 10-600. Field introduced in
        /// 21.1.1. Unit is SECONDS. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "send_se_ready_timeout")]
        public int? SendSeReadyTimeout { get; set; }
        /// <summary>
        /// IPv6 Subnets assigned to the SE group. Required for VS group placement. Field introduced in 18.1.1. Maximum of 128 items
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "service_ip6_subnets")]
        public IList<NSXTALBIpAddrPrefixType> ServiceIp6Subnets { get; set; }
        /// <summary>
        /// Subnets assigned to the SE group. Required for VS group placement. Field introduced in 17.1.1. Maximum of 128 items
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "service_ip_subnets")]
        public IList<NSXTALBIpAddrPrefixType> ServiceIpSubnets { get; set; }
        /// <summary>
        /// Minimum required shared memory to apply any configuration. Allowed values are 0-100. Field introduced in 18.1.2. Unit is
        /// MB.
        /// </summary>
        [JsonProperty(PropertyName = "shm_minimum_config_memory")]
        public int? ShmMinimumConfigMemory { get; set; }
        /// <summary>
        /// This setting limits the number of significant logs generated per second per core on this SE. Default is 100 logs per
        /// second. Set it to zero (0) to deactivate throttling. Field introduced in 17.1.3. Unit is PER_SECOND.
        /// </summary>
        [JsonProperty(PropertyName = "significant_log_throttle")]
        public int? SignificantLogThrottle { get; set; }
        /// <summary>
        /// (Beta) Preprocess SSL Client Hello for SNI hostname extension.If set to True, this will apply SNI child's SSL
        /// protocol(s), if they are different from SNI Parent's allowed SSL protocol(s). Field introduced in 17.2.12, 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_preprocess_sni_hostname")]
        public bool? SslPreprocessSniHostname { get; set; }
        /// <summary>
        /// Number of SSL sessions that can be cached per VS. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_sess_cache_per_vs")]
        public int? SslSessCachePerVs { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// The threshold for the transient shared config memory in the SE. Allowed values are 0-100. Field introduced in 20.1.1.
        /// Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "transient_shared_memory_max")]
        public int? TransientSharedMemoryMax { get; set; }
        /// <summary>
        /// This setting limits the number of UDF logs generated per second per core on this SE. UDF logs are generated due to the
        /// configured client log filters or the rules with logging enabled. Default is 100 logs per second. Set it to zero (0) to
        /// deactivate throttling. Field introduced in 17.1.3. Unit is PER_SECOND.
        /// </summary>
        [JsonProperty(PropertyName = "udf_log_throttle")]
        public int? UdfLogThrottle { get; set; }
        /// <summary>
        /// Timeout for backend connection. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connect_timeout")]
        public int? UpstreamConnectTimeout { get; set; }
        /// <summary>
        /// Enable upstream connection pool,. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_enable")]
        public bool? UpstreamConnpoolEnable { get; set; }
        /// <summary>
        /// Timeout for data to be received from backend. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_read_timeout")]
        public int? UpstreamReadTimeout { get; set; }
        /// <summary>
        /// Timeout for upstream to become writable. Field introduced in 21.1.1. Unit is MILLISECONDS. Allowed in Basic(Allowed
        /// values- 3600000) edition, Essentials(Allowed values- 3600000) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_send_timeout")]
        public int? UpstreamSendTimeout { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Enables the use of hyper-threaded cores on SE. Requires SE Reboot. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_hyperthreaded_cores")]
        public bool? UseHyperthreadedCores { get; set; }
        /// <summary>
        /// Enable legacy model of netlink notifications. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_legacy_netlink")]
        public bool? UseLegacyNetlink { get; set; }
        /// <summary>
        /// Enable InterSE Objsyc distribution framework. Field introduced in 20.1.3. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "use_objsync")]
        public bool? UseObjsync { get; set; }
        /// <summary>
        /// Use Standard SKU Azure Load Balancer. By default cloud level flag is set. If not set, it inherits/uses the
        /// use_standard_alb flag from the cloud. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "use_standard_alb")]
        public bool? UseStandardAlb { get; set; }
        /// <summary>
        /// Configuration for User-Agent Cache used in Bot Management. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "user_agent_cache_config")]
        public NSXTALBUserAgentCacheConfigType UserAgentCacheConfig { get; set; }
        /// <summary>
        /// Defines in seconds how long before an unused user-defined-metric is garbage collected. Field introduced in 21.1.1. Unit
        /// is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "user_defined_metric_age")]
        public int? UserDefinedMetricAge { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_clusters of obj type ServiceEngineGroup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_clusters")]
        public NSXTALBVcenterClustersType VcenterClusters { get; set; }
        /// <summary>
        /// Enum options - VCENTER_DATASTORE_ANY, VCENTER_DATASTORE_LOCAL, VCENTER_DATASTORE_SHARED.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_datastore_mode")]
        public string? VcenterDatastoreMode { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_datastores of obj type ServiceEngineGroup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_datastores")]
        public IList<NSXTALBVcenterDatastoreType> VcenterDatastores { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_datastores_include of obj type ServiceEngineGroup field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_datastores_include")]
        public bool? VcenterDatastoresInclude { get; set; }
        /// <summary>
        /// Folder to place all the Service Engine virtual machines in vCenter.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_folder")]
        public string? VcenterFolder { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_hosts of obj type ServiceEngineGroup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_hosts")]
        public NSXTALBVcenterHostsType VcenterHosts { get; set; }
        /// <summary>
        /// VCenter information for scoping at Host/Cluster level. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenters")]
        public IList<NSXTALBPlacementScopeConfigType> Vcenters { get; set; }
        /// <summary>
        /// Number of vcpus for each of the Service Engine virtual machines. Changes to this setting do not affect existing SEs.
        /// </summary>
        [JsonProperty(PropertyName = "vcpus_per_se")]
        public int? VcpusPerSe { get; set; }
        /// <summary>
        /// When vip_asg is set, Vip configuration will be managed by Avi.User will be able to configure vip_asg or Vips
        /// individually at the time of create. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "vip_asg")]
        public NSXTALBVipAutoscaleGroupType VipAsg { get; set; }
        /// <summary>
        /// DHCP ip check interval. Allowed values are 1-1000. Field introduced in 21.1.1. Unit is SEC. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_dhcp_ip_check_interval")]
        public int? VnicDhcpIpCheckInterval { get; set; }
        /// <summary>
        /// DHCP ip max retries. Field introduced in 21.1.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_dhcp_ip_max_retries")]
        public int? VnicDhcpIpMaxRetries { get; set; }
        /// <summary>
        /// wait interval before deleting IP. . Field introduced in 21.1.1. Unit is SEC. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_ip_delete_interval")]
        public int? VnicIpDeleteInterval { get; set; }
        /// <summary>
        /// Probe vnic interval. Field introduced in 21.1.1. Unit is SEC. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_probe_interval")]
        public int? VnicProbeInterval { get; set; }
        /// <summary>
        /// Time interval for retrying the failed VNIC RPC requests. Field introduced in 21.1.1. Unit is SEC. Allowed in Basic
        /// edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_rpc_retry_interval")]
        public int? VnicRpcRetryInterval { get; set; }
        /// <summary>
        /// Size of vnicdb command history. Allowed values are 0-65535. Field introduced in 21.1.1. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "vnicdb_cmd_history_size")]
        public int? VnicdbCmdHistorySize { get; set; }
        /// <summary>
        /// Ensure primary and secondary Service Engines are deployed on different physical hosts. Allowed in Basic(Allowed values-
        /// true) edition, Essentials(Allowed values- true) edition, Enterprise edition. Special default for Basic edition is true,
        /// Essentials edition is true, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "vs_host_redundancy")]
        public bool? VsHostRedundancy { get; set; }
        /// <summary>
        /// Time to wait for the scaled in SE to drain existing flows before marking the scalein done. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_scalein_timeout")]
        public int? VsScaleinTimeout { get; set; }
        /// <summary>
        /// During SE upgrade, Time to wait for the scaled-in SE to drain existing flows before marking the scalein done. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_scalein_timeout_for_upgrade")]
        public int? VsScaleinTimeoutForUpgrade { get; set; }
        /// <summary>
        /// Time to wait for the scaled out SE to become ready before marking the scaleout done. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_scaleout_timeout")]
        public int? VsScaleoutTimeout { get; set; }
        /// <summary>
        /// Wait time for sending scaleout ready notification after Virtual Service is marked UP. In certain deployments, there may
        /// be an additional delay to accept traffic. For example, for BGP, some time is needed for route advertisement. Allowed
        /// values are 0-20. Field introduced in 18.1.5,18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_scaleout_additional_wait_time")]
        public int? VsSeScaleoutAdditionalWaitTime { get; set; }
        /// <summary>
        /// Timeout in seconds for Service Engine to sendScaleout Ready notification of a Virtual Service. Allowed values are 0-90.
        /// Field introduced in 18.1.5,18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_scaleout_ready_timeout")]
        public int? VsSeScaleoutReadyTimeout { get; set; }
        /// <summary>
        /// During SE upgrade in a legacy active/standby segroup, Time to wait for the new primary SE to accept flows before marking
        /// the switchover done. Field introduced in 17.2.13,18.1.4,18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_switchover_timeout")]
        public int? VsSwitchoverTimeout { get; set; }
        /// <summary>
        /// Parameters to place Virtual Services on only a subset of the cores of an SE. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "vss_placement")]
        public NSXTALBVssPlacementType VssPlacement { get; set; }
        /// <summary>
        /// If set, Virtual Services will be placed on only a subset of the cores of an SE. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vss_placement_enabled")]
        public bool? VssPlacementEnabled { get; set; }
        /// <summary>
        /// Frequency with which SE publishes WAF learning. Allowed values are 1-43200. Field deprecated in 18.2.3. Field introduced
        /// in 18.1.2. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "waf_learning_interval")]
        public int? WafLearningInterval { get; set; }
        /// <summary>
        /// Amount of memory reserved on SE for WAF learning. This can be atmost 5% of SE memory. Field deprecated in 18.2.3. Field
        /// introduced in 18.1.2. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "waf_learning_memory")]
        public int? WafLearningMemory { get; set; }
        /// <summary>
        /// Enable memory pool for WAF.Requires SE Reboot. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "waf_mempool")]
        public bool? WafMempool { get; set; }
        /// <summary>
        /// Memory pool size used for WAF.Requires SE Reboot. Field introduced in 17.2.3. Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "waf_mempool_size")]
        public int? WafMempoolSize { get; set; }
    }
}
