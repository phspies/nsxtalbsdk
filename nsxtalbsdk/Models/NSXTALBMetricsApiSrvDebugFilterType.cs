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
    public class NSXTALBMetricsApiSrvDebugFilterType 
    {
        /// <summary>
        /// uuid of the entity. It is a reference to an object of type Virtualservice. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "entity_ref")]
        public string? EntityRef { get; set; }
    }
}
