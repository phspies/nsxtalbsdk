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
    public class NSXTALBCloudASGNotifDetailsType 
    {
        /// <summary>
        /// Autoscale Group name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "asg_name")]
        public string? AsgName { get; set; }
        /// <summary>
        /// Cloud UUID. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Failure reason if Autoscale Group creation or deletion fails. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Pool UUID. It is a reference to an object of type Pool. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
    }
}
