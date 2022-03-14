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
    public class NSXTALBSnmpV3ConfigurationType 
    {
        /// <summary>
        /// Engine Id of the Avi Controller SNMP. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "engine_id")]
        public string? EngineId { get; set; }
        /// <summary>
        /// SNMP ver 3 user definition. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public NSXTALBSnmpV3UserParamsType User { get; set; }
    }
}
