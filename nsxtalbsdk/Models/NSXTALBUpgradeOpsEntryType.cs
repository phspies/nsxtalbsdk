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
    public class NSXTALBUpgradeOpsEntryType 
    {
        /// <summary>
        /// Name of the system such as cluster name, se group name and se name. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Describes the system  controller or se-group or se. Enum options - NODE_CONTROLLER_CLUSTER, NODE_SE_GROUP, NODE_SE_TYPE.
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "node_type")]
        public string? NodeType { get; set; }
        /// <summary>
        /// Cloud that this object belongs to. It is a reference to an object of type Cloud. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "obj_cloud_ref")]
        public string? ObjCloudRef { get; set; }
        /// <summary>
        /// Parameters associated with the upgrade ops request. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public NSXTALBUpgradeOpsParamType Params { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Current Upgrade Status info for this node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_info")]
        public NSXTALBUpgradeStatusInfoType UpgradeInfo { get; set; }
        /// <summary>
        /// Identifies the upgrade operations. Enum options - UPGRADE, PATCH, ROLLBACK, ROLLBACKPATCH, SEGROUP_RESUME. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_ops")]
        public string? UpgradeOps { get; set; }
        /// <summary>
        /// Uuid identifier for the system such as cluster, se group and se. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
