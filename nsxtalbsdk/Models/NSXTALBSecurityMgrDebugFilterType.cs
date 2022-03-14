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
    public class NSXTALBSecurityMgrDebugFilterType 
    {
        public NSXTALBSecurityMgrDebugFilterType()
        {
        }
        /// <summary>
        /// Dynamically adapt configuration parameters for Application Learning feature. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_adaptive_config")]
        public bool? EnableAdaptiveConfig { get; set; }
        /// <summary>
        /// uuid of the entity. It is a reference to an object of type Virtualservice. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "entity_ref")]
        public string? EntityRef { get; set; }
    }
}
