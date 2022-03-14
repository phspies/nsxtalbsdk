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
    public class NSXTALBSePropertiesType 
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
        /// Placeholder for description of property se_agent_properties of obj type SeProperties field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_agent_properties")]
        public NSXTALBSeAgentPropertiesType SeAgentProperties { get; set; }
        /// <summary>
        /// Placeholder for description of property se_bootup_properties of obj type SeProperties field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_bootup_properties")]
        public NSXTALBSeBootupPropertiesType SeBootupProperties { get; set; }
        /// <summary>
        /// Placeholder for description of property se_runtime_properties of obj type SeProperties field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_runtime_properties")]
        public NSXTALBSeRuntimePropertiesType SeRuntimeProperties { get; set; }
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
