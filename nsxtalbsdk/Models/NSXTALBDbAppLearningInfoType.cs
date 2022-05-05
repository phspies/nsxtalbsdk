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
    public class NSXTALBDbAppLearningInfoType 
    {
        /// <summary>
        /// Application UUID. Combination of Virtualservice UUID and WAF Policy UUID. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string? AppId { get; set; }
        /// <summary>
        /// Information about various URIs under a application. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uri_info")]
        public IList<NSXTALBURIInfoType> UriInfo { get; set; }
        /// <summary>
        /// Virtualserivce UUID. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
