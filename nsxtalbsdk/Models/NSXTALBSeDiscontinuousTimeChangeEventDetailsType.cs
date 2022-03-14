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
    public class NSXTALBSeDiscontinuousTimeChangeEventDetailsType 
    {
        public NSXTALBSeDiscontinuousTimeChangeEventDetailsType()
        {
        }
        /// <summary>
        /// Relative time drift between SE and controller in terms of microseconds.
        /// </summary>
        [JsonProperty(PropertyName = "drift_time")]
        public long? DriftTime { get; set; }
        /// <summary>
        /// Time stamp before the discontinuous jump in time.
        /// </summary>
        [JsonProperty(PropertyName = "from_time")]
        public string? FromTime { get; set; }
        /// <summary>
        /// System Peer and Candidate NTP Servers active at the point of time jump.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_servers")]
        public string? NtpServers { get; set; }
        /// <summary>
        /// Name of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
        /// <summary>
        /// Time stamp to which the time has discontinuously jumped.
        /// </summary>
        [JsonProperty(PropertyName = "to_time")]
        public string? ToTime { get; set; }
    }
}
