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
    public class NSXTALBServerAutoScaleOutInfoType 
    {
        /// <summary>
        /// alertconfig_name of ServerAutoScaleOutInfo.
        /// </summary>
        [JsonProperty(PropertyName = "alertconfig_name")]
        public string? AlertconfigName { get; set; }
        /// <summary>
        /// It is a reference to an object of type AlertConfig.
        /// </summary>
        [JsonProperty(PropertyName = "alertconfig_ref")]
        public string? AlertconfigRef { get; set; }
        /// <summary>
        /// Placeholder for description of property available_capacity of obj type ServerAutoScaleOutInfo field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "available_capacity")]
        public double? AvailableCapacity { get; set; }
        /// <summary>
        /// Placeholder for description of property load of obj type ServerAutoScaleOutInfo field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "load")]
        public double? Load { get; set; }
        /// <summary>
        /// Number of num_scaleout_servers.
        /// </summary>
        [JsonProperty(PropertyName = "num_scaleout_servers", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int NumScaleoutServers { get; set; }
        /// <summary>
        /// Number of num_servers_up.
        /// </summary>
        [JsonProperty(PropertyName = "num_servers_up", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int NumServersUp { get; set; }
        /// <summary>
        /// UUID of the Pool. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolRef { get; set; }
        /// <summary>
        /// reason of ServerAutoScaleOutInfo.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Enum options - SYSERR_SUCCESS, SYSERR_FAILURE, SYSERR_OUT_OF_MEMORY, SYSERR_NO_ENT, SYSERR_INVAL, SYSERR_ACCESS,
        /// SYSERR_FAULT, SYSERR_IO, SYSERR_TIMEOUT, SYSERR_NOT_SUPPORTED, SYSERR_NOT_READY, SYSERR_UPGRADE_IN_PROGRESS,
        /// SYSERR_WARM_START_IN_PROGRESS, SYSERR_TRY_AGAIN, SYSERR_NOT_UPGRADING, SYSERR_PENDING, SYSERR_EVENT_GEN_FAILURE,
        /// SYSERR_CONFIG_PARAM_MISSING, SYSERR_RANGE, SYSERR_BAD_REQUEST, SYSERR_TEST1, SYSERR_TEST2,
        /// SYSERR_QUEUE_TRANSPORT_FAILURE, SYSERR_QUEUE_RETRY_TASK, SYSERR_QUEUE_FULL, SYSERR_DATASTORE_TRANSPORT_FAILURE,
        /// SYSERR_DATASTORE_UNKNOWN_FAILURE, SYSERR_DATASTORE_OBJECT_DOES_NOT_EXIST, SYSERR_DATASTORE_REFERENCE_DOES_NOT_EXIST,
        /// SYSERR_DATASTORE_DB_LOCKED, SYSERR_DATASTORE_LOCK_FAILURE, SYSERR_DATASTORE_TBL_NOT_EXIST,
        /// SYSERR_DATABASE_OBJECT_DOES_NOT_EXIST, SYSERR_SVC_COMMON_OBJECT_NOT_IN_CACHED_VIEW, SYSERR_RPC_CANCELED_BY_CLIENT,
        /// SYSERR_RPC_TIMED_OUT, SYSERR_RPC_SEND_FAILED, SYSERR_RPC_CANCELED_BY_TRANSACTION_CLEANUP, SYSERR_NO_MULTICAST_RECEIVERS,
        /// SYSERR_RPC_FAILED, SYSERR_RPC_CONNECT_FAILED, SYSERR_CONTROLLER_NOT_READY, SYSERR_VERSION_MISMATCH,
        /// SYSERR_ALREADY_REGISTERED, SYSERR_SE_GRP_CHANGE_REBOOT, SYSERR_INVALID_METHOD, SYSERR_DESERIALIZATION,
        /// SYSERR_SERIALIZATION, SYSERR_ENQUEUE, SYSERR_DEQUEUE, SYSERR_INVALID_READ_LEVEL, SYSERR_ADD_HM_PHM_OBJECT_NOT_FOUND,
        /// SYSERR_CREATE_INVALID_PERSISTENCE_TYPE, SYSERR_VS_INVALID_METHOD, SYSERR_VS_NOT_PRESENT, SYSERR_VS_INVALID_REQUEST,
        /// SYSERR_VS_NOT_ENOUGH_RESOURCES, SYSERR_VS_SE_NOT_AVAILABLE, SYSERR_VS_VNIC_FAILURE,
        /// SYSERR_VS_DELETE_WHILE_STILL_BEING_REFERRED, SYSERR_INVALID_HEALTH_MONITOR_TYPE, SYSERR_VS_SE_ASSIGNMENT_FAILED,
        /// SYSERR_VS_INVALID_OBJECT, SYSERR_VS_SERVICE_ENGINE_DOWN, SYSERR_VS_RPC_FAILURE, SYSERR_VS_NOT_BOUND, SYSERR_VS_DISABLED,
        /// SYSERR_VS_INTERNAL_ERROR, SYSERR_VS_SCALEOUT_ERROR, SYSERR_VS_SCALEIN_ERROR, SYSERR_VS_MIGRATE_ERROR,
        /// SYSERR_VS_MIGRATE_SCALEOUT_ERROR, SYSERR_VS_MIGRATE_SCALEIN_ERROR, SYSERR_VS_AWAIT_STATIC_SE,
        /// SYSERR_VS_MIN_SE_NOT_ASSIGNED, SYSERR_VS_SE_NOT_AT_CURRENT_VERSION, SYSERR_VS_RUNTIME_ABSENT, SYSERR_VS_STATEDB_ERR,
        /// SYSERR_VS_SNI_CHILD_PARENT_SELIST_MISMATCH, SYSERR_VS_SNI_PARENT_NOT_FOUND, SYSERR_VS_SNI_CHILD_PARENT_SEGROUP_MISMATCH,
        /// SYSERR_VS_STATS_INDEX_NOT_AVAILABLE, SYSERR_VS_UPDATE_FAILED, SYSERR_VS_CREATE_FAILED,
        /// SYSERR_VS_GEO_DATABASES_NOT_LOADED, SYSERR_VS_FQDN_LEN_EXCEEDED, SYSERR_VS_STATIC_FQDN_LEN_EXCEEDED,
        /// SYSERR_VS_DNS_TXT_RDATA_LEN_EXCEEDED, SYSERR_SE_MGR_VNIC_ALLOC_FAIL, SYSERR_SE_MGR_VNIC_NOT_FOUND,
        /// SYSERR_SE_MGR_UNKNOWN_SE, SYSERR_SE_MGR_UNKNOWN_STATE_TRANSITION, SYSERR_SE_MGR_SE_OFFLINE_HB_FAILURE,
        /// SYSERR_SE_UPGRADE_IN_PROGRESS, SYSERR_SE_NOT_CONNECTED, SYSERR_RM_RES_UNAVAIL, SYSERR_RM_RES_UNAVAIL_NOTIFY,
        /// SYSERR_RM_RES_NOT_INUSE, SYSERR_RM_CONSUMER_NOT_FOUND, SYSERR_RM_REACHABILITY_FAILED, SYSERR_RM_RELEASE_SE_UNAVAIL,
        /// SYSERR_RM_UNKNOWN_SE_GROUP, SYSERR_RM_NO_SE_FOUND, SYSERR_RM_PARTIAL_SE_FOUND, SYSERR_RM_AWAIT_VM_CREATE,
        /// SYSERR_RM_AWAIT_VNIC_ADD, SYSERR_RM_AWAIT_BOOTUP, SYSERR_RM_RESOURCE_NOT_FOUND, SYSERR_RM_CANNOT_SPAWN_SE,
        /// SYSERR_RM_RES_NOT_NEEDED, SYSERR_RM_RES_INFRA_DELETED, SYSERR_RM_RES_USER_DELETED, SYSERR_RM_RES_USER_REBOOTED,
        /// SYSERR_RM_RES_CRASHED, SYSERR_RM_RES_CONN_LOST, SYSERR_RM_RES_VIP_REACH_LOST, SYSERR_RM_VS_PROCESSING,
        /// SYSERR_RM_VNIC_IP_FAILURE, SYSERR_RM_STATIC_NO_POOL, SYSERR_RM_STATIC_POOL_EXHAUSTED, SYSERR_RM_VIP_MULT_NETWORKS,
        /// SYSERR_RM_SRVR_MULT_NETWORKS, SYSERR_RM_VIP_NO_NETWORK, SYSERR_RM_SRVR_NO_NETWORK, SYSERR_RM_MAX_PARALLEL_SE_CREATE,
        /// SYSERR_RM_MAX_SE_CREATE_ATTEMPTS, SYSERR_RM_MULT_SE_CRASH, SYSERR_RM_VS_SE_CREATE_IN_PROG,
        /// SYSERR_RM_VS_SE_BOOTUP_IN_PROG, SYSERR_RM_VS_SE_VNIC_ADD_IN_PROG, SYSERR_RM_VS_SE_VNIC_IP_IN_PROG,
        /// SYSERR_RM_NO_SUITABLE_HOST, SYSERR_RM_NO_SE_IN_SE_GRP, SYSERR_RM_ALL_SE_IN_SE_GRP_DOWN,
        /// SYSERR_RM_NO_SE_IN_SE_GRP_SRVR_ACC, SYSERR_RM_NO_SE_IN_SE_GRP_VIP_ACC, SYSERR_RM_ALL_SE_IN_SE_GRP_MAX_VS,
        /// SYSERR_RM_ALL_SE_IN_SE_GRP_NW_ACC_MAX_VS, SYSERR_RM_VIP_SE_NW_ACC, SYSERR_RM_VIP_SE_MAX_VS,
        /// SYSERR_RM_VIP_SE_GRP_MISMATCH, SYSERR_RM_VIP_SE_PENDING_OP, SYSERR_RM_MULT_MGMT_SUBNET, SYSERR_RM_MAX_SE_IN_GRP,
        /// SYSERR_RM_BOOTUP_FAILURE, SYSERR_RM_PENDING_VNIC_OP, SYSERR_RM_SE_MGMT_NO_STATIC_IPS_CONFIGURED,
        /// SYSERR_RM_SE_MGMT_STATIC_IPS_EXHAUSTED, SYSERR_RM_NO_MGMT_SUBNET, SYSERR_RM_MGMT_DHCP_FAILURE,
        /// SYSERR_RM_CANNOT_ADD_VNICS, SYSERR_RM_CONSUMER_RESOURCES_SATISFIED, SYSERR_RM_DATA_DHCP_FAILURE,
        /// SYSERR_RM_QUERY_HOST_IN_PROGRESS, SYSERR_RM_INSUFFICIENT_BUFFER_SE, SYSERR_RM_NO_DEFAULT_GW_SE_MGMT_NW,
        /// SYSERR_RM_PARENT_SE_NW_ACC, SYSERR_RM_PARENT_SE_MAX_VS, SYSERR_RM_PARENT_SE_GRP_MISMATCH, SYSERR_RM_DEF_GW_INCORRECT,
        /// SYSERR_RM_NETWORK_NOT_FOUND, SYSERR_RM_ALL_SE_IN_SE_GRP_USED, SYSERR_RM_SE_GRP_PENDING_OP,
        /// SYSERR_RM_ALL_SE_IN_SE_GRP_DISABLED, SYSERR_RM_VS_SE_PING_CHECK_IN_PROG, SYSERR_RM_CONSUMER_PENDING_TASK,
        /// SYSERR_RM_SE_GRP_VIP_NW_ACC, SYSERR_RM_SE_GRP_NW_ACC, SYSERR_RM_SE_GRP_MAX_VS, SYSERR_RM_ALL_SE_IN_SE_GRP_GW_DOWN,
        /// SYSERR_RM_SE_GW_DOWN, SYSERR_RM_SE_DISCONNECTED, SYSERR_RM_RES_USER_DISABLED_FORCE, SYSERR_RM_VS_SE_ATTACH_IP_IN_PROG,
        /// SYSERR_RM_LICENSE_EXCEEDED_CANNOT_SPAWN_SE, SYSERR_RM_RES_SWTICHOVER_FORCE, SYSERR_RM_HA_HOST_UNAVAILABLE,
        /// SYSERR_RM_RES_USER_DISABLED, SYSERR_RM_NO_BGP_PEER_ADVERTISE_VIP, SYSERR_RM_NO_BGP_PEER_ADVERTISE_SNAT,
        /// SYSERR_RM_SRVR_NETWORK_NOT_FOUND, SYSERR_RM_VRF_NOT_FOUND, SYSERR_RM_BGP_NETWORK_NOT_FOUND,
        /// SYSERR_RM_VIP_NETWORK_NOT_FOUND, SYSERR_RM_READ_MISSING_FILTER, SYSERR_RM_CLOUD_NOT_FOUND, SYSERR_RM_SEGROUP_NOT_FOUND,
        /// SYSERR_RM_SE_OFFLINE, SYSERR_RM_SE_USED, SYSERR_RM_SE_BGP_PEERS_DOWN, SYSERR_VI_MGR_SEVM_VNIC_SUCCESS,
        /// SYSERR_VI_MGR_SEVM_CREATE_FAIL_NO_HW_INFO, SYSERR_VI_MGR_SEVM_CREATE_FAIL_DUPLICATE_NAME,
        /// SYSERR_VI_MGR_SEVM_CREATE_FAIL_NO_MGMT_NW, SYSERR_VI_MGR_SEVM_CREATE_FAIL_NO_CPU, SYSERR_VI_MGR_SEVM_CREATE_FAIL_NO_MEM,
        /// SYSERR_VI_MGR_SEVM_CREATE_FAIL_NO_LEASE, SYSERR_VI_MGR_SEVM_CREATE_FAIL_OVF_ERROR,
        /// SYSERR_VI_MGR_SEVM_CREATE_NO_HOST_VM_NETWORK, SYSERR_VI_MGR_SEVM_CREATE_FAIL_NO_PROGRESS,
        /// SYSERR_VI_MGR_SEVM_CREATE_FAIL_ABORTED, SYSERR_VI_MGR_SEVM_CREATE_FAILURE, SYSERR_VI_MGR_SEVM_CREATE_FAIL_POWER_ON,
        /// SYSERR_VI_MGR_SEVM_VNIC_NO_VM, SYSERR_VI_MGR_SEVM_VNIC_MAC_ADDR_ERROR, SYSERR_VI_MGR_SEVM_VNIC_FAILURE,
        /// SYSERR_VI_MGR_SEVM_VNIC_NO_PG_PORTS, SYSERR_VI_MGR_SEVM_DELETE_FAILURE, SYSERR_VI_MGR_SEVM_CREATE_LIMIT_REACHED,
        /// SYSERR_VI_MGR_SEVM_SET_MGMT_IP_FAILED, SYSERR_VI_MGR_SEVM_CREATE_ACCESS_ERROR, SYSERR_VI_MGR_SEVM_CREATE_NO_IMAGE,
        /// SYSERR_VI_MGR_SEVM_VINFRA_UNINITIALIZED, SYSERR_VI_MGR_SEVM_CREATE_NO_HOST,
        /// SYSERR_VI_MGR_SEVM_CREATE_FAIL_NO_MGMT_NW_PORTS, SYSERR_VI_MGR_SEVM_INVALID_DATA,
        /// SYSERR_VI_MGR_SEVM_CREATE_FAIL_MULTIPLE_MGMT_NW, SYSERR_VI_MGR_SEVM_VCENTER_CONN_FAIL, SYSERR_VI_MGR_SEVM_TIMED_OUT,
        /// SYSERR_VI_MGR_SEVM_NO_SOURCE_CLONE, SYSERR_VI_MGR_SEVM_NO_AVAILABILITY_ZONE, SYSERR_VI_MGR_SEVM_FLAVOR_UNAVAIL,
        /// SYSERR_VI_MGR_SEVM_DELETED, SYSERR_VI_MGR_SEVM_VINFRA_FAILURE, SYSERR_VI_MGR_SEVM_VNIC_FAILURE_QUESTION,
        /// SYSERR_VI_MGR_LOGIN_FAIL_NO_VCENTER, SYSERR_VI_MGR_LOGIN_FAIL_USER_CREDENTIALS, SYSERR_VI_MGR_VCENTER_VERSION_MISMATCH,
        /// SYSERR_DB_CACHE_TBL_NOT_FOUND, SYSERR_DB_CACHE_OBJ_NOT_FOUND, SYSERR_DB_QUERY_QUEUED, SYSERR_DB_QUERY_BATCHED,
        /// SYSERR_DB_UPDATE_FAILED, SYSERR_DB_QUERY_FAILED, SYSERR_DB_ENQUEUE_FULL, SYSERR_OS_AGENT_Q_FULL,
        /// SYSERR_OS_AGENT_OPENSTACK_UNINITIALIZED, SYSERR_OS_AGENT_OPENSTACK_ACCESSERR, SYSERR_OS_AGENT_OPENSTACK_RESOURCEERR,
        /// SYSERR_OS_AGENT_TENANT_ABSENT, SYSERR_OS_AGENT_INVALID_DATA, SYSERR_CC_SVC_Q_FULL, SYSERR_CC_AGENT_UNINITIALIZED,
        /// SYSERR_CC_AGENT_ACCESSERR, SYSERR_CC_AGENT_RESOURCEERR, SYSERR_CC_AGENT_TENANT_ACCESSERR, SYSERR_CC_AGENT_TENANT_ABSENT,
        /// SYSERR_CC_SVC_INVALID_DATA, SYSERR_CC_OS_AGENT_NEUTRON_HOST_ACCESSERR, SYSERR_CC_NO_FLAVOR, SYSERR_CC_AGENT_ABSENT,
        /// SYSERR_CC_AGENT_CONFIG_FAILURE, SYSERR_CC_AGENT_DECONFIG_FAILURE, SYSERR_CC_AGENT_NON_INFRA_SEVM,
        /// SYSERR_MESOS_DISCOVERY_DEPLOYMENT_FAIL, SYSERR_MESOS_DISCOVERY_TIMEOUT, SYSERR_MARATHON_APP_TERMINATED,
        /// SYSERR_MARATHON_INACCESSIBLE, SYSERR_FLEET_API_ERROR, SYSERR_MESOS_SSH_CMD_TIMEOUT, SYSERR_MESOS_SSH_ABORTED,
        /// SYSERR_MESOS_SSH_FAILURE, SYSERR_MESOS_SSH_NOTFOUND, SYSERR_CC_AGENT_VNIC_NO_IPS_AVAILABLE,
        /// SYSERR_CC_AGENT_VNIC_NO_SUBNETWORK, SYSERR_CC_AGENT_VNIC_FAILURE, SYSERR_CC_AGENT_SCALE_IN_FAILED,
        /// SYSERR_CC_AGENT_DS_FAILED, SYSERR_CC_AGENT_SCALE_OUT_FAILED, SYSERR_CC_TOO_BUSY, SYSERR_CC_AGENT_NOT_IMPLEMENTED,
        /// SYSERR_CC_AGENT_METHOD_NOT_IMPLEMENTED, SYSERR_CC_AGENT_GENERIC_FAILURE, SYSERR_RUM_TOOMANYSAMPLES,
        /// SYSERR_METRICS_TOO_MANY_MSG, SYSERR_METRICS_TOO_MANY_MSG_ACROSS_ENTITIES, SYSERR_ANOMALYZER_NOT_ENOUGH_SAMPLES,
        /// SYSERR_AUTOSCALE_REASON_INTELLIGENT_AUTOSCALE, SYSERR_AUTOSCALE_REASON_CONFIG_UPDATE,
        /// SYSERR_AUTOSCALE_REASON_POOL_STATE_CHANGE, SYSERR_AUTOSCALE_REASON_ALERT, SYSERR_AUTOSCALEIN_FAILED_LIMIT_EXCEEDED,
        /// SYSERR_AUTOSCALEOUT_FAILED_LIMIT_EXCEEDED, SYSERR_AUTOSCALE_IGNORED_AS_WITHIN_COOLDOWN,
        /// SYSERR_AUTOSCALE_ORCHESTRATION_TIMEOUT, SYSERR_AUTOSCALE_REASON_NOT_ENOUGH_SERVERS,
        /// SYSERR_AUTOSCALE_REASON_TOO_MANY_SERVERS, SYSERR_AUTOSCALE_REASON_ORCHESTRATION_FAILED, SYSERR_AUTOSCALE_REASON_MANUAL,
        /// SYSERR_AUTOSCALE_POLICY_NOT_FOUND, SYSERR_AUTOSCALE_REASON_GARBAGE_COLLECTION, SYSERR_AUTOSCALE_SCHEDULED_SCALEIN,
        /// SYSERR_AUTOSCALE_SCHEDULED_SCALEOUT, SYSERR_LICENSE_FIELD_NAME_NOT_SET, SYSERR_LICENSE_FILE_NOT_FOUND,
        /// SYSERR_LICENSE_FIELD_VALID_UNTIL_NOT_SET, SYSERR_LICENSE_INVALID_TIERS, SYSERR_LICENSE_FIELD_LICENSE_ID_NOT_PRESENT,
        /// SYSERR_LICENSE_INVALID_VERSION, SYSERR_LICENSE_DECRYPTION_FAILED, SYSERR_LICENSE_ENFORCEMENT_KEY_NOT_VALID,
        /// SYSERR_LICENSE_INVALID_SERIALKEY, SYSERR_LICENSE_INVALID_METRICS, SYSERR_LICENSE_GRPC_NOT_READY,
        /// SYSERR_LATEST_LICENSE_ALREADY_DEPLOYED, SYSERR_LICENSE_MGR_GRPC_NOT_READY, SYSERR_LICENSE_TRANSACTION_TENANT_REQUIRED,
        /// SYSERR_LICENSE_TRANSACTION_INSUFFICIENT_RESOURCES, SYSERR_LICENSE_TRANSACTION_PER_TENANT_NOT_SUPPORTED,
        /// SYSERR_FLOATING_LICENSE_NOT_SUPPORTED, SYSERR_LICENSE_MGR_CANNOT_DELETE_LICENSE,
        /// SYSERR_LICENSE_MGR_LICENSE_TIER_NOT_FOUND, SYSERR_LICENSE_EXPIRED, SYSERR_LICENSE_LEDGER_UPDATE_FAILED,
        /// SYSERR_LICENSE_TRANSACTION_INSUFFICIENT_SAAS_LICENSE, SYSERR_LICENSE_TRANSACTION_MAX_SERVICE_UNITS_LIMIT,
        /// SYSERR_LICENSE_SAAS_UNSUBSCRIBED, SYSERR_LICENSE_SAAS_SYNC_RPC_ERROR, SYSERR_LICENSE_SAAS_SYNC_CONNECT_ERROR,
        /// SYSERR_LICENSE_SAAS_SYNC_SERVER_ERROR, SYSERR_LICENSE_SAAS_SYNC_INSUFFICIENT_LICENSE,
        /// SYSERR_LICENSE_TRANSACTION_INCORRECT_TIER, SYSERR_SEAGENT_OBJ_INACTIVE, SYSERR_SEAGENT_OBJ_AWAITING_DP_PROGRAMMING,
        /// SYSERR_SEAGENT_OBJ_ACTIVE, SYSERR_SEAGENT_OBJ_GRAPHDB_ERROR, SYSERR_SEAGENT_OBJ_DP_ERROR,
        /// SYSERR_SEAGENT_OBJ_DISABLED_RULE_POOL, SYSERR_SEAGENT_EASTWEST_VS_SUBNET_ERROR, SYSERR_SEAGENT_OBJ_NOT_FOUND,
        /// SYSERR_SEAGENT_VS_NOT_FOUND, SYSERR_SEAGENT_VS_VRF_ERROR, SYSERR_SEAGENT_VS_SELIST_LIMIT_ERROR,
        /// SYSERR_SEAGENT_VS_SELIST_SE_INTF_ERROR, SYSERR_SEAGENT_VS_CHILD_PARENT_UUID_MISSING,
        /// SYSERR_SEDP_PARENT_VS_NOT_EXIST_FOR_CHILD, SYSERR_SEAGENT_TENANT_CREATE_FAILED, SYSERR_SEAGENT_TENANT_UPDATE_FAILED,
        /// SYSERR_SEAGENT_VS_INTERFACE_ERROR, SYSERR_SEAGENT_INSUFFICIENT_MEMORY, SYSERR_SEDP_VNIC_CREATION_FAILURE,
        /// SYSERR_SEDP_VNIC_ATTACH_FAILURE, SYSERR_SEDP_VNIC_IF_CREATION_FAILURE, SYSERR_SEDP_VNIC_START_FAILURE,
        /// SYSERR_SEDP_VNIC_NOT_FOUND, SYSERR_SEDP_VNIC_MISMATCH_VRF, SYSERR_SEDP_VNIC_IP_ADDR_ADD_FAILURE,
        /// SYSERR_SEDP_VNIC_IP_ADDR_DEL_FAILURE, SYSERR_SEDP_VNIC_OWNER_CORE_NOT_FOUND, SYSERR_SEDP_VNIC_MAIN_VNIC_NOT_FOUND,
        /// SYSERR_SEDP_VNIC_MEMBER_VNIC_NOT_FOUND, SYSERR_SEDP_VNIC_VLAN_FILTER_ADD_FAILURE,
        /// SYSERR_SEDP_VNIC_VLAN_FILTER_REMOVE_FAILURE, SYSERR_SEDP_VNIC_UNKNOWN_MSG_TYPE, SYSERR_SEDP_VNIC_PCAP_INIT_FAILURE,
        /// SYSERR_GSLB_INVALID_MTYPE, SYSERR_GSLB_INVALID_SITE_CREDENTIALS, SYSERR_GSLB_OBJECT_NOT_FOUND, SYSERR_GSLB_INVALID_OPS,
        /// SYSERR_GSLB_PARTIAL_SUCCESS, SYSERR_GSLB_FQDN_CONFLICT, SYSERR_GSLB_CLEANUP_IN_PROGRESS, SYSERR_GSLB_METHOD_NOP,
        /// SYSERR_GSLB_API_NOT_SUPPORTED_FOR_UNFEDERATED_OBJECTS, SYSERR_GSLB_STATEDB_ERR,
        /// SYSERR_GSLB_SERVICE_MEMBER_VIPS_NOT_IN_SYNC, SYSERR_GSLB_SERVICE_MEMBER_DISABLED, SYSERR_GSLB_SITE_DISABLED,
        /// SYSERR_GSLB_SERVICE_DISABLED, SYSERR_GSLB_HM_PROXY_DOWN, SYSERR_GSLB_DNS_DISABLED,
        /// SYSERR_GSLB_SERVICE_NON_AVI_VIP_INFO_UNAVAILABLE, SYSERR_GSLB_SERVICE_DATAPATH_STATUS_UNAVAILABLE,
        /// SYSERR_GSLB_SERVICE_MEMBER_SERVICES_NOT_IN_SYNC, SYSERR_GSLB_SERVICE_INCONSISTENT_APPLICATION_PROFILE,
        /// SYSERR_GSLB_SERVICE_INVALID_APPLICATION_PROFILE, SYSERR_GSLB_SERVICE_SP_INCONSISTENT_CONFIGURED_SERVERS,
        /// SYSERR_GSLB_SERVICE_SP_INCONSISTENT_OPERATIONAL_SERVERS, SYSERR_GSLB_SERVICE_SP_ALL_SERVERS_DOWN,
        /// SYSERR_GSLB_SERVICE_SP_SOME_SERVERS_DOWN, SYSERR_GSLB_CONFIGURED_VS_IS_NOT_A_DNS_VS, SYSERR_GSLB_NOT_CONFIGURED,
        /// SYSERR_GSLB_INVALID_SENDER, SYSERR_GSLB_INVALID_SENDER_STATE, SYSERR_GSLB_INVALID_RX_ID, SYSERR_GSLB_INVALID_VIEW_ID,
        /// SYSERR_GSLB_GROUP_CONFLICT, SYSERR_GSLB_INVALID_MTYPE_AT_FOLLOWER, SYSERR_GSLB_LEADER_NOT_IN_LIST,
        /// SYSERR_GSLB_SERVICE_CTRL_STATUS_UNAVAILABLE, SYSERR_GSLB_SITE_FSM_NULL, SYSERR_GSLB_SITE_FSM_DISABLE_IN_PROGRESS,
        /// SYSERR_GSLB_SITE_FSM_DISABLED, SYSERR_GSLB_SITE_FSM_JOIN_IN_PROGRESS, SYSERR_GSLB_SITE_FSM_INIT,
        /// SYSERR_GSLB_SITE_FSM_UNREACHABLE, SYSERR_GSLB_SITE_FSM_LEAVE_IN_PROGRESS, SYSERR_GSLB_SITE_FSM_MMODE,
        /// SYSERR_GSLB_SITE_ACTIVE_TO_PASSIVE_TRANSITION, SYSERR_GSLB_SITE_PASSIVE_TO_ACTIVE_TRANSITION,
        /// SYSERR_GSLB_SITE_MAX_RETRIES_DONE, SYSERR_GSLB_TIMEOUT, SYSERR_GSLB_CONNECTION_TIMEOUT,
        /// SYSERR_GSLB_CONNECTION_REFUSED_ERROR, SYSERR_GSLB_SERVICE_CTRL_STATUS_NA_DUE_TO_UNREACHABLE_SITE,
        /// SYSERR_GSLB_SERVICE_SP_NO_CONFIGURED_SERVERS, SYSERR_GSLB_INVALID_OBJECT, SYSERR_GSLB_SERVICE_POOL_DISABLED,
        /// SYSERR_GSLB_SERVICE_CREATE_FAILED, SYSERR_GSLB_SERVICE_UPDATE_FAILED, SYSERR_GSLB_GSLB_GEO_FILE_NOT_PRESENT,
        /// SYSERR_GSLB_SERVICE_MEMBER_VS_SERVICES_NOT_IN_SYNC, SYSERR_GSLB_SERVICE_MEMBER_VS_SP_POOL_NOT_IN_SYNC,
        /// SYSERR_DNS_POLICY_CREATE_FAIL, SYSERR_DNS_POLICY_UPDATE_FAIL, SYSERR_LCM_CORE_NOT_COPIED_DUE_TO_MAX_LIMIT,
        /// SYSERR_LCM_CORE_NOT_COPIED_INSUFFICIENT_DISK_SIZE, SYSERR_LCM_SKIP_SIMILAR_CORE,
        /// SYSERR_LCM_CORE_NOT_COPIED_DUE_TO_ERRORS, SYSERR_LCM_STOP, SYSERR_POOL_SERVER_CAPEST_BREACHED,
        /// SYSERR_POOL_CREATE_FAILED, SYSERR_POOL_UPDATE_FAILED_INCONSISTENT, SYSERR_POOL_UPDATE_FAILED,
        /// SYSERR_POOL_SERVER_STATE_UPDATE_FAILED, SYSERR_POOL_UPDATE_SERVER_FAILED, SYSERR_POOL_UPDATE_LB_ALGO_NO_STATE,
        /// SYSERR_SHM_HASH_INSERT_FAILED, SYSERR_SE_RPC_PROXY_STREAM_NOT_CONNECTED, SYSERR_SE_RPC_PROXY_STREAM_WRITE_FAILED,
        /// SYSERR_SE_RPC_PROXY_UNABLE_TO_FIND_SYNC_RPC, SYSERR_PRST_PROF_OBJECT_TYPE_MISMATCH, SYSERR_PRST_PROF_OBJECT_NOT_FOUND,
        /// SYSERR_PRST_PROF_NULL, SYSERR_PRST_PROF_OBJECT_PRESENT, SYSERR_MS_OBJECT_EXISTS, SYSERR_MS_OBJECT_NOT_FOUND,
        /// SYSERR_MS_GRP_OBJECT_EXISTS, SYSERR_MS_GRP_OBJECT_NOT_FOUND, SYSERR_HTTP_POLICY_CREATE_FAILED,
        /// SYSERR_HTTP_POLICY_CREATE_EXISTS, SYSERR_HTTP_POLICY_CREATE_SHM_INSERT, SYSERR_HTTP_POLICY_UPDATE_FAILED,
        /// SYSERR_STR_GRP_REGISTER_INVAL, SYSERR_STR_GRP_DEREGISTER_INVAL, SYSERR_AG_CREATE_POST_FAILED,
        /// SYSERR_AG_CREATE_PRE_FAILED, SYSERR_AG_UPDATE_FAILED, SYSERR_APP_PROF_UPDATE_TYPE_MISMATCH,
        /// SYSERR_APP_PROF_CREATE_INVALID_TYPE, SYSERR_APP_PROF_UPDATE_PRESERVE_CLIENT_IP_CHANGED, SYSERR_APP_PROF_NOT_FOUND,
        /// SYSERR_POOL_GRP_MEMBER_NOT_FOUND, SYSERR_POOL_GRP_UPDATE_FAILED, SYSERR_POOL_GRP_CREATE_FAILED,
        /// SYSERR_POOL_GRP_UPDATE_FAILED_INCONSISTENT, SYSERR_L4PS_CONNPOL_POOL_FAILED, SYSERR_L4PS_CONNPOL_POOL_GRP_FAILED,
        /// SYSERR_L4PS_CONNPOL_IP_GRP_FAILED, SYSERR_L4PS_CREATE_FAILED, SYSERR_ANT_PROF_NOT_FOUND, SYSERR_LB_CHASH_INVALID_TYPE,
        /// SYSERR_SEC_POLICY_NOT_FOUND, SYSERR_TECH_SUPPORT_COLLECTION_NOT_DONE, SYSERR_TECH_SUPPORT_COLLECTION_SUCCESS,
        /// SYSERR_TECH_SUPPORT_COLLECTION_STARTED, SYSERR_TECH_SUPPORT_COLLECTION_ONGOING,
        /// SYSERR_TECH_SUPPORT_COLLECTION_IN_PROGRESS, SYSERR_TECH_SUPPORT_COLLECTION_SUCCESS_WITH_ERRORS,
        /// SYSERR_TECH_SUPPORT_COLLECTION_ABORTED, SYSERR_TECH_SUPPORT_COLLECTION_STATUS_FILE_NOT_FOUND,
        /// SYSERR_TECH_SUPPORT_INVALID_FILENAME, SYSERR_TECH_SUPPORT_COLLECTION_STATUS_IN_PROGRESS,
        /// SYSERR_TECH_SUPPORT_INPUT_INVALID_LEVEL, SYSERR_TECH_SUPPORT_INPUT_INVALID_SLUG, SYSERR_DATASCRIPT_FAILED,
        /// SYSERR_TECH_SUPPORT_COLLECTION_PREMATURELY_STOPPED, SYSERR_NET_PROF_NOT_FOUND, SYSERR_ALBSVC_FILE_UPLOAD_IN_PROGRESS,
        /// SYSERR_ALBSVC_FILE_UPLOAD_SUCCESS, SYSERR_ALBSVC_FILE_UPLOAD_FAILED, SYSERR_ALBSVC_FILE_UPLOAD_STARTED,
        /// SYSERR_ALBSVC_CASE_ID_MISSING, SYSERR_ALBSVC_ASSET_ID_MISSING, SYSERR_ALBSVC_AUTH_FAILURE,
        /// SYSERR_ALBSVC_REMOTE_SERVER_ERROR, SYSERR_ALBSVC_DISCONNECTED, SYSERR_ALBSVC_DEREGISTERED,
        /// SYSERR_ALBSVC_CANNOT_READ_RESPONSE, SYSERR_ALBSVC_CONTROLLER_ALREADY_REGISTERED, SYSERR_ALBSVC_SESSION_NOT_SET,
        /// SYSERR_ALBSVC_CLIENT_TIME_OUT, SYSERR_ALBSVC_CONNECTION_REFUSED, SYSERR_ALBSVC_HTTP_CLIENT_ERROR,
        /// SYSERR_ALBSVC_RESOURCE_NOT_FOUND, SYSERR_ALBSVC_INVALID_QUERY_PARAM_VALUE, SYSERR_ALBSVC_INVALID_QUERY_PARAM,
        /// SYSERR_ALBSVC_FILE_UPLOAD_CONFLICT, SYSERR_ALBSVC_INTERNAL_ERROR, SYSERR_ALBSVC_PROXY_AUTH_FAILURE,
        /// SYSERR_ALBSVC_LOGIN_URL_NOT_FOUND, SYSERR_ALBSVC_PROXY_CONFIG_PARSE_FAILURE, SYSERR_ALBSVC_LOGIN_REQ_FAILED,
        /// SYSERR_ALBSVC_REGISTRATION_FAILED, SYSERR_ALBSVC_DATABASE_WRITE_ERROR, SYSERR_ALBSVC_DEREGISTRATION_FAILED,
        /// SYSERR_ALBSVC_MALFORMED_PAYLOAD, SYSERR_ALBSVC_CASE_GET_FAILED, SYSERR_ALBSVC_CASE_CREATE_FAILED,
        /// SYSERR_ALBSVC_CASES_GET_FAILED, SYSERR_ALBSVC_CASE_UPDATE_FAILED, SYSERR_ALBSVC_STATUS_REQ_FAILED,
        /// SYSERR_ALBSVC_CRS_DOWNLOAD_FAILED, SYSERR_ALBSVC_CRS_DEPLOY_FAILED, SYSERR_ALBSVC_CRS_DATA_NOT_FOUND,
        /// SYSERR_ALBSVC_DATASTORE_READ_ERROR, SYSERR_ALBSVC_CRS_AUTO_DEPLOY_MALFORMED_URL,
        /// SYSERR_ALBSVC_CRS_DOWNLOAD_SIG_MISMATCH, SYSERR_ALBSVC_CRS_DOWNLOAD_FORBIDDEN, SYSERR_ALBSVC_DATABASE_READ_ERROR,
        /// SYSERR_ALBSVC_AVICLIENT_ERROR, SYSERR_ALBSVC_CRS_AUTODEPLOY_SUCCESS, SYSERR_ALBSVC_EMPTY_METADATA,
        /// SYSERR_ALBSVC_USERS_REQ_FAILED, SYSERR_ALBSVC_USER_DETAIL_REQ_FAILED, SYSERR_ALBSVC_CRS_URL_DECODE_FAILED,
        /// SYSERR_ALBSVC_NAME_RESOLUTION_FAILED, SYSERR_ALBSVC_x509_ERROR, SYSERR_ALBSVC_REGISTRATION_DISABLED,
        /// SYSERR_ALBSVC_FEATURE_OPT_IN_NOT_ENABLED, SYSERR_ALBSVC_USER_AGENT_DB_BATCH_SIZE_EXCEEDED,
        /// SYSERR_ALBSVC_LICENSE_STATUS_CHECK_FAILED, SYSERR_ALBSVC_FEATURE_NOT_ALLOWED, SYSERR_UPGRADE_SYSTEM_STARTED,
        /// SYSERR_UPGRADE_CONTROLLER_STARTED, SYSERR_UPGRADE_SEGROUP_STARTED, SYSERR_RESUME_SEGROUP_STARTED,
        /// SYSERR_PATCH_SYSTEM_STARTED, SYSERR_PATCH_CONTROLLER_STARTED, SYSERR_PATCH_SEGROUP_STARTED,
        /// SYSERR_PATCHSEGROUP_RESUME_STARTED, SYSERR_ROLLBACK_SYSTEM_STARTED, SYSERR_ROLLBACK_CONTROLLER_STARTED,
        /// SYSERR_ROLLBACK_SEGROUP_STARTED, SYSERR_ROLLBACKPATCH_SYSTEM_STARTED, SYSERR_ROLLBACKPATCH_CONTROLLER_STARTED,
        /// SYSERR_ROLLBACKPATCH_SEGROUP_STARTED, SYSERR_UPGRADE_OPS_VS_DISRUPTION_WARNINGS,
        /// SYSERR_UPGRADE_OPS_COMPLIANCE_MODE_TRANSITION_STARTED, SYSERR_UPGRADE_OPS_COMPLIANCE_MODE_ERROR_RECOVERY_STARTED,
        /// SYSERR_UPGRADE_OPS_IN_PROGRESS, SYSERR_UPGRADE_OPS_CHECK_LICENSE, SYSERR_UPGRADE_OPS_CHECK_CLUSTER_STATE,
        /// SYSERR_UPGRADE_OPS_CHECK_CLUSTER_DISK_SPACE, SYSERR_UPGRADE_OPS_CHECK_SE_GROUP_INPROGRESS,
        /// SYSERR_UPGRADE_OPS_CHECK_VERSION_COMPATIBILITY, SYSERR_UPGRADE_OPS_CHECK_SE_REACHABILITY,
        /// SYSERR_UPGRADE_OPS_CHECK_SE_GROUP_CLOUD_READY, SYSERR_UPGRADE_OPS_CHECK_SE_DISK_SPACE,
        /// SYSERR_UPGRADE_OPS_CHECK_VS_DISRUPUTION, SYSERR_UPGRADE_OPS_CHECK_ROLLBACK_BASICS,
        /// SYSERR_UPGRADE_OPS_CHECK_CONTROLLER_VERSION_ROLLBACK, SYSERR_UPGRADE_OPS_CHECK_SE_VERSION_ROLLBACK,
        /// SYSERR_UPGRADE_OPS_CHECK_CONTROLLER_ROLLBACK, SYSERR_UPGRADE_OPS_CHECK_SE_GROUP_ROLLBACK,
        /// SYSERR_UPGRADE_OPS_CHECK_SYSTEM_ROLLBACK, SYSERR_UPGRADE_OPS_CHECK_IMAGE_VERSION,
        /// SYSERR_UPGRADE_OPS_CHECK_DOCKER_DISK_SPACE, SYSERR_UPGRADE_OPS_CHECK_ACTIVE_VERSIONS, SYSERR_UPGRADE_OPS_CHECK_BACKUP,
        /// SYSERR_UPGRADE_OPS_CHECK_SE_GROUP_ERROR_RECOVERY, SYSERR_UPGRADE_OPS_CHECK_SE_GROUP_SUSPENDED,
        /// SYSERR_UPGRADE_OPS_CHECK_SYSTEM_FLAG, SYSERR_UPGRADE_OPS_PREVIEW_RESPONSE,
        /// SYSERR_UPGRADE_OPS_CHECK_PREVIOUS_PARTITION_COMPATIBILITY, SYSERR_UPGRADE_OPS_CHECK_IMAGE_COMPATIBILITY,
        /// SYSERR_UPGRADE_OPS_CHECK_CONTROLLER_PATCH_COMPATIBILITY, SYSERR_UPGRADE_OPS_CHECK_SE_PATCH_COMPATIBILITY,
        /// SYSERR_UPGRADE_OPS_CHECK_SE_ROLLBACK_V1, SYSERR_UPGRADE_OPS_CHECK_ALERTS, SYSERR_UPGRADE_OPS_CHECK_DOCKER_IMAGE,
        /// SYSERR_UPGRADE_OPS_CHECK_UPGRADE_STATE_FOR_RESUME_OPS, SYSERR_UPGRADE_OPS_CHECK_PATCH_IMAGE,
        /// SYSERR_UPGRADE_OPS_CHECK_ALLOW_SE_GROUP_ROLLBACK, SYSERR_UPGRADE_OPS_CHECK_SKIP_SE_GROUPS,
        /// SYSERR_UPGRADE_OPS_CHECK_CLOUD_COMPATIBILITY, SYSERR_UPGRADE_OPS_CHECK_SKIP_ALL_SE_GROUPS,
        /// SYSERR_UPGRADE_OPS_CHECK_MAND_PATCH_ROLLBACK, SYSERR_UPGRADE_OPS_GSLB_FEATURE_CHECK,
        /// SYSERR_UPGRADE_OPS_CONFIGURATION_CHECK, SYSERR_UPGRADE_OPS_AVI_ESSENTIALS_CHECK,
        /// SYSERR_ROLLBACK_OPS_CHECK_VS_DISRUPUTION, SYSERR_UPGRADE_OPS_CHECK_SE_LINUX_ENABLED,
        /// SYSERR_UPGRADE_OPS_CHECK_PREVIOUS_DOCKER_IMAGE, SYSERR_UPGRADE_OPS_DOCKER_VERSION_CHECK,
        /// SYSERR_UPGRADE_OPS_IP_TYPE_CHECK, SYSERR_UPGRADE_OPS_CHECK_SE_LICENSE, SYSERR_MC_UPGRADE_LICENSE_ERR,
        /// SYSERR_MC_UPGRADE_CLUSTER_NOT_READY, SYSERR_MC_DISK_INSUFFICIENT_ERR, SYSERR_MC_CLUSTER_INPROGRESS_ERR,
        /// SYSERR_MC_SEGROUP_INPROGRESS_ERR, SYSERR_MC_UPGRADE_INCOMPATIBLE_IMAGE_AND_PATCH,
        /// SYSERR_MC_UPGRADE_INCOMPATIBLE_FROM_TO_IMAGE, SYSERR_MC_UPGRADE_INCOMPATIBLE_PATCH,
        /// SYSERR_MC_UPGRADE_INCOMPATIBLE_SE_GROUP_IMAGE, SYSERR_MC_SE_UNREACHABLE_ERR, SYSERR_MC_SE_GROUP_CLOUD_NOT_READY_ERR,
        /// SYSERR_MC_UPGRADE_VS_DISRUPTED_ERR, SYSERR_MC_ROLLBACK_NOT_POSSIBLE, SYSERR_MC_SE_ROLLBACK_NOT_POSSIBLE,
        /// SYSERR_MC_ROLLBACK_INFO_ERR, SYSERR_MC_CONTROLLER_ROLLBACK_NOT_POSSIBLE, SYSERR_MC_SYSTEM_ROLLBACK_NOT_POSSIBLE,
        /// SYSERR_MC_IMAGE_INVALID_ERR, SYSERR_MC_ACTIVE_VERSIONS_ERR, SYSERR_MC_BACKUP_ERR, SYSERR_MC_ROLLBACK_ON_ERR,
        /// SYSERR_MC_SUSPENDED_ERR, SYSERR_MC_SYSTEM_FLAG_ERR, SYSERR_MC_PREVIOUS_PARTITION_INCOMPATIBLE_ERR,
        /// SYSERR_MC_IMAGE_VALIDATION_ERR, SYSERR_MC_CONTROLLER_PATCH_ERR, SYSERR_MC_SE_PATCH_ERR, SYSERR_MC_SE_ROLLBACK_V1_ERR,
        /// SYSERR_MC_ALERTS, SYSERR_MC_ROLLBACK_DOCKER_IMAGE_ERR, SYSERR_MC_RESUME_OPS_ERR, SYSERR_MC_CHECK_PATCH_IMAGE_ERR,
        /// SYSERR_MC_CHECK_SE_GROUP_ROLLBACK_ERR, SYSERR_MC_SKIP_SE_GROUPS_ERR, SYSERR_MC_CHECK_CLOUD_COMPATIBILITY_ERR,
        /// SYSERR_MC_SKIP_ALL_SE_GROUPS_ERR, SYSERR_MC_MAND_PATCH_ROLLBACK_ERR, SYSERR_MC_GSLB_LEADER_ERR,
        /// SYSERR_MC_SYSTEM_CONFIGURATION_ERR, SYSERR_MC_AVI_ESSENTIALS_OPERATION_NOT_SUPPORTED_ERROR,
        /// SYSERR_MC_ROLLBACK_VS_DISRUPTED_ERR, SYSERR_MC_SE_LINUX_ENABLED_ERR, SYSERR_MC_PREVIOUS_DOCKER_IMAGE_NOT_PRESENT_ERR,
        /// SYSERR_MC_DOCKER_VERSION_INCOMPATIBLE_ERROR, SYSERR_MC_IP_TYPE_ERR, SYSERR_MC_INVALID_SE_LICENSE_ERR,
        /// SYSERR_VS_NOT_FOUND, SYSERR_DEFAULT_POOL_NOT_FOUND, SYSERR_PROXY_POOL_NOT_FOUND, SYSERR_MISSING_APPLICATION_PROFILE,
        /// SYSERR_APP_PROFILE_NOT_FOUND, SYSERR_WAF_POLICY_NOT_FOUND, SYSERR_DUPLICATE_VS, SYSERR_WRONG_VS_TYPE,
        /// SYSERR_POOL_IN_PG_NOT_FOUND, SYSERR_PG_IN_PG, SYSERR_LB_MODULE_INIT_FAILED, SYSERR_CONNPOOL_MODULE_INIT_FAILED,
        /// SYSERR_LBACTION_MODULE_INIT_FAILED, SYSERR_PG_NOT_FOUND, SYSERR_DUPLICATE_POOL, SYSERR_SSL_PROFILE_NOT_FOUND,
        /// SYSERR_PKI_PROFILE_NOT_FOUND, SYSERR_SSL_CERTKEY_NOT_FOUND, SYSERR_SET_CIPHER_LIST_FAILED,
        /// SYSERR_SET_CIPHER_SUITES_FAILED, SYSERR_WRONG_TLS_VERSION, SYSERR_ERR_PAGE_PROFILE_NO_PAGES,
        /// SYSERR_ERR_PAGE_PROFILE_NOT_FOUND, SYSERR_ERR_PAGE_NOT_FOUND, SYSERR_ERR_PAGE_REDIRECT_NOT_CONFIGURED,
        /// SYSERR_HM_NOT_FOUND, SYSERR_HTTPS_HM_MISSING_CONFIG, SYSERR_SNI_PARENT_UNCONFIGURED, SYSERR_SNI_PARENT_NOT_FOUND,
        /// SYSERR_HTTP_POLICYSET_NOT_FOUND, SYSERR_VSDS_NOT_FOUND, SYSERR_MULTIPLE_SP_POOLS_CONFIGURED,
        /// SYSERR_L4SSL_VS_INVALID_CLIENT_CERT, SYSERR_CR_PROFILE_NOT_FOUND, SYSERR_POOL_NOT_FOUND, SYSERR_LISTEN_PORTS_CFG_FAILED,
        /// SYSERR_STRGRP_NOT_FOUND, SYSERR_SSOPOLICY_NULL, SYSERR_SSOPOLICY_NO_AUTHN_POLICY, SYSERR_SSOPOLICY_NO_AUTH_PROFILE,
        /// SYSERR_AUTHPROFILE_NULL, SYSERR_SSOPOLICY_INVALID_AUTH_TYPE, SYSERR_SSOPOLICY_MISSING_SAML_IDP_SP_CONF,
        /// SYSERR_SAML_SP_CONFIG_NULL, SYSERR_SAML_SINGLE_SIGNON_URL_NULL, SYSERR_SAML_SP_METADATA_NULL,
        /// SYSERR_SAML_COOKIE_NAME_OR_KEY_NULL, SYSERR_LASSO_SERVER_CONFIG_FAILURE, SYSERR_SAML_ENTITY_ID_NULL,
        /// SYSERR_BASIC_AUTH_CONF_NULL, SYSERR_LDAP_REQUIRE_FIELD_EMPTY, SYSERR_LDAP_URL_INVALID_PARAMETER, SYSERR_LDAP_BAD_SCHEME,
        /// SYSERR_LDAP_BAD_ENCLOSURE, SYSERR_LDAP_BAD_EXTNS, SYSERR_LDAP_BAD_FILTER, SYSERR_LDAP_BAD_SCOPE, SYSERR_LDAP_BAD_ATTRS,
        /// SYSERR_LDAP_BAD_HOST, SYSERR_LDAP_USER_ATTRIBUTE_NULL, SYSERR_LDAP_URL_PARSE_FAIL, SYSERR_LDAP_INVALID_URL,
        /// SYSERR_AUTH_PROFILE_NOT_FOUND, SYSERR_SSO_TYPE_MISMATCH, SYSERR_NULL_CACHE_CONFIG, SYSERR_SSOPOLICY_NOT_FOUND,
        /// SYSERR_CLIENT_AUTH_PROFILE_NOT_FOUND, SYSERR_CLIENT_AUTH_PROFILE_NULL, SYSERR_SAML_IDP_METADATA_NULL,
        /// SYSERR_LASSO_SERVER_ERROR_ADD_PROVIDER_FAILED, SYSERR_LASSO_SERVER_ERROR_ADD_PROVIDER_PROTOCOL_MISMATCH,
        /// SYSERR_LASSO_PARAMS_PROVIDERS_UNAVAILABLE, SYSERR_JWTPROFILE_NULL, SYSERR_JWTSERVER_PROFILE_NOT_FOUND,
        /// SYSERR_AUTH_PROFILE_JWTSERVER_PROFILE_OBJECT_NULL, SYSERR_JWT_NAME_NULL, SYSERR_JWT_LOCATION_NULL,
        /// SYSERR_JWT_VS_AUDIENCE_NULL, SYSERR_SSO_JWT_VS_INFO_NULL, SYSERR_SUB_CONFIG_FAILURE, SYSERR_BIND_WAF_FAILURE,
        /// SYSERR_PROXY_INIT_FAILURE, SYSERR_GRPC_CONFIG_FAILURE, SYSERR_BIND_POLICY_FAILURE, SYSERR_BIND_PROFILE_FAILURE,
        /// SYSERR_BIND_LUA_SCRIPT_FAILURE, SYSERR_LUA_SCRIPT_SYNTAX, SYSERR_MISSING_LDAP_VS_CONF,
        /// SYSERR_SECPOL_RATE_LIMITER_HTTP_LOC_ERR, SYSERR_COMPR_FLTR_UNKNOWN_LEVEL, SYSERR_COMPR_MIME_TYPE_NOT_INITED,
        /// SYSERR_IPADDRGRP_NOT_FOUND, SYSERR_DUPLICATE_UPSTREAM, SYSERR_UPSTREAM_COMPLEX_COMPILATION_FAILED,
        /// SYSERR_UPSTREAM_INIT_NO_SERVERS, SYSERR_UPSTREAM_INVALID_ADDRESS, SYSERR_UPSTREAM_INVALID_HOST,
        /// SYSERR_UPSTREAM_WITHOUT_PORT, SYSERR_UPSTREAM_INVALID_PARAMETER, SYSERR_UPSTREAM_INVALID_VALUE,
        /// SYSERR_UPSTREAM_LB_NO_PEERS, SYSERR_UPSTREAM_LB_NULL_CONF, SYSERR_UPSTREAM_PARSE_URL_FAILED,
        /// SYSERR_UPSTREAM_UNSUPPORTED_PARAMETER, SYSERR_PAA_NO_OBJECT, SYSERR_PAA_FILESYSTEM_CREATE_FAIL,
        /// SYSERR_PAA_CACHE_CREATE_FAIL, SYSERR_WAF_INIT_FAIL, SYSERR_WAF_INIT_SIGNATURES_FAIL, SYSERR_WAF_WHITELIST_INIT_FAIL,
        /// SYSERR_WAF_PSM_INIT_FAIL, SYSERR_WAF_INIT_APP_SIGNATURES_FAIL, SYSERR_WAF_POSTPROCESS_SIGNATURES_FAIL,
        /// SYSERR_WAF_ALLOWLIST_INIT_FAIL, SYSERR_WAF_POLICY_INIT_FAIL, SYSERR_WAF_INIT_CRS_OVERRIDE_FAIL, SYSERR_BOT_INIT_FAIL,
        /// SYSERR_BOT_ALLOWLIST_INIT_FAIL, SYSERR_BOT_POLICY_NOT_FOUND, SYSERR_BIND_BOT_FAILURE, SYSERR_BOT_MAPPING_NOT_FOUND,
        /// SYSERR_BOT_CONSOLIDATOR_NOT_FOUND, SYSERR_POLICY_HASH_REMOVE, SYSERR_POLICY_V4_TREE_CREATION,
        /// SYSERR_POLICY_V6_TREE_CREATION, SYSERR_POLICY_APPLOG_PROV, SYSERR_POLICY_CLIENT_IP_GROUP_UUID,
        /// SYSERR_POLICY_PATH_MATCH_GROUP_UUID, SYSERR_POLICY_QUERY_MATCH_GROUP_UUID, SYSERR_POLICY_UNKOWN_MATCH_ACTION,
        /// SYSERR_POLICY_INVALID_HDR_ACTIONS, SYSERR_POLICY_RWH_COOKIE_OPER, SYSERR_POLICY_HASH_INSERT,
        /// SYSERR_SSL_CERT_NOT_PRESENT, SYSERR_SSL_CERT_KEY_NOT_PRESENT, SYSERR_SSL_CTX_CREATION_ERR, SYSERR_SSL_CERT_READ_FAILURE,
        /// SYSERR_SSL_CERT_LOAD_TO_CTX, SYSERR_SSL_CERT_IDX_TO_CTX, SYSERR_SSL_KEY_LOAD_TO_CTX, SYSERR_SSL_CERT_CHAIN_READ_FAILURE,
        /// SYSERR_SSL_CERT_CHAIN_ADD_FAILURE, SYSERR_SSL_KEY_READ_FAILURE, SYSERR_SSL_CERTIFICATE_AND_KEY_MISMATCH,
        /// SYSERR_SSL_CIPHER_LIST_NOT_SET, SYSERR_SSL_CIPHER_SUITES_NOT_SET, SYSERR_SSL_PKI_CLIENT_CA, SYSERR_SSL_DHPARAM_FAILURE,
        /// SYSERR_SSL_ECDH_FAILURE, SYSERR_SSL_HOSTMAP_FAILURE, SYSERR_SSL_SESSION_CACHE_INIT, SYSERR_SSL_SESSION_TIX_KEYS_INIT,
        /// SYSERR_SSL_PKI_CRL, SYSERR_PKI_PROFILE_CONFIG_NO_CA_CERT, SYSERR_DUPLICATE_PKI_PROFILE, SYSERR_SET_SSL_STAPLE_FAILURE,
        /// SYSERR_ICAP_PROFILE_NOT_FOUND, SYSERR_SSL_EVH_PARENT_NOT_FOUND, SYSERR_SSL_MEMPOOL_NAME_LEN_EXCEEDED,
        /// SYSERR_SSL_MEMPOOL_UUID_LEN_EXCEEDED, SYSERR_CONFIG_OBJ_NAME_LEN_EXCEEDED, SYSERR_AUTH_MISSING_OAUTH_PROFILE,
        /// SYSERR_OAUTH_MISSING_AUTHZ_EP, SYSERR_OAUTH_MISSING_TOKEN_EP, SYSERR_OAUTH_MISSING_INTROSPECTION_EP,
        /// SYSERR_INVALID_JWT_PROFILE_OBJECT, SYSERR_OAUTH_MISSING_POOL_OBJECT, SYSERR_MISSING_OAUTH_VS_CONF,
        /// SYSERR_OAUTH_MISSING_REDIRECT_URI, SYSERR_OAUTH_MISSING_CLIENT_CREDENTIALS, SYSERR_OAUTH_MISSING_RS_CREDENTIALS,
        /// SYSERR_OAUTH_MISSING_ISSUER, SYSERR_OAUTH_MISSING_USERINFO_EP, SYSERR_LIC_CONVERT_METERED_BANDWIDTH_NON_AZURE_FAILED,
        /// SYSERR_LIC_RESERVE_LEDGER_METADATA_REQ_UNIDENTIFIED, SYSERR_LIC_CONVERT_FORMULA_NOT_DEFINED,
        /// SYSERR_LIC_CONVERT_MALFORMED_PAYLOAD, SYSERR_FILE_CONTENT_DECODE_FAILED, SYSERR_SVC_FAILURE, SYSERR_SVC_SUCCESS.
        /// </summary>
        [JsonProperty(PropertyName = "reason_code")]
        public string? ReasonCode { get; set; }
        /// <summary>
        /// Desired number of servers for scheduled autoscale. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "scheduled_desired_capacity")]
        public int? ScheduledDesiredCapacity { get; set; }
    }
}
