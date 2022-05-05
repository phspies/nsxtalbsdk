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
    public class NSXTALBStreamingSyslogConfigType 
    {
        /// <summary>
        /// Facility value, as defined in RFC5424, must be between 0 and 23 inclusive. Allowed values are 0-23. Field introduced in
        /// 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "facility")]
        public int? Facility { get; set; }
        /// <summary>
        /// Severity code, as defined in RFC5424, for filtered logs. This must be between 0 and 7 inclusive. Allowed values are 0-7.
        /// Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "filtered_log_severity")]
        public int? FilteredLogSeverity { get; set; }
        /// <summary>
        /// String to use as the hostname in the syslog messages. This string can contain only printable ASCII characters (hex 21 to
        /// hex 7E; no space allowed). Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// Severity code, as defined in RFC5424, for non-significant logs. This must be between 0 and 7 inclusive. Allowed values
        /// are 0-7. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "non_significant_log_severity")]
        public int? NonSignificantLogSeverity { get; set; }
        /// <summary>
        /// Severity code, as defined in RFC5424, for significant logs. This must be between 0 and 7 inclusive. Allowed values are
        /// 0-7. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "significant_log_severity")]
        public int? SignificantLogSeverity { get; set; }
    }
}
