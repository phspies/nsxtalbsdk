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
    public class NSXTALBControllerPropertiesType 
    {
        public NSXTALBControllerPropertiesType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Allow non-admin tenants to update admin VrfContext and Network objects. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow_admin_network_updates")]
        public bool? AllowAdminNetworkUpdates { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow_ip_forwarding")]
        public bool? AllowIpForwarding { get; set; }
        /// <summary>
        /// Allow unauthenticated access for special APIs.
        /// </summary>
        [JsonProperty(PropertyName = "allow_unauthenticated_apis")]
        public bool? AllowUnauthenticatedApis { get; set; }
        /// <summary>
        /// Placeholder for description of property allow_unauthenticated_nodes of obj type ControllerProperties field type str 
        /// type boolean
        /// </summary>
        [JsonProperty(PropertyName = "allow_unauthenticated_nodes")]
        public bool? AllowUnauthenticatedNodes { get; set; }
        /// <summary>
        /// Allowed values are 0-1440. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "api_idle_timeout")]
        public int? ApiIdleTimeout { get; set; }
        /// <summary>
        /// Threshold to log request timing in portal_performance.log and Server-Timing response header. Any stage taking longer
        /// than 1% of the threshold will be included in the Server-Timing header. Field introduced in 18.1.4, 18.2.1. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "api_perf_logging_threshold")]
        public int? ApiPerfLoggingThreshold { get; set; }
        /// <summary>
        /// Export configuration in appviewx compatibility mode. Field introduced in 17.1.1. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "appviewx_compat_mode")]
        public bool? AppviewxCompatMode { get; set; }
        /// <summary>
        /// Period for which asynchronous patch requests are queued. Allowed values are 30-120. Special values are 0 - Deactivated.
        /// Field introduced in 18.2.11, 20.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "async_patch_merge_period")]
        public int? AsyncPatchMergePeriod { get; set; }
        /// <summary>
        /// Duration for which asynchronous patch requests should be kept, after being marked as SUCCESS or FAIL. Allowed values are
        /// 5-120. Field introduced in 18.2.11, 20.1.3. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "async_patch_request_cleanup_duration")]
        public int? AsyncPatchRequestCleanupDuration { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "attach_ip_retry_interval")]
        public int? AttachIpRetryInterval { get; set; }
        /// <summary>
        /// Number of attach_ip_retry_limit.
        /// </summary>
        [JsonProperty(PropertyName = "attach_ip_retry_limit")]
        public int? AttachIpRetryLimit { get; set; }
        /// <summary>
        /// Use Ansible for SE creation in baremetal. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "bm_use_ansible")]
        public bool? BmUseAnsible { get; set; }
        /// <summary>
        /// Enforce VsVip FQDN syntax checks. Field introduced in 20.1.6. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "check_vsvip_fqdn_syntax")]
        public bool? CheckVsvipFqdnSyntax { get; set; }
        /// <summary>
        /// Period for auth token cleanup job. Field introduced in 18.1.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "cleanup_expired_authtoken_timeout_period")]
        public int? CleanupExpiredAuthtokenTimeoutPeriod { get; set; }
        /// <summary>
        /// Period for sessions cleanup job. Field introduced in 18.1.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "cleanup_sessions_timeout_period")]
        public int? CleanupSessionsTimeoutPeriod { get; set; }
        /// <summary>
        /// Enable/Disable periodic reconcile for all the clouds. Field introduced in 17.2.14,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_reconcile")]
        public bool? CloudReconcile { get; set; }
        /// <summary>
        /// Period for cluster ip gratuitous arp job. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_ip_gratuitous_arp_period")]
        public int? ClusterIpGratuitousArpPeriod { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Period for consistency check job. Field introduced in 18.1.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "consistency_check_timeout_period")]
        public int? ConsistencyCheckTimeoutPeriod { get; set; }
        /// <summary>
        /// Periodically collect stats. Field introduced in 20.1.3. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "controller_resource_info_collection_period")]
        public int? ControllerResourceInfoCollectionPeriod { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "crashed_se_reboot")]
        public int? CrashedSeReboot { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "dead_se_detection_timer")]
        public int? DeadSeDetectionTimer { get; set; }
        /// <summary>
        /// Minimum api timeout value.If this value is not 60, it will be the default timeout for all APIs that do not have a
        /// specific timeout.If an API has a specific timeout but is less than this value, this value will become the new timeout.
        /// Allowed values are 60-3600. Field introduced in 18.2.6. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "default_minimum_api_timeout")]
        public int? DefaultMinimumApiTimeout { get; set; }
        /// <summary>
        /// The amount of time the controller will wait before deleting an offline SE after it has been rebooted. For unresponsive
        /// SEs, the total time will be  unresponsive_se_reboot + del_offline_se_after_reboot_delay. For crashed SEs, the total time
        /// will be crashed_se_reboot + del_offline_se_after_reboot_delay. Field introduced in 20.1.5. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "del_offline_se_after_reboot_delay")]
        public int? DelOfflineSeAfterRebootDelay { get; set; }
        /// <summary>
        /// Amount of time to wait after last Detach IP failure before attempting next Detach IP retry. Field introduced in 21.1.3.
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "detach_ip_retry_interval")]
        public int? DetachIpRetryInterval { get; set; }
        /// <summary>
        /// Maximum number of Detach IP retries. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "detach_ip_retry_limit")]
        public int? DetachIpRetryLimit { get; set; }
        /// <summary>
        /// Time to wait before marking Detach IP as failed. Field introduced in 21.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "detach_ip_timeout")]
        public int? DetachIpTimeout { get; set; }
        /// <summary>
        /// Period for refresh pool and gslb DNS job. Unit is MIN. Allowed in Basic(Allowed values- 60) edition, Essentials(Allowed
        /// values- 60) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dns_refresh_period")]
        public int? DnsRefreshPeriod { get; set; }
        /// <summary>
        /// Number of dummy.
        /// </summary>
        [JsonProperty(PropertyName = "dummy")]
        public int? Dummy { get; set; }
        /// <summary>
        /// Allow editing of system limits. Keep in mind that these system limits have been carefully selected based on rigorous
        /// testing in our testig environments. Modifying these limits could destabilize your cluster. Do this at your own risk!.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "edit_system_limits")]
        public bool? EditSystemLimits { get; set; }
        /// <summary>
        /// This setting enables the controller leader to shard API requests to the followers (if any). Field introduced in 18.1.5,
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_api_sharding")]
        public bool? EnableApiSharding { get; set; }
        /// <summary>
        /// Enable/Disable Memory Balancer. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "enable_memory_balancer")]
        public bool? EnableMemoryBalancer { get; set; }
        /// <summary>
        /// Enable stopping of individual processes if process cross the given threshold limit, even when the total controller
        /// memory usage is belowits threshold limit. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_per_process_stop")]
        public bool? EnablePerProcessStop { get; set; }
        /// <summary>
        /// Enable printing of cached logs inside Resource Manager. Used for debugging purposes only. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable_resmgr_log_cache_print")]
        public bool? EnableResmgrLogCachePrint { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "fatal_error_lease_time")]
        public int? FatalErrorLeaseTime { get; set; }
        /// <summary>
        /// Federated datastore will not cleanup diffs unless they are at least this duration in the past. Field introduced in
        /// 20.1.1. Unit is HOURS.
        /// </summary>
        [JsonProperty(PropertyName = "federated_datastore_cleanup_duration")]
        public long? FederatedDatastoreCleanupDuration { get; set; }
        /// <summary>
        /// Period for file object cleanup job. Field introduced in 20.1.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "file_object_cleanup_period")]
        public int? FileObjectCleanupPeriod { get; set; }
        /// <summary>
        /// Number of max_dead_se_in_grp.
        /// </summary>
        [JsonProperty(PropertyName = "max_dead_se_in_grp")]
        public int? MaxDeadSeInGrp { get; set; }
        /// <summary>
        /// Maximum number of pcap files stored per tenant.
        /// </summary>
        [JsonProperty(PropertyName = "max_pcap_per_tenant")]
        public int? MaxPcapPerTenant { get; set; }
        /// <summary>
        /// Maximum delay possible to add to se_spawn_retry_interval after successive SE spawn failure. Field introduced in 20.1.1.
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "max_se_spawn_interval_delay")]
        public int? MaxSeSpawnIntervalDelay { get; set; }
        /// <summary>
        /// Maximum number of consecutive attach IP failures that halts VS placement. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "max_seq_attach_ip_failures")]
        public int? MaxSeqAttachIpFailures { get; set; }
        /// <summary>
        /// Number of max_seq_vnic_failures.
        /// </summary>
        [JsonProperty(PropertyName = "max_seq_vnic_failures")]
        public int? MaxSeqVnicFailures { get; set; }
        /// <summary>
        /// Maximum number of threads in threadpool used by cloud connector CCVIPBGWorker. Allowed values are 1-100. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "max_threads_cc_vip_bg_worker")]
        public int? MaxThreadsCcVipBgWorker { get; set; }
        /// <summary>
        /// Network and VrfContext objects from the admin tenant will not be shared to non-admin tenants unless admin permissions
        /// are granted. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "permission_scoped_shared_admin_networks")]
        public bool? PermissionScopedSharedAdminNetworks { get; set; }
        /// <summary>
        /// Period for rotate app persistence keys job. Allowed values are 1-1051200. Special values are 0 - Disabled. Unit is MIN.
        /// Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_key_rotate_period")]
        public int? PersistenceKeyRotatePeriod { get; set; }
        /// <summary>
        /// Burst limit on number of incoming requests. 0 to disable. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "portal_request_burst_limit")]
        public int? PortalRequestBurstLimit { get; set; }
        /// <summary>
        /// Maximum average number of requests allowed per second. 0 to disable. Field introduced in 20.1.1. Unit is PER_SECOND.
        /// </summary>
        [JsonProperty(PropertyName = "portal_request_rate_limit")]
        public int? PortalRequestRateLimit { get; set; }
        /// <summary>
        /// Token used for uploading tech-support to portal. Field introduced in 16.4.6,17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "portal_token")]
        public string? PortalToken { get; set; }
        /// <summary>
        /// Period for process locked user accounts job. Field introduced in 18.1.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "process_locked_useraccounts_timeout_period")]
        public int? ProcessLockedUseraccountsTimeoutPeriod { get; set; }
        /// <summary>
        /// Period for process PKI profile job. Field introduced in 18.1.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "process_pki_profile_timeout_period")]
        public int? ProcessPkiProfileTimeoutPeriod { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "query_host_fail")]
        public int? QueryHostFail { get; set; }
        /// <summary>
        /// Period for each cycle of log caching in Resource Manager. At the end of each cycle, the in memory cached log history
        /// will be cleared. Field introduced in 20.1.5. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "resmgr_log_caching_period")]
        public int? ResmgrLogCachingPeriod { get; set; }
        /// <summary>
        /// Version of the safenet package installed on the controller. Field introduced in 16.5.2,17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "safenet_hsm_version")]
        public string? SafenetHsmVersion { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_create_timeout")]
        public int? SeCreateTimeout { get; set; }
        /// <summary>
        /// Interval between attempting failovers to an SE. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_failover_attempt_interval")]
        public int? SeFailoverAttemptInterval { get; set; }
        /// <summary>
        /// This setting decides whether SE is to be deployed from the cloud marketplace or to be created by the controller. The
        /// setting is applicable only when BYOL license is selected. Enum options - MARKETPLACE, IMAGE_SE. Field introduced in
        /// 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_from_marketplace")]
        public string? SeFromMarketplace { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_offline_del")]
        public int? SeOfflineDel { get; set; }
        /// <summary>
        /// Default retry period before attempting another Service Engine spawn in SE Group. Field introduced in 20.1.1. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_spawn_retry_interval")]
        public int? SeSpawnRetryInterval { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_vnic_cooldown")]
        public int? SeVnicCooldown { get; set; }
        /// <summary>
        /// Duration to wait after last vNIC addition before proceeding with vNIC garbage collection. Used for testing purposes.
        /// Field introduced in 20.1.4. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "se_vnic_gc_wait_time")]
        public int? SeVnicGcWaitTime { get; set; }
        /// <summary>
        /// Period for secure channel cleanup job. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "secure_channel_cleanup_timeout")]
        public int? SecureChannelCleanupTimeout { get; set; }
        /// <summary>
        /// Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "secure_channel_controller_token_timeout")]
        public int? SecureChannelControllerTokenTimeout { get; set; }
        /// <summary>
        /// Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "secure_channel_se_token_timeout")]
        public int? SecureChannelSeTokenTimeout { get; set; }
        /// <summary>
        /// This parameter defines the number of simultaneous SE image downloads in a SeGroup. It is used to pace the SE downloads
        /// so that controller network/CPU bandwidth is a bounded operation. A value of 0 will disable the pacing scheme and all the
        /// SE(s) in the SeGroup will attempt to download the image. . Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_copy_pool_size")]
        public int? SeupgradeCopyPoolSize { get; set; }
        /// <summary>
        /// Pool size used for all fabric commands during se upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_fabric_pool_size")]
        public int? SeupgradeFabricPoolSize { get; set; }
        /// <summary>
        /// Time to wait before marking segroup upgrade as stuck. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_segroup_min_dead_timeout")]
        public int? SeupgradeSegroupMinDeadTimeout { get; set; }
        /// <summary>
        /// SSL Certificates in the admin tenant can be used in non-admin tenants. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "shared_ssl_certificates")]
        public bool? SharedSslCertificates { get; set; }
        /// <summary>
        /// Number of days for SSL Certificate expiry warning. Unit is DAYS.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_certificate_expiry_warning_days")]
        public int? SslCertificateExpiryWarningDays { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "unresponsive_se_reboot")]
        public int? UnresponsiveSeReboot { get; set; }
        /// <summary>
        /// Time to account for DNS TTL during upgrade. This is in addition to vs_scalein_timeout_for_upgrade in se_group. Field
        /// introduced in 17.1.1. Unit is SEC. Allowed in Basic(Allowed values- 5) edition, Essentials(Allowed values- 5) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_dns_ttl")]
        public int? UpgradeDnsTtl { get; set; }
        /// <summary>
        /// Amount of time Controller waits for a large-sized SE (>=128GB memory) to reconnect after it is rebooted during upgrade.
        /// Field introduced in 18.2.10, 20.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_fat_se_lease_time")]
        public int? UpgradeFatSeLeaseTime { get; set; }
        /// <summary>
        /// Amount of time Controller waits for a regular-sized SE (<128GB memory) to reconnect after it is rebooted during upgrade.
        /// Starting 18.2.10/20.1.1, the default time has increased from 360 seconds to 600 seconds. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_lease_time")]
        public int? UpgradeLeaseTime { get; set; }
        /// <summary>
        /// This parameter defines the upper-bound value of the VS scale-in or VS scale-out operation executed in the SeScaleIn and
        /// SeScale context.  User can tweak this parameter to a higher value if the Segroup gets suspended due to SeScalein or
        /// SeScaleOut timeout failure typically associated with high number of VS(es) scaled out. . Field introduced in 18.2.10,
        /// 20.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_se_per_vs_scale_ops_txn_time")]
        public int? UpgradeSePerVsScaleOpsTxnTime { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Configuration for User-Agent Cache used in Bot Management. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "user_agent_cache_config")]
        public NSXTALBUserAgentCacheConfigType UserAgentCacheConfig { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_op_fail_time")]
        public int? VnicOpFailTime { get; set; }
        /// <summary>
        /// Time to wait for the scaled out SE to become ready before marking the scaleout done, applies to APIC configuration only.
        /// Field deprecated in 21.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_apic_scaleout_timeout")]
        public int? VsApicScaleoutTimeout { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_awaiting_se_timeout")]
        public int? VsAwaitingSeTimeout { get; set; }
        /// <summary>
        /// Period for rotate VS keys job. Allowed values are 1-1051200. Special values are 0 - Disabled. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "vs_key_rotate_period")]
        public int? VsKeyRotatePeriod { get; set; }
        /// <summary>
        /// Interval for checking scaleout_ready status while controller is waiting for ScaleOutReady RPC from the Service Engine.
        /// Field introduced in 18.2.2. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_scaleout_ready_check_interval")]
        public int? VsScaleoutReadyCheckInterval { get; set; }
        /// <summary>
        /// Time to wait before marking attach IP operation on an SE as failed. Field introduced in 17.2.2. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_attach_ip_fail")]
        public int? VsSeAttachIpFail { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_bootup_fail")]
        public int? VsSeBootupFail { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_create_fail")]
        public int? VsSeCreateFail { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_ping_fail")]
        public int? VsSePingFail { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_vnic_fail")]
        public int? VsSeVnicFail { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vs_se_vnic_ip_fail")]
        public int? VsSeVnicIpFail { get; set; }
        /// <summary>
        /// vSphere HA monitor detection timeout. If vsphere_ha_enabled is true and the controller is not able to reach the SE,
        /// placement will wait for this duration for vsphere_ha_inprogress to be marked true before taking corrective action. Field
        /// introduced in 20.1.7, 21.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_ha_detection_timeout")]
        public int? VsphereHaDetectionTimeout { get; set; }
        /// <summary>
        /// vSphere HA monitor recovery timeout. Once vsphere_ha_inprogress is set to true (meaning host failure detected and
        /// vSphere HA will recover the Service Engine), placement will wait for at least this duration for the SE to reconnect to
        /// the controller before taking corrective action. Field introduced in 20.1.7, 21.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_ha_recovery_timeout")]
        public int? VsphereHaRecoveryTimeout { get; set; }
        /// <summary>
        /// vSphere HA monitor timer interval for sending cc_check_se_status to Cloud Connector. Field introduced in 20.1.7, 21.1.3.
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_ha_timer_interval")]
        public int? VsphereHaTimerInterval { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "warmstart_se_reconnect_wait_time")]
        public int? WarmstartSeReconnectWaitTime { get; set; }
        /// <summary>
        /// Timeout for warmstart VS resync. Field introduced in 18.1.4, 18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "warmstart_vs_resync_wait_time")]
        public int? WarmstartVsResyncWaitTime { get; set; }
    }
}
