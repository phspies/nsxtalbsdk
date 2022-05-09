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
    public class NSXTALBStatediffSnapshotType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Name of GSLB object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_name")]
        public string? GslbName { get; set; }
        /// <summary>
        /// Reference to base gslb object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_uuid")]
        public string? GslbUuid { get; set; }
        /// <summary>
        /// Name of Statediff operation. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Name of POOL object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// Reference to base pool object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Post-Upgrade snapshot for VS. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "post_snapshot")]
        public NSXTALBpostsnapshotType PostSnapshot { get; set; }
        /// <summary>
        /// Pre-Upgrade snapshot for VS. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pre_snapshot")]
        public NSXTALBpresnapshotType PreSnapshot { get; set; }
        /// <summary>
        /// Name of SEG object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_name")]
        public string? SeGroupName { get; set; }
        /// <summary>
        /// Reference to base SEG object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_uuid")]
        public string? SeGroupUuid { get; set; }
        /// <summary>
        /// Name of SEG object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Reference to base SE object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// Type of snapshot eg. VS_SNAPSHOT, SE_SNAPSHOT etc. Enum options - FB_VS_SNAPSHOT, FB_SE_SNAPSHOT, FB_GSLB_SNAPSHOT,
        /// FB_POOL_SNAPSHOT. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "snapshot_type")]
        public string? SnapshotType { get; set; }
        /// <summary>
        /// Statediff Operation uuid for identifying the operation. It is a reference to an object of type StatediffOperation. Field
        /// introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "statediff_operation_ref")]
        public string? StatediffOperationRef { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// unique identifier for Statediff entry. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Name of VS object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// Reference to base VS object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
