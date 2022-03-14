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
    public class NSXTALBControllerSiteType 
    {
        public NSXTALBControllerSiteType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// IP Address or a DNS resolvable, fully qualified domain name of the Site Controller Cluster. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Address { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Name for the Site Controller Cluster. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// The Controller Site Cluster's REST API port number. Allowed values are 1-65535. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// Reference for the Tenant. It is a reference to an object of type Tenant. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Reference for the Site Controller Cluster. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
