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
    public class NSXTALBFederationCheckpointType 
    {
        public NSXTALBFederationCheckpointType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Date when the checkpoint was created. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public string? Date { get; set; }
        /// <summary>
        /// Description for this checkpoint. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// This field describes the object's replication scope. If the field is set to false, then the object is visible within the
        /// controller-cluster and its associated service-engines. If the field is set to true, then the object is replicated across
        /// the federation. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Name of the Checkpoint. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the Checkpoint. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
