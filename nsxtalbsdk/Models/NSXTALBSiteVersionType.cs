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
    public class NSXTALBSiteVersionType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// This field represents the creation time of the federateddiff. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "datetime")]
        public string? Datetime { get; set; }
        /// <summary>
        /// Name of the Site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Previous targer version for a site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "prev_target_version")]
        public long? PrevTargetVersion { get; set; }
        /// <summary>
        /// Replication state for a site. Enum options - REPLICATION_STATE_FASTFORWARD, REPLICATION_STATE_FORCESYNC,
        /// REPLICATION_STATE_STREAMING, REPLICATION_STATE_SUSPENDED, REPLICATION_STATE_INIT, REPLICATION_STATE_WAIT,
        /// REPLICATION_STATE_NOT_APPLICABLE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "replication_state")]
        public string? ReplicationState { get; set; }
        /// <summary>
        /// Cluster UUID of the site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
        /// <summary>
        /// Target timeline of the site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "target_timeline")]
        public string? TargetTimeline { get; set; }
        /// <summary>
        /// Target version of the site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        public long? TargetVersion { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Timeline of the site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "timeline")]
        public string? Timeline { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the SiteVersion object. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Version of the site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public long? Version { get; set; }
        /// <summary>
        /// Type of message for which version is maintained. Enum options - CONFIG_VERSION, HEALTH_STATUS_VERSION. Field introduced
        /// in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "version_type")]
        public string? VersionType { get; set; }
    }
}
