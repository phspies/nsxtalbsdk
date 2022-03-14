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
    public class NSXTALBEventDetailsFilterType 
    {
        /// <summary>
        /// Enum options - ALERT_OP_LT, ALERT_OP_LE, ALERT_OP_EQ, ALERT_OP_NE, ALERT_OP_GE, ALERT_OP_GT.
        /// </summary>
        [JsonProperty(PropertyName = "comparator", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Comparator { get; set; }
        /// <summary>
        /// event_details_key of EventDetailsFilter.
        /// </summary>
        [JsonProperty(PropertyName = "event_details_key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string EventDetailsKey { get; set; }
        /// <summary>
        /// event_details_value of EventDetailsFilter.
        /// </summary>
        [JsonProperty(PropertyName = "event_details_value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string EventDetailsValue { get; set; }
    }
}
