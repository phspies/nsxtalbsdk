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
    public class NSXTALBIcapViolationType 
    {
        /// <summary>
        /// The file that ICAP server has identified as containing a violation. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "file_name")]
        public string? FileName { get; set; }
        /// <summary>
        /// Action taken by ICAP server in response to this threat. Enum options - ICAP_FILE_NOT_REPAIRED, ICAP_FILE_REPAIRED,
        /// ICAP_VIOLATING_SECTION_REMOVED. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public string? Resolution { get; set; }
        /// <summary>
        /// The name of the threat. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "threat_name")]
        public string? ThreatName { get; set; }
    }
}
