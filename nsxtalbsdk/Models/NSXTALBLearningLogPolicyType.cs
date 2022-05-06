using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBLearningLogPolicyType
    {
        /// <summary>
        /// Determine whether app learning logging is enabled. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Host name where learning logs will be sent to. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Port number for the service listening for learning logs. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }
}
