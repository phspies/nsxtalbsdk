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
    public class NSXTALBNetworkRuntimeType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Objects using static IPs in this network. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_uuids")]
        public IList<string> ObjUuids { get; set; }
        /// <summary>
        /// Use obj_uuids. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public IList<string> SeUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property subnet_runtime of obj type NetworkRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "subnet_runtime")]
        public IList<NSXTALBSubnetRuntimeType> SubnetRuntime { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
