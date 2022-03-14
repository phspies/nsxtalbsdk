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
    public class NSXTALBWafLearningType 
    {
        public NSXTALBWafLearningType()
        {
        }
        /// <summary>
        /// Suffix Summarization threshold used to compress args. Allowed values are 3-255. Field deprecated in 18.2.3. Field
        /// introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "arg_summarization_threshold")]
        public int? ArgSummarizationThreshold { get; set; }
        /// <summary>
        /// Confidence level used to derive rules from the WAF learning. Allowed values are 60-100. Field deprecated in 18.2.3.
        /// Field introduced in 18.1.2. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public int? Confidence { get; set; }
        /// <summary>
        /// Enable Learning for WAF policy. Field deprecated in 18.2.3. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Suffix Summarization threshold used to compress paths. Allowed values are 3-255. Field deprecated in 18.2.3. Field
        /// introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "path_summarization_threshold")]
        public int? PathSummarizationThreshold { get; set; }
        /// <summary>
        /// Sampling percent of the requests subjected to WAF learning. Allowed values are 1-100. Field deprecated in 18.2.3. Field
        /// introduced in 18.1.2. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_percent")]
        public int? SamplingPercent { get; set; }
    }
}
