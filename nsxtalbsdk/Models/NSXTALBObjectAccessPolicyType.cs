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
    public class NSXTALBObjectAccessPolicyType 
    {
        public NSXTALBObjectAccessPolicyType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Name of the Object Access Policy. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Rules which grant access to specific objects. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rules", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTALBObjectAccessPolicyRuleType> Rules { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Uuid of the Object Access Policy. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
