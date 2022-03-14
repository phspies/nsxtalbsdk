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
    public class NSXTALBAnomalyContextType 
    {
        public NSXTALBAnomalyContextType()
        {
        }
        /// <summary>
        /// Placeholder for description of property ema_context of obj type AnomalyContext field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ema_context")]
        public NSXTALBExponentialMovingAverageCtxType EmaContext { get; set; }
        /// <summary>
        /// Placeholder for description of property ewma_context of obj type AnomalyContext field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ewma_context")]
        public NSXTALBExponentialMovingAverageCtxType EwmaContext { get; set; }
        /// <summary>
        /// Placeholder for description of property hw_at_as_context of obj type AnomalyContext field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hw_at_as_context")]
        public NSXTALBHoltWintersCtxType HwAtAsContext { get; set; }
        /// <summary>
        /// Placeholder for description of property hw_at_ms_context of obj type AnomalyContext field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hw_at_ms_context")]
        public NSXTALBHoltWintersCtxType HwAtMsContext { get; set; }
        /// <summary>
        /// Placeholder for description of property prediction_interval_high of obj type AnomalyContext field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_high")]
        public double? PredictionIntervalHigh { get; set; }
        /// <summary>
        /// Placeholder for description of property prediction_interval_low of obj type AnomalyContext field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_low")]
        public double? PredictionIntervalLow { get; set; }
    }
}
