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
    public class NSXTALBSeRuntimeCompressionPropertiesType 
    {
        /// <summary>
        /// If client RTT is higher than this threshold, enable normal compression on the response. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "max_low_rtt")]
        public int? MaxLowRtt { get; set; }
        /// <summary>
        /// If client RTT is higher than this threshold, enable aggressive compression on the response. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "min_high_rtt")]
        public int? MinHighRtt { get; set; }
        /// <summary>
        /// Minimum response content length to enable compression.
        /// </summary>
        [JsonProperty(PropertyName = "min_length")]
        public int? MinLength { get; set; }
        /// <summary>
        /// Values that identify mobile browsers in order to enable aggressive compression.
        /// </summary>
        [JsonProperty(PropertyName = "mobile_str")]
        public IList<string> MobileStr { get; set; }
    }
}
