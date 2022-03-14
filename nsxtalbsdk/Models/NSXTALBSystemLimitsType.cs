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
    public class NSXTALBSystemLimitsType 
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
        /// System limits for the entire controller cluster. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_limits")]
        public NSXTALBControllerLimitsType ControllerLimits { get; set; }
        /// <summary>
        /// Possible controller sizes. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_sizes")]
        public IList<NSXTALBControllerSizeType> ControllerSizes { get; set; }
        /// <summary>
        /// System limits that apply to a serviceengine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_limits")]
        public NSXTALBServiceEngineLimitsType ServiceengineLimits { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID for the system limits object. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
