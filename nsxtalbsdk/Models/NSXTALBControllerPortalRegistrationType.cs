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
    public class NSXTALBControllerPortalRegistrationType 
    {
        public NSXTALBControllerPortalRegistrationType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "asset")]
        public NSXTALBControllerPortalAssetType Asset { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "portal_auth")]
        public NSXTALBControllerPortalAuthType PortalAuth { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
