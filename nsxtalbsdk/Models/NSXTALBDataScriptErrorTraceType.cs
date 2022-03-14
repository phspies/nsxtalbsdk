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
    public class NSXTALBDataScriptErrorTraceType 
    {
        /// <summary>
        /// error of DataScriptErrorTrace.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// event of DataScriptErrorTrace.
        /// </summary>
        [JsonProperty(PropertyName = "event")]
        public string? Event { get; set; }
        /// <summary>
        /// stack_trace of DataScriptErrorTrace.
        /// </summary>
        [JsonProperty(PropertyName = "stack_trace")]
        public string? StackTrace { get; set; }
    }
}
