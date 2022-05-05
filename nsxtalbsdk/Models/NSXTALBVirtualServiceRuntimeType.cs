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
    public class NSXTALBVirtualServiceRuntimeType 
    {
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_extension")]
        public NSXTALBVsApicExtensionType ApicExtension { get; set; }
        /// <summary>
        /// controller_ip of VirtualServiceRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "controller_ip")]
        public string? ControllerIp { get; set; }
        /// <summary>
        /// Placeholder for description of property datapath_debug of obj type VirtualServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "datapath_debug")]
        public NSXTALBDebugVirtualServiceType DatapathDebug { get; set; }
        /// <summary>
        /// Placeholder for description of property east_west of obj type VirtualServiceRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "east_west")]
        public bool? EastWest { get; set; }
        /// <summary>
        /// Deprecated, handled by SE Datastore. Field deprecated in 18.1.5, 18.2.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_dns_geo_update")]
        public NSXTALBGslbDnsGeoUpdateType GslbDnsGeoUpdate { get; set; }
        /// <summary>
        /// Placeholder for description of property gslb_dns_update of obj type VirtualServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "gslb_dns_update")]
        public NSXTALBGslbDnsUpdateType GslbDnsUpdate { get; set; }
        /// <summary>
        /// Placeholder for description of property ipam_dns_records of obj type VirtualServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ipam_dns_records")]
        public IList<NSXTALBDnsRecordType> IpamDnsRecords { get; set; }
        /// <summary>
        /// Placeholder for description of property is_dns_vs of obj type VirtualServiceRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_dns_vs")]
        public bool? IsDnsVs { get; set; }
        /// <summary>
        /// Number of times keys have been rotated. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "key_rotation_count")]
        public long? KeyRotationCount { get; set; }
        /// <summary>
        /// Placeholder for description of property last_changed_time of obj type VirtualServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// Timestamp of the last key rotation. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "last_key_rotation_time")]
        public NSXTALBTimeStampType LastKeyRotationTime { get; set; }
        /// <summary>
        /// lif of VirtualServiceRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "lif")]
        public IList<string> Lif { get; set; }
        /// <summary>
        /// Placeholder for description of property manual_placement of obj type VirtualServiceRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "manual_placement")]
        public bool? ManualPlacement { get; set; }
        /// <summary>
        /// Placeholder for description of property marked_for_delete of obj type VirtualServiceRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "marked_for_delete")]
        public bool? MarkedForDelete { get; set; }
        /// <summary>
        /// Enum options - METRICS_MGR_PORT_0, METRICS_MGR_PORT_1, METRICS_MGR_PORT_2, METRICS_MGR_PORT_3.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_mgr_port")]
        public string? MetricsMgrPort { get; set; }
        /// <summary>
        /// Number of num_additional_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_additional_se")]
        public int? NumAdditionalSe { get; set; }
        /// <summary>
        /// Placeholder for description of property one_plus_one_ha of obj type VirtualServiceRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "one_plus_one_ha")]
        public bool? OnePlusOneHa { get; set; }
        /// <summary>
        /// prev_controller_ip of VirtualServiceRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "prev_controller_ip")]
        public string? PrevControllerIp { get; set; }
        /// <summary>
        /// Enum options - METRICS_MGR_PORT_0, METRICS_MGR_PORT_1, METRICS_MGR_PORT_2, METRICS_MGR_PORT_3.
        /// </summary>
        [JsonProperty(PropertyName = "prev_metrics_mgr_port")]
        public string? PrevMetricsMgrPort { get; set; }
        /// <summary>
        /// Number of redis_db.
        /// </summary>
        [JsonProperty(PropertyName = "redis_db")]
        public int? RedisDb { get; set; }
        /// <summary>
        /// Field deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "redis_ip")]
        public string? RedisIp { get; set; }
        /// <summary>
        /// Number of redis_port.
        /// </summary>
        [JsonProperty(PropertyName = "redis_port")]
        public int? RedisPort { get; set; }
        /// <summary>
        /// Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "rules_configured")]
        public bool? RulesConfigured { get; set; }
        /// <summary>
        /// Runtime info from security_manager. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sec_mgr_info")]
        public NSXTALBSecurityMgrRuntimeType SecMgrInfo { get; set; }
        /// <summary>
        /// Enable Service Engines to elect a primary amongst themselves in the absence of connectivity to controller. Field
        /// introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "self_se_election")]
        public bool? SelfSeElection { get; set; }
        /// <summary>
        /// Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "servers_configured")]
        public bool? ServersConfigured { get; set; }
        /// <summary>
        /// Placeholder for description of property tls_ticket_key of obj type VirtualServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "tls_ticket_key")]
        public IList<NSXTALBTLSTicketType> TlsTicketKey { get; set; }
        /// <summary>
        /// Enum options - VS_TYPE_NORMAL, VS_TYPE_VH_PARENT, VS_TYPE_VH_CHILD.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Version number of the SE List update.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public long? Version { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vh_child_vs_ref")]
        public IList<string> VhChildVsRef { get; set; }
        /// <summary>
        /// Placeholder for description of property vip_runtime of obj type VirtualServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip_runtime")]
        public IList<NSXTALBVipRuntimeType> VipRuntime { get; set; }
        /// <summary>
        /// VS update request received before warmstart finished. Field introduced in 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_update_pending")]
        public NSXTALBVirtualServiceType VsUpdatePending { get; set; }
    }
}
