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
    public class NSXTALBFullClientLogsType 
    {
        /// <summary>
        /// [DEPRECATED] Log all headers. Please use the all_headers flag in AnalyticsPolicy. Field deprecated in 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// How long should the system capture all logs, measured in minutes. Set to 0 for infinite. Special values are 0 -
        /// infinite. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Capture all client logs including connections and requests.  When deactivated, only errors will be logged. Allowed in
        /// Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition. Special default for
        /// Basic edition is false, Essentials edition is false, Enterprise is False.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
        /// <summary>
        /// This setting limits the number of non-significant logs generated per second for this VS on each SE. Default is 10 logs
        /// per second. Set it to zero (0) to deactivate throttling. Field introduced in 17.1.3. Unit is PER_SECOND.
        /// </summary>
        [JsonProperty(PropertyName = "throttle")]
        public int? Throttle { get; set; }
    }
}
