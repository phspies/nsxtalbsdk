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
    public class NSXTALBHoltWintersCtxType 
    {
        /// <summary>
        /// Placeholder for description of property deviation of obj type HoltWintersCtx field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "deviation")]
        public double? Deviation { get; set; }
        /// <summary>
        /// Placeholder for description of property level of obj type HoltWintersCtx field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public double? Level { get; set; }
        /// <summary>
        /// Placeholder for description of property prediction of obj type HoltWintersCtx field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "prediction")]
        public double? Prediction { get; set; }
        /// <summary>
        /// Placeholder for description of property prediction_interval_high of obj type HoltWintersCtx field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_high")]
        public double? PredictionIntervalHigh { get; set; }
        /// <summary>
        /// Placeholder for description of property prediction_interval_low of obj type HoltWintersCtx field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_low")]
        public double? PredictionIntervalLow { get; set; }
        /// <summary>
        /// Placeholder for description of property trend of obj type HoltWintersCtx field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "trend")]
        public double? Trend { get; set; }
    }
}
