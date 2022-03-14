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
    public class NSXTALBHttpCacheObjFilterType 
    {
        /// <summary>
        /// HTTP cache object's exact key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// HTTP cache object's exact raw key.
        /// </summary>
        [JsonProperty(PropertyName = "raw_key")]
        public string? RawKey { get; set; }
        /// <summary>
        /// HTTP cache object's resource name.
        /// </summary>
        [JsonProperty(PropertyName = "resource_name")]
        public string? ResourceName { get; set; }
        /// <summary>
        /// objects with resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
        /// <summary>
        /// HTTP cache object type. Enum options - CO_ALL, CO_IN, CO_OUT.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
