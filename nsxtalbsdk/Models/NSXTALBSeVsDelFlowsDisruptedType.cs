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
    public class NSXTALBSeVsDelFlowsDisruptedType 
    {
        /// <summary>
        /// Name of the VS which was deleted from the SE. It is a reference to an object of type VirtualService. Field introduced in
        /// 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "deleted_vs_name")]
        public string? DeletedVsName { get; set; }
        /// <summary>
        /// Number of VS flows disrupted when VS was deleted from the SE. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs_flows_disrupted")]
        public int? NumVsFlowsDisrupted { get; set; }
        /// <summary>
        /// Name of the SE reporting this event. It is a reference to an object of type ServiceEngine. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reporting_se_name")]
        public string? ReportingSeName { get; set; }
    }
}
