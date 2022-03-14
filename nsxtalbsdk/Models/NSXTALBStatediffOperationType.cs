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
    public class NSXTALBStatediffOperationType 
    {
        public NSXTALBStatediffOperationType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Info for each Statediff event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<NSXTALBStatediffEventType> Events { get; set; }
        /// <summary>
        /// Name of Statediff operation. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Uuid of node for Statediff operation entry. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// Type of Statediff operation. Enum options - FB_UPGRADE, FB_ROLLBACK, FB_PATCH, FB_ROLLBACK_PATCH. Field introduced in
        /// 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string? Operation { get; set; }
        /// <summary>
        /// Phase of Statediff operation. Enum options - FB_PRE_SNAPSHOT, FB_POST_SNAPSHOT. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        public string? Phase { get; set; }
        /// <summary>
        /// Status of Statediff operation. Enum options - FB_INIT, FB_IN_PROGRESS, FB_COMPLETED, FB_FAILED,
        /// FB_COMPLETED_WITH_ERRORS. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
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
    }
}
