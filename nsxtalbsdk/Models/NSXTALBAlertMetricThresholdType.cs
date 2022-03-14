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
    public class NSXTALBAlertMetricThresholdType 
    {
        /// <summary>
        /// Enum options - ALERT_OP_LT, ALERT_OP_LE, ALERT_OP_EQ, ALERT_OP_NE, ALERT_OP_GE, ALERT_OP_GT.
        /// </summary>
        [JsonProperty(PropertyName = "comparator", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Comparator { get; set; }
        /// <summary>
        /// Metric threshold for comparison.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public int? Threshold { get; set; }
    }
}
