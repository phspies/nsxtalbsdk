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
    public class NSXTALBAppLearningConfidenceOverrideType 
    {
        public NSXTALBAppLearningConfidenceOverrideType()
        {
        }
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_HIGH. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "confid_high_value")]
        public int? ConfidHighValue { get; set; }
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_LOW. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "confid_low_value")]
        public int? ConfidLowValue { get; set; }
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_PROBABLE. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "confid_probable_value")]
        public int? ConfidProbableValue { get; set; }
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_VERY_HIGH. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "confid_very_high_value")]
        public int? ConfidVeryHighValue { get; set; }
    }
}
