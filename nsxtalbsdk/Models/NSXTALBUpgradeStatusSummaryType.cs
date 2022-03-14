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
    public class NSXTALBUpgradeStatusSummaryType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Check if the patch rollback is possible on this node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable_patch_rollback")]
        public bool? EnablePatchRollback { get; set; }
        /// <summary>
        /// Check if the rollback is possible on this node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rollback")]
        public bool? EnableRollback { get; set; }
        /// <summary>
        /// End time of upgrade operations. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string? EndTime { get; set; }
        /// <summary>
        /// Image uuid for identifying the current base image. It is a reference to an object of type Image. Field introduced in
        /// 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "image_ref")]
        public string? ImageRef { get; set; }
        /// <summary>
        /// Name of the system such as cluster name, se group name and se name. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Type of the system such as controller_cluster, se_group or se. Enum options - NODE_CONTROLLER_CLUSTER, NODE_SE_GROUP,
        /// NODE_SE_TYPE. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "node_type")]
        public string? NodeType { get; set; }
        /// <summary>
        /// Cloud that this object belongs to. It is a reference to an object of type Cloud. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "obj_cloud_ref")]
        public string? ObjCloudRef { get; set; }
        /// <summary>
        /// Image uuid for identifying the current patch. It is a reference to an object of type Image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_image_ref")]
        public string? PatchImageRef { get; set; }
        /// <summary>
        /// Start time of upgrade operations. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
        /// <summary>
        /// Current status of the upgrade operations. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public NSXTALBUpgradeOpsStateType State { get; set; }
        /// <summary>
        /// Upgrade tasks completed. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "tasks_completed")]
        public int? TasksCompleted { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Total upgrade tasks. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "total_tasks")]
        public int? TotalTasks { get; set; }
        /// <summary>
        /// Upgrade operations requested. Enum options - UPGRADE, PATCH, ROLLBACK, ROLLBACKPATCH, SEGROUP_RESUME. Field introduced
        /// in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_ops")]
        public string? UpgradeOps { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID Identifier for the system such as cluster, se group and se. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Current base image applied to this node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
