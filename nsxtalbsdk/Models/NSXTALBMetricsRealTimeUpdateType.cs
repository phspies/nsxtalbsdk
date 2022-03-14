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
    public class NSXTALBMetricsRealTimeUpdateType 
    {
        public NSXTALBMetricsRealTimeUpdateType()
        {
        }
        /// <summary>
        /// Real time metrics collection duration in minutes. 0 for infinite. Special values are 0 - infinite. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Enables real time metrics collection.  When deactivated, 6 hour view is the most granular the system will track.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
    }
}
