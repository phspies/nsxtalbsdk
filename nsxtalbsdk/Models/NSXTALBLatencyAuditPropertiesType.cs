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
    public class NSXTALBLatencyAuditPropertiesType 
    {
        /// <summary>
        /// Audit TCP connection establishment time. Enum options - LATENCY_AUDIT_OFF, LATENCY_AUDIT_ON, LATENCY_AUDIT_ON_WITH_SIG.
        /// Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "conn_est_audit_mode")]
        public string? ConnEstAuditMode { get; set; }
        /// <summary>
        /// Maximum threshold for connection establishment time. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "conn_est_threshold")]
        public int? ConnEstThreshold { get; set; }
        /// <summary>
        /// Audit dispatcher to proxy latency. Enum options - LATENCY_AUDIT_OFF, LATENCY_AUDIT_ON, LATENCY_AUDIT_ON_WITH_SIG. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "latency_audit_mode")]
        public string? LatencyAuditMode { get; set; }
        /// <summary>
        /// Maximum latency threshold between dispatcher and proxy. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "latency_threshold")]
        public int? LatencyThreshold { get; set; }
    }
}
