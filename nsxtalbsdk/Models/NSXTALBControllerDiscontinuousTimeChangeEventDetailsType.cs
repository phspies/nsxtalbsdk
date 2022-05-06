using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBControllerDiscontinuousTimeChangeEventDetailsType
    {
        /// <summary>
        /// Time stamp before the discontinuous jump in time.
        /// </summary>
        [JsonProperty(PropertyName = "from_time")]
        public string? FromTime { get; set; }
        /// <summary>
        /// Name of the Controller responsible for this event.
        /// </summary>
        [JsonProperty(PropertyName = "node_name")]
        public string? NodeName { get; set; }
        /// <summary>
        /// System Peer and Candidate NTP Servers active at the point of time jump.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_servers")]
        public string? NtpServers { get; set; }
        /// <summary>
        /// Time stamp to which the time has discontinuously jumped.
        /// </summary>
        [JsonProperty(PropertyName = "to_time")]
        public string? ToTime { get; set; }
    }
}
