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
    public class NSXTALBSeHmEventPoolDetailsType 
    {
        /// <summary>
        /// HA Compromised reason.
        /// </summary>
        [JsonProperty(PropertyName = "ha_reason")]
        public string? HaReason { get; set; }
        /// <summary>
        /// Percentage of servers up.
        /// </summary>
        [JsonProperty(PropertyName = "percent_servers_up")]
        public string? PercentServersUp { get; set; }
        /// <summary>
        /// Pool name. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public string? Pool { get; set; }
        /// <summary>
        /// Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Server details.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public NSXTALBSeHmEventServerDetailsType Server { get; set; }
        /// <summary>
        /// UUID of the event generator.
        /// </summary>
        [JsonProperty(PropertyName = "src_uuid")]
        public string? SrcUuid { get; set; }
        /// <summary>
        /// Virtual service name. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_service")]
        public string? VirtualService { get; set; }
    }
}
