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
    public class NSXTALBGeoDBType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Description. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Geo Database files. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<NSXTALBGeoDBFileType> Files { get; set; }
        /// <summary>
        /// This field indicates that this object is replicated across GSLB federation. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Custom mappings of geo values. All mappings which start with the prefix 'System-' (any case) are reserved for system
        /// default objects and may be overwritten. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mappings")]
        public IList<NSXTALBGeoDBMappingType> Mappings { get; set; }
        /// <summary>
        /// Geo Database name. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of this object. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
