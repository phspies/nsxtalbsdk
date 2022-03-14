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
    public class NSXTALBCustomIpamDnsProfileType 
    {
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
        /// Name of the Custom IPAM DNS Profile. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Parameters that are always passed to the IPAM/DNS script. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "script_params")]
        public IList<NSXTALBCustomParamsType> ScriptParams { get; set; }
        /// <summary>
        /// Script URI of form controller //ipamdnsscripts/<file-name>, file-name must have a .py extension and conform to PEP8
        /// naming convention. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "script_uri", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ScriptUri { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
