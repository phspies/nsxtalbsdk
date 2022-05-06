using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Frequency with which messages are propagated to Vs Mgr. Value of 0 disables async behavior and RPC are sent inline.
        /// Allowed values are 0-5. Field introduced in 18.2.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "async_interval")]
        public int? AsyncInterval { get; set; }
        /// <summary>
        /// Max retries after which the remote site is treated as a fresh start. In fresh start all the configs are downloaded.
        /// Allowed values are 1-1024.
        /// </summary>
        [JsonProperty(PropertyName = "clear_on_max_retries")]
        public int? ClearOnMaxRetries { get; set; }
        /// <summary>
        /// Group to specify if the client ip addresses are public or private. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_addr_group")]
        public NSXTALBGslbClientIpAddrGroupType ClientIpAddrGroup { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Sub domain configuration for the GSLB.  GSLB service's FQDN must be a match one of these subdomains. .
        /// </summary>
        [JsonProperty(PropertyName = "dns_configs")]
        public IList<NSXTALBDNSConfigType> DnsConfigs { get; set; }
        /// <summary>
        /// Allows enable/disable of GslbService pool groups and pool members from the gslb follower members. Field introduced in
        /// 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable_config_by_members")]
        public bool? EnableConfigByMembers { get; set; }
        /// <summary>
        /// Frequency with which errored messages are resynced to follower sites. Value of 0 disables resync behavior. Allowed
        /// values are 60-3600. Special values are 0 - Disable. Field introduced in 18.2.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "error_resync_interval")]
        public int? ErrorResyncInterval { get; set; }
        /// <summary>
        /// This field indicates that this object is replicated across GSLB federation. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Mark this Site as leader of GSLB configuration. This site is the one among the Avi sites.
        /// </summary>
        [JsonProperty(PropertyName = "leader_cluster_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string LeaderClusterUuid { get; set; }
        /// <summary>
        /// This field disables the configuration operations on the leader for all federated objects.  CUD operations on Gslb,
        /// GslbService, GslbGeoDbProfile and other federated objects will be rejected. The rest-api disabling helps in upgrade
        /// scenarios where we don't want configuration sync operations to the Gslb member when the member is being upgraded.  This
        /// configuration programmatically blocks the leader from accepting new Gslb configuration when member sites are undergoing
        /// upgrade. . Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        public bool? MaintenanceMode { get; set; }
        /// <summary>
        /// Name for the GSLB object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Policy for replicating configuration to the active follower sites. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "replication_policy")]
        public NSXTALBReplicationPolicyType ReplicationPolicy { get; set; }
        /// <summary>
        /// Frequency with which group members communicate. Allowed values are 1-3600. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "send_interval")]
        public int? SendInterval { get; set; }
        /// <summary>
        /// The user can specify a send-interval while entering maintenance mode. The validity of this 'maintenance send-interval'
        /// is only during maintenance mode. When the user leaves maintenance mode, the original send-interval is reinstated. This
        /// internal variable is used to store the original send-interval. . Field introduced in 18.2.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "send_interval_prior_to_maintenance_mode")]
        public int? SendIntervalPriorToMaintenanceMode { get; set; }
        /// <summary>
        /// Select Avi site member belonging to this Gslb. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "sites")]
        public IList<NSXTALBGslbSiteType> Sites { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// This field indicates tenant visibility for GS pool member selection across the Gslb federated objects. Field introduced
        /// in 18.2.12,20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_scoped")]
        public bool? TenantScoped { get; set; }
        /// <summary>
        /// Third party site member belonging to this Gslb. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "third_party_sites")]
        public IList<NSXTALBGslbThirdPartySiteType> ThirdPartySites { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the GSLB object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// The view-id is used in change-leader mode to differentiate partitioned groups while they have the same GSLB namespace.
        /// Each partitioned group will be able to operate independently by using the view-id.
        /// </summary>
        [JsonProperty(PropertyName = "view_id")]
        public long? ViewId { get; set; }
    }
}
