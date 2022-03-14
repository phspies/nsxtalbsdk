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
    public class NSXTALBVsGsType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Gslb GeoDB being associated using this object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "geodb_uuid")]
        public string? GeodbUuid { get; set; }
        /// <summary>
        /// Gslb Service being associated using this object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gs_uuid")]
        public string? GsUuid { get; set; }
        /// <summary>
        /// Gslb being associated using this object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_uuid")]
        public string? GslbUuid { get; set; }
        /// <summary>
        /// Name of the VS-GS association object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Tenant. It is a reference to an object of type Tenant. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Type of the VS-GS association object. Enum options - VSGS_TYPE_GSLB, VSGS_TYPE_GS, VSGS_TYPE_GEO_DB. Field introduced in
        /// 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the VS-GS association object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Virtual Service being associated using this object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
