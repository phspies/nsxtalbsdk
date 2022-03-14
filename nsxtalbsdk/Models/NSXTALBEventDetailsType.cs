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
    public class NSXTALBEventDetailsType 
    {
        public NSXTALBEventDetailsType()
        {
        }
        /// <summary>
        /// Adaptive replication event e.g. DNS VS, config version. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "adaptrepl_event")]
        public NSXTALBAdaptReplEventInfoType AdaptreplEvent { get; set; }
        /// <summary>
        /// Placeholder for description of property add_networks_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "add_networks_details")]
        public NSXTALBRmAddNetworksEventDetailsType AddNetworksDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property albservices_case_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "albservices_case_details")]
        public NSXTALBALBServicesCaseType AlbservicesCaseDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property albservices_file_upload_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "albservices_file_upload_details")]
        public NSXTALBALBServicesFileUploadType AlbservicesFileUploadDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property albservices_status_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "albservices_status_details")]
        public NSXTALBALBServicesStatusDetailsType AlbservicesStatusDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property all_seupgrade_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "all_seupgrade_event_details")]
        public NSXTALBAllSeUpgradeEventDetailsType AllSeupgradeEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property anomaly_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_details")]
        public NSXTALBAnomalyEventDetailsType AnomalyDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property api_version_deprecated of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "api_version_deprecated")]
        public NSXTALBApiVersionDeprecatedType ApiVersionDeprecated { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_agent_bd_vrf_details")]
        public NSXTALBApicAgentBridgeDomainVrfChangeType ApicAgentBdVrfDetails { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_agent_generic_details")]
        public NSXTALBApicAgentGenericEventDetailsType ApicAgentGenericDetails { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_agent_vs_network_error")]
        public NSXTALBApicAgentVsNetworkErrorType ApicAgentVsNetworkError { get; set; }
        /// <summary>
        /// Placeholder for description of property app_signature_event_data of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "app_signature_event_data")]
        public NSXTALBAppSignatureEventDataType AppSignatureEventData { get; set; }
        /// <summary>
        /// Details for Attach IP status. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "attach_ip_status_details")]
        public NSXTALBAttachIpStatusEventDetailsType AttachIpStatusDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_uptime_change_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "avg_uptime_change_details")]
        public NSXTALBAvgUptimeChangeDetailsType AvgUptimeChangeDetails { get; set; }
        /// <summary>
        /// Field introduced in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "aws_asg_deletion_details")]
        public NSXTALBAWSASGDeleteType AwsAsgDeletionDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property aws_asg_notif_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "aws_asg_notif_details")]
        public NSXTALBAWSASGNotifDetailsType AwsAsgNotifDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property aws_infra_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "aws_infra_details")]
        public NSXTALBAWSSetupType AwsInfraDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property azure_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "azure_info")]
        public NSXTALBAzureSetupType AzureInfo { get; set; }
        /// <summary>
        /// Azure marketplace license term acceptance event. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "azure_mp_info")]
        public NSXTALBAzureMarketplaceType AzureMpInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property bind_vs_se_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "bind_vs_se_details")]
        public NSXTALBRmBindVsSeEventDetailsType BindVsSeDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property bm_infra_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "bm_infra_details")]
        public NSXTALBBMSetupType BmInfraDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property bootup_fail_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "bootup_fail_details")]
        public NSXTALBRmSeBootupFailEventDetailsType BootupFailDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property burst_checkout_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "burst_checkout_details")]
        public NSXTALBBurstLicenseDetailsType BurstCheckoutDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_cluster_vip_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_cluster_vip_details")]
        public NSXTALBCloudClusterVipType CcClusterVipDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_dns_update_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_dns_update_details")]
        public NSXTALBCloudDnsUpdateType CcDnsUpdateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_health_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_health_details")]
        public NSXTALBCloudHealthType CcHealthDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_infra_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_infra_details")]
        public NSXTALBCloudGenericType CcInfraDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_ip_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_ip_details")]
        public NSXTALBCloudIpChangeType CcIpDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_parkintf_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_parkintf_details")]
        public NSXTALBCloudVipParkingIntfType CcParkintfDetails { get; set; }
        /// <summary>
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "cc_scaleset_notif_details")]
        public NSXTALBCCScaleSetNotifDetailsType CcScalesetNotifDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_se_vm_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_se_vm_details")]
        public NSXTALBCloudSeVmChangeType CcSeVmDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_sync_services_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_sync_services_details")]
        public NSXTALBCloudSyncServicesType CcSyncServicesDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_tenant_del_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_tenant_del_details")]
        public NSXTALBCloudTenantsDeletedType CcTenantDelDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_vip_update_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_vip_update_details")]
        public NSXTALBCloudVipUpdateType CcVipUpdateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cc_vnic_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cc_vnic_details")]
        public NSXTALBCloudVnicChangeType CcVnicDetails { get; set; }
        /// <summary>
        /// Central license refresh details. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "central_license_refresh_details")]
        public NSXTALBCentralLicenseRefreshDetailsType CentralLicenseRefreshDetails { get; set; }
        /// <summary>
        /// Central license subscription details. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "central_license_subscription_details")]
        public NSXTALBCentralLicenseSubscriptionDetailsType CentralLicenseSubscriptionDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cloud_asg_notif_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cloud_asg_notif_details")]
        public NSXTALBCloudASGNotifDetailsType CloudAsgNotifDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cloud_autoscaling_config_failure_details of obj type EventDetails field type str
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "cloud_autoscaling_config_failure_details")]
        public NSXTALBCloudAutoscalingConfigFailureDetailsType CloudAutoscalingConfigFailureDetails { get; set; }
        /// <summary>
        /// Cloud Routes event. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_route_notif_details")]
        public NSXTALBCloudRouteNotifDetailsType CloudRouteNotifDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_config_failed_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_config_failed_details")]
        public NSXTALBClusterConfigFailedEventType ClusterConfigFailedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_leader_failover_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_leader_failover_details")]
        public NSXTALBClusterLeaderFailoverEventType ClusterLeaderFailoverDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_node_add_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_node_add_details")]
        public NSXTALBClusterNodeAddEventType ClusterNodeAddDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_node_db_failed_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_node_db_failed_details")]
        public NSXTALBClusterNodeDbFailedEventType ClusterNodeDbFailedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_node_remove_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_node_remove_details")]
        public NSXTALBClusterNodeRemoveEventType ClusterNodeRemoveDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_node_shutdown_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_node_shutdown_details")]
        public NSXTALBClusterNodeShutdownEventType ClusterNodeShutdownDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_node_started_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_node_started_details")]
        public NSXTALBClusterNodeStartedEventType ClusterNodeStartedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_service_critical_failure_details of obj type EventDetails field type str
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_service_critical_failure_details")]
        public NSXTALBClusterServiceCriticalFailureEventType ClusterServiceCriticalFailureDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_service_failed_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_service_failed_details")]
        public NSXTALBClusterServiceFailedEventType ClusterServiceFailedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_service_restored_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_service_restored_details")]
        public NSXTALBClusterServiceRestoredEventType ClusterServiceRestoredDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cluster_warm_reboot_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cluster_warm_reboot_details")]
        public NSXTALBClusterWarmRebootEventType ClusterWarmRebootDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cntlr_host_list_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cntlr_host_list_details")]
        public NSXTALBVinfraCntlrHostUnreachableListType CntlrHostListDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_action_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "config_action_details")]
        public NSXTALBConfigActionDetailsType ConfigActionDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_create_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "config_create_details")]
        public NSXTALBConfigCreateDetailsType ConfigCreateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_delete_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "config_delete_details")]
        public NSXTALBConfigDeleteDetailsType ConfigDeleteDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_password_change_request_details of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "config_password_change_request_details")]
        public NSXTALBConfigUserPasswordChangeRequestType ConfigPasswordChangeRequestDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_se_grp_flv_update_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "config_se_grp_flv_update_details")]
        public NSXTALBConfigSeGrpFlvUpdateType ConfigSeGrpFlvUpdateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_update_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "config_update_details")]
        public NSXTALBConfigUpdateDetailsType ConfigUpdateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_user_authrz_rule_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "config_user_authrz_rule_details")]
        public NSXTALBConfigUserAuthrzByRuleType ConfigUserAuthrzRuleDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_user_login_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "config_user_login_details")]
        public NSXTALBConfigUserLoginType ConfigUserLoginDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_user_logout_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "config_user_logout_details")]
        public NSXTALBConfigUserLogoutType ConfigUserLogoutDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property config_user_not_authrz_rule_details of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "config_user_not_authrz_rule_details")]
        public NSXTALBConfigUserNotAuthrzByRuleType ConfigUserNotAuthrzRuleDetails { get; set; }
        /// <summary>
        /// Connection event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "connection_event")]
        public NSXTALBConnectionEventDetailsType ConnectionEvent { get; set; }
        /// <summary>
        /// Placeholder for description of property container_cloud_batch_setup of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "container_cloud_batch_setup")]
        public NSXTALBContainerCloudBatchSetupType ContainerCloudBatchSetup { get; set; }
        /// <summary>
        /// Placeholder for description of property container_cloud_setup of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "container_cloud_setup")]
        public NSXTALBContainerCloudSetupType ContainerCloudSetup { get; set; }
        /// <summary>
        /// Placeholder for description of property container_cloud_sevice of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "container_cloud_sevice")]
        public NSXTALBContainerCloudServiceType ContainerCloudSevice { get; set; }
        /// <summary>
        /// Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "controller_discontinuous_time_change_event_details")]
        public NSXTALBControllerDiscontinuousTimeChangeEventDetailsType ControllerDiscontinuousTimeChangeEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property controller_license_reconcile_details of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "controller_license_reconcile_details")]
        public NSXTALBControllerLicenseReconcileDetailsType ControllerLicenseReconcileDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property crs_deployment_failure of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "crs_deployment_failure")]
        public NSXTALBCRSDeploymentFailureType CrsDeploymentFailure { get; set; }
        /// <summary>
        /// Placeholder for description of property crs_deployment_success of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "crs_deployment_success")]
        public NSXTALBCRSDeploymentSuccessType CrsDeploymentSuccess { get; set; }
        /// <summary>
        /// Placeholder for description of property crs_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "crs_details")]
        public NSXTALBCRSDetailsType CrsDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property crs_update_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "crs_update_details")]
        public NSXTALBCRSUpdateDetailsType CrsUpdateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property cs_infra_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cs_infra_details")]
        public NSXTALBCloudStackSetupType CsInfraDetails { get; set; }
        /// <summary>
        /// Database error event. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "database_event_info")]
        public NSXTALBDatabaseEventInfoType DatabaseEventInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property delete_se_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "delete_se_details")]
        public NSXTALBRmDeleteSeEventDetailsType DeleteSeDetails { get; set; }
        /// <summary>
        /// Details for Detach IP status. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "detach_ip_status_details")]
        public NSXTALBDetachIpStatusEventDetailsType DetachIpStatusDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property disable_se_migrate_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "disable_se_migrate_details")]
        public NSXTALBDisableSeMigrateEventDetailsType DisableSeMigrateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property disc_summary of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "disc_summary")]
        public NSXTALBVinfraDiscSummaryDetailsType DiscSummary { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_query_error of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dns_query_error")]
        public NSXTALBDNSQueryErrorType DnsQueryError { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_sync_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dns_sync_info")]
        public NSXTALBDNSVsSyncInfoType DnsSyncInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property docker_ucp_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "docker_ucp_details")]
        public NSXTALBDockerUCPSetupType DockerUcpDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property dos_attack_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dos_attack_event_details")]
        public NSXTALBDosAttackEventDetailsType DosAttackEventDetails { get; set; }
        /// <summary>
        /// False positive details. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "false_positive_details")]
        public NSXTALBFalsePositiveDetailsType FalsePositiveDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property gcp_cloud_router_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "gcp_cloud_router_info")]
        public NSXTALBGCPCloudRouterUpdateType GcpCloudRouterInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property gcp_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "gcp_info")]
        public NSXTALBGCPSetupType GcpInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property generic_audit_compliance_event_info of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "generic_audit_compliance_event_info")]
        public NSXTALBAuditComplianceEventInfoType GenericAuditComplianceEventInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property glb_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "glb_info")]
        public NSXTALBGslbStatusType GlbInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property gs_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "gs_info")]
        public NSXTALBGslbServiceStatusType GsInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property host_unavail_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "host_unavail_details")]
        public NSXTALBHostUnavailEventDetailsType HostUnavailDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property hs_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hs_details")]
        public NSXTALBHealthScoreDetailsType HsDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_fail_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_fail_details")]
        public NSXTALBRmSeIpFailEventDetailsType IpFailDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_threat_db_event_data of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_threat_db_event_data")]
        public NSXTALBIPThreatDBEventDataType IpThreatDbEventData { get; set; }
        /// <summary>
        /// Placeholder for description of property license_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "license_details")]
        public NSXTALBLicenseDetailsType LicenseDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property license_expiry_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "license_expiry_details")]
        public NSXTALBLicenseExpiryDetailsType LicenseExpiryDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property license_tier_switch_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "license_tier_switch_details")]
        public NSXTALBLicenseTierSwitchDetiailsType LicenseTierSwitchDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property license_transaction_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "license_transaction_details")]
        public NSXTALBLicenseTransactionDetailsType LicenseTransactionDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property log_agent_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_event_details")]
        public NSXTALBLogAgentEventDetailType LogAgentEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property marathon_service_port_conflict_details of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "marathon_service_port_conflict_details")]
        public NSXTALBMarathonServicePortConflictType MarathonServicePortConflictDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property memory_balancer_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "memory_balancer_info")]
        public NSXTALBMemoryBalancerInfoType MemoryBalancerInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property mesos_infra_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "mesos_infra_details")]
        public NSXTALBMesosSetupType MesosInfraDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property metric_threshold_up_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "metric_threshold_up_details")]
        public NSXTALBMetricThresoldUpDetailsType MetricThresholdUpDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_db_disk_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "metrics_db_disk_details")]
        public NSXTALBMetricsDbDiskEventDetailsType MetricsDbDiskDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_db_queue_full_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "metrics_db_queue_full_details")]
        public NSXTALBMetricsDbQueueFullEventDetailsType MetricsDbQueueFullDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_db_queue_healthy_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "metrics_db_queue_healthy_details")]
        public NSXTALBMetricsDbQueueHealthyEventDetailsType MetricsDbQueueHealthyDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_db_sync_failure_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "metrics_db_sync_failure_details")]
        public NSXTALBMetricsDbSyncFailureEventDetailsType MetricsDbSyncFailureDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property mgmt_nw_change_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_nw_change_details")]
        public NSXTALBVinfraMgmtNwChangeDetailsType MgmtNwChangeDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property modify_networks_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "modify_networks_details")]
        public NSXTALBRmModifyNetworksEventDetailsType ModifyNetworksDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property network_subnet_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "network_subnet_details")]
        public NSXTALBNetworkSubnetInfoType NetworkSubnetDetails { get; set; }
        /// <summary>
        /// NSX-T ServiceInsertion VirtualEndpoint event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_endpoint_details")]
        public NSXTALBNsxtSIEndpointDetailsType NsxtEndpointDetails { get; set; }
        /// <summary>
        /// Nsxt Image event. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_img_details")]
        public NSXTALBNsxtImageDetailsType NsxtImgDetails { get; set; }
        /// <summary>
        /// Nsxt cloud event. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_info")]
        public NSXTALBNsxtSetupType NsxtInfo { get; set; }
        /// <summary>
        /// NSX-T ServiceInsertion RedirectPolicy event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_policy_details")]
        public NSXTALBNsxtSIPolicyDetailsType NsxtPolicyDetails { get; set; }
        /// <summary>
        /// NSX-T ServiceInsertion RedirectRule event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_rule_details")]
        public NSXTALBNsxtSIRuleDetailsType NsxtRuleDetails { get; set; }
        /// <summary>
        /// NSX-T ServiceInsertion Service event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_service_details")]
        public NSXTALBNsxtSIServiceDetailsType NsxtServiceDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property nw_subnet_clash_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "nw_subnet_clash_details")]
        public NSXTALBNetworkSubnetClashType NwSubnetClashDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property nw_summarized_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "nw_summarized_details")]
        public NSXTALBSummarizedInfoType NwSummarizedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property oci_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "oci_info")]
        public NSXTALBOCISetupType OciInfo { get; set; }
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "os_api_ver_check_failure")]
        public NSXTALBOpenStackApiVersionCheckFailureType OsApiVerCheckFailure { get; set; }
        /// <summary>
        /// Placeholder for description of property os_infra_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "os_infra_details")]
        public NSXTALBOpenStackClusterSetupType OsInfraDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property os_ip_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "os_ip_details")]
        public NSXTALBOpenStackIpChangeType OsIpDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property os_lbaudit_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "os_lbaudit_details")]
        public NSXTALBOpenStackLbProvAuditCheckType OsLbauditDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property os_lbplugin_op_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "os_lbplugin_op_details")]
        public NSXTALBOpenStackLbPluginOpType OsLbpluginOpDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property os_se_vm_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "os_se_vm_details")]
        public NSXTALBOpenStackSeVmChangeType OsSeVmDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property os_sync_services_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "os_sync_services_details")]
        public NSXTALBOpenStackSyncServicesType OsSyncServicesDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property os_vnic_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "os_vnic_details")]
        public NSXTALBOpenStackVnicChangeType OsVnicDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_deployment_failure_info of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "pool_deployment_failure_info")]
        public NSXTALBPoolDeploymentFailureInfoType PoolDeploymentFailureInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_deployment_success_info of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "pool_deployment_success_info")]
        public NSXTALBPoolDeploymentSuccessInfoType PoolDeploymentSuccessInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_deployment_update_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "pool_deployment_update_info")]
        public NSXTALBPoolDeploymentUpdateInfoType PoolDeploymentUpdateInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_server_delete_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "pool_server_delete_details")]
        public NSXTALBVinfraPoolServerDeleteDetailsType PoolServerDeleteDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property psm_program_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "psm_program_details")]
        public NSXTALBPsmProgramDetailsType PsmProgramDetails { get; set; }
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter_event_details")]
        public NSXTALBRateLimiterEventDetailsType RateLimiterEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property rebalance_migrate_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rebalance_migrate_details")]
        public NSXTALBRebalanceMigrateEventDetailsType RebalanceMigrateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property rebalance_scalein_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rebalance_scalein_details")]
        public NSXTALBRebalanceScaleinEventDetailsType RebalanceScaleinDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property rebalance_scaleout_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rebalance_scaleout_details")]
        public NSXTALBRebalanceScaleoutEventDetailsType RebalanceScaleoutDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property reboot_se_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "reboot_se_details")]
        public NSXTALBRmRebootSeEventDetailsType RebootSeDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property scheduler_action_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "scheduler_action_info")]
        public NSXTALBSchedulerActionDetailsType SchedulerActionInfo { get; set; }
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_bgp_peer_down_details")]
        public NSXTALBSeBgpPeerDownDetailsType SeBgpPeerDownDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_bgp_peer_state_change_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "se_bgp_peer_state_change_details")]
        public NSXTALBSeBgpPeerStateChangeDetailsType SeBgpPeerStateChangeDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_details")]
        public NSXTALBSeMgrEventDetailsType SeDetails { get; set; }
        /// <summary>
        /// Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "se_discontinuous_time_change_event_details")]
        public NSXTALBSeDiscontinuousTimeChangeEventDetailsType SeDiscontinuousTimeChangeEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_dupip_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_dupip_event_details")]
        public NSXTALBSeDupipEventDetailsType SeDupipEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_gateway_heartbeat_failed_details of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "se_gateway_heartbeat_failed_details")]
        public NSXTALBSeGatewayHeartbeatFailedDetailsType SeGatewayHeartbeatFailedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_gateway_heartbeat_success_details of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "se_gateway_heartbeat_success_details")]
        public NSXTALBSeGatewayHeartbeatSuccessDetailsType SeGatewayHeartbeatSuccessDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_geo_db_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_geo_db_details")]
        public NSXTALBSeGeoDbDetailsType SeGeoDbDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_hb_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_hb_event_details")]
        public NSXTALBSeHBEventDetailsType SeHbEventDetails { get; set; }
        /// <summary>
        /// Inter-SE datapath heartbeat recovered. One event is generated when heartbeat recovers. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_hb_recovered_event_details")]
        public NSXTALBSeHbRecoveredEventDetailsType SeHbRecoveredEventDetails { get; set; }
        /// <summary>
        /// Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_high_ingress_proc_latency_event_details")]
        public NSXTALBSeHighIngressProcLatencyEventDetailsType SeHighIngressProcLatencyEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_hm_gs_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_hm_gs_details")]
        public NSXTALBSeHmEventGSDetailsType SeHmGsDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_hm_gsgroup_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_hm_gsgroup_details")]
        public NSXTALBSeHmEventGslbPoolDetailsType SeHmGsgroupDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_hm_pool_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_hm_pool_details")]
        public NSXTALBSeHmEventPoolDetailsType SeHmPoolDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_hm_vs_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_hm_vs_details")]
        public NSXTALBSeHmEventVsDetailsType SeHmVsDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_ip6_dad_failed_event_details of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "se_ip6_dad_failed_event_details")]
        public NSXTALBSeIP6DadFailedEventDetailsType SeIp6DadFailedEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_ip_added_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_ip_added_event_details")]
        public NSXTALBSeIpAddedEventDetailsType SeIpAddedEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_ip_removed_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_ip_removed_event_details")]
        public NSXTALBSeIpRemovedEventDetailsType SeIpRemovedEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_ipfailure_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_ipfailure_event_details")]
        public NSXTALBSeIpfailureEventDetailsType SeIpfailureEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_licensed_bandwdith_exceeded_event_details of obj type EventDetails field type
        /// str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_licensed_bandwdith_exceeded_event_details")]
        public NSXTALBSeLicensedBandwdithExceededEventDetailsType SeLicensedBandwdithExceededEventDetails { get; set; }
        /// <summary>
        /// Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_memory_limit_event_details")]
        public NSXTALBSeMemoryLimitEventDetailsType SeMemoryLimitEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_persistence_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_persistence_details")]
        public NSXTALBSePersistenceEventDetailsType SePersistenceDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_pool_lb_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_pool_lb_details")]
        public NSXTALBSePoolLbEventDetailsType SePoolLbDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_reconcile_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_reconcile_details")]
        public NSXTALBSeReconcileDetailsType SeReconcileDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_thresh_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_thresh_event_details")]
        public NSXTALBSeThreshEventDetailsType SeThreshEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_vnic_down_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_vnic_down_event_details")]
        public NSXTALBSeVnicDownEventDetailsType SeVnicDownEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_vnic_tx_queue_stall_event_details of obj type EventDetails field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "se_vnic_tx_queue_stall_event_details")]
        public NSXTALBSeVnicTxQueueStallEventDetailsType SeVnicTxQueueStallEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property se_vnic_up_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_vnic_up_event_details")]
        public NSXTALBSeVnicUpEventDetailsType SeVnicUpEventDetails { get; set; }
        /// <summary>
        /// VS Flows disrupted when a VS was deleted from SE. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_vs_del_flows_disrupted")]
        public NSXTALBSeVsDelFlowsDisruptedType SeVsDelFlowsDisrupted { get; set; }
        /// <summary>
        /// Placeholder for description of property se_vs_fault_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_vs_fault_event_details")]
        public NSXTALBSeVsFaultEventDetailsType SeVsFaultEventDetails { get; set; }
        /// <summary>
        /// Field introduced in 18.2.11,20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_vs_pkt_buf_high_event_details")]
        public NSXTALBSeVsPktBufHighEventDetailsType SeVsPktBufHighEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property sec_mgr_data_event of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "sec_mgr_data_event")]
        public NSXTALBSecMgrDataEventType SecMgrDataEvent { get; set; }
        /// <summary>
        /// Security-mgr UA Cache event details. Field introduced in 21.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "sec_mgr_ua_event_details")]
        public NSXTALBSecMgrUAEventDetailsType SecMgrUaEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property secure_key_exchange_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "secure_key_exchange_info")]
        public NSXTALBSecureKeyExchangeDetailsType SecureKeyExchangeInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property semigrate_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "semigrate_event_details")]
        public NSXTALBSeMigrateEventDetailsType SemigrateEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property server_autoscale_failed_info of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "server_autoscale_failed_info")]
        public NSXTALBServerAutoScaleFailedInfoType ServerAutoscaleFailedInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property server_autoscalein_complete_info of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "server_autoscalein_complete_info")]
        public NSXTALBServerAutoScaleInCompleteInfoType ServerAutoscaleinCompleteInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property server_autoscalein_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "server_autoscalein_info")]
        public NSXTALBServerAutoScaleInInfoType ServerAutoscaleinInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property server_autoscaleout_complete_info of obj type EventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "server_autoscaleout_complete_info")]
        public NSXTALBServerAutoScaleOutCompleteInfoType ServerAutoscaleoutCompleteInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property server_autoscaleout_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "server_autoscaleout_info")]
        public NSXTALBServerAutoScaleOutInfoType ServerAutoscaleoutInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property seupgrade_disrupted_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_disrupted_details")]
        public NSXTALBSeUpgradeVsDisruptedEventDetailsType SeupgradeDisruptedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property seupgrade_event_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_event_details")]
        public NSXTALBSeUpgradeEventDetailsType SeupgradeEventDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property seupgrade_migrate_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_migrate_details")]
        public NSXTALBSeUpgradeMigrateEventDetailsType SeupgradeMigrateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property seupgrade_scalein_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_scalein_details")]
        public NSXTALBSeUpgradeScaleinEventDetailsType SeupgradeScaleinDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property seupgrade_scaleout_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "seupgrade_scaleout_details")]
        public NSXTALBSeUpgradeScaleoutEventDetailsType SeupgradeScaleoutDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property spawn_se_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "spawn_se_details")]
        public NSXTALBRmSpawnSeEventDetailsType SpawnSeDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_expire_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ssl_expire_details")]
        public NSXTALBSSLExpireDetailsType SslExpireDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_export_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ssl_export_details")]
        public NSXTALBSSLExportDetailsType SslExportDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_ignored_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ssl_ignored_details")]
        public NSXTALBSSLIgnoredDetailsType SslIgnoredDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_renew_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ssl_renew_details")]
        public NSXTALBSSLRenewDetailsType SslRenewDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_renew_failed_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ssl_renew_failed_details")]
        public NSXTALBSSLRenewFailedDetailsType SslRenewFailedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_revoked_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ssl_revoked_details")]
        public NSXTALBSSLRevokedDetailsType SslRevokedDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property switchover_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "switchover_details")]
        public NSXTALBSwitchoverEventDetailsType SwitchoverDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property switchover_fail_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "switchover_fail_details")]
        public NSXTALBSwitchoverFailEventDetailsType SwitchoverFailDetails { get; set; }
        /// <summary>
        /// Azure cloud sync services event details. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sync_services_info")]
        public NSXTALBCloudSyncServicesType SyncServicesInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property tencent_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "tencent_info")]
        public NSXTALBTencentSetupType TencentInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property unbind_vs_se_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "unbind_vs_se_details")]
        public NSXTALBRmUnbindVsSeEventDetailsType UnbindVsSeDetails { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_entry")]
        public NSXTALBUpgradeOpsEntryType UpgradeEntry { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_status_info")]
        public NSXTALBUpgradeStatusInfoType UpgradeStatusInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property vca_infra_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vca_infra_details")]
        public NSXTALBVCASetupType VcaInfraDetails { get; set; }
        /// <summary>
        /// VCenter Cluster event. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_cluster_details")]
        public NSXTALBVcenterClusterDetailsType VcenterClusterDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_connectivity_status of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_connectivity_status")]
        public NSXTALBVinfraVcenterConnectivityStatusType VcenterConnectivityStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_details")]
        public NSXTALBVinfraVcenterBadCredentialsType VcenterDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_disc_failure of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_disc_failure")]
        public NSXTALBVinfraVcenterDiscoveryFailureType VcenterDiscFailure { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_network_limit of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_network_limit")]
        public NSXTALBVinfraVcenterNetworkLimitType VcenterNetworkLimit { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_obj_delete_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_obj_delete_details")]
        public NSXTALBVinfraVcenterObjDeleteDetailsType VcenterObjDeleteDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vip_autoscale of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip_autoscale")]
        public NSXTALBVipScaleDetailsType VipAutoscale { get; set; }
        /// <summary>
        /// Placeholder for description of property vip_dns_info of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip_dns_info")]
        public NSXTALBDNSRegisterInfoType VipDnsInfo { get; set; }
        /// <summary>
        /// Details for VIP Symmetry. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vip_symmetry_details")]
        public NSXTALBVipSymmetryDetailsType VipSymmetryDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vm_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vm_details")]
        public NSXTALBVinfraVmDetailsType VmDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_awaitingse_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_awaitingse_details")]
        public NSXTALBVsAwaitingSeEventDetailsType VsAwaitingseDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_error_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_error_details")]
        public NSXTALBVsErrorEventDetailsType VsErrorDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_fsm_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_fsm_details")]
        public NSXTALBVsFsmEventDetailsType VsFsmDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_initialplacement_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_initialplacement_details")]
        public NSXTALBVsInitialPlacementEventDetailsType VsInitialplacementDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_migrate_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_migrate_details")]
        public NSXTALBVsMigrateEventDetailsType VsMigrateDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_pool_nw_fltr_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_pool_nw_fltr_details")]
        public NSXTALBVsPoolNwFilterEventDetailsType VsPoolNwFltrDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_scalein_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_scalein_details")]
        public NSXTALBVsScaleInEventDetailsType VsScaleinDetails { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_scaleout_details of obj type EventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_scaleout_details")]
        public NSXTALBVsScaleOutEventDetailsType VsScaleoutDetails { get; set; }
        /// <summary>
        /// Details for Primary Switchover status. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vs_switchover_details")]
        public NSXTALBVsSwitchoverEventDetailsType VsSwitchoverDetails { get; set; }
    }
}
