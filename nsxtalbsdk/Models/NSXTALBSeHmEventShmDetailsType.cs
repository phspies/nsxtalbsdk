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
    public class NSXTALBSeHmEventShmDetailsType 
    {
        /// <summary>
        /// Average health monitor response time from server in milli-seconds.
        /// </summary>
        [JsonProperty(PropertyName = "average_response_time")]
        public long? AverageResponseTime { get; set; }
        /// <summary>
        /// Health Monitor name. It is a reference to an object of type HealthMonitor.
        /// </summary>
        [JsonProperty(PropertyName = "health_monitor")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HealthMonitor { get; set; }
        /// <summary>
        /// resp_string of SeHmEventShmDetails.
        /// </summary>
        [JsonProperty(PropertyName = "resp_string")]
        public string? RespString { get; set; }
        /// <summary>
        /// Response code from server. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "response_code")]
        public int? ResponseCode { get; set; }
    }
}
