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
    public class NSXTALBIcapOPSWATLogType 
    {
        /// <summary>
        /// Blocking reason for the content. It is available only if content was scanned by ICAP server and some violations were
        /// found. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Short description of the threat found in the content. Available only if content was scanned by ICAP server and some
        /// violations were found. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "threat_id")]
        public string? ThreatId { get; set; }
        /// <summary>
        /// Threat found in the content. Available only if content was scanned by ICAP server and some violations were found. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "violations")]
        public IList<NSXTALBIcapViolationType> Violations { get; set; }
    }
}
