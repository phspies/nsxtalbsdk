using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBExponentialMovingAverageCtxType
    {
        /// <summary>
        /// Average value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "average")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Average { get; set; }
        /// <summary>
        /// Deviation of last sample to the average.
        /// </summary>
        [JsonProperty(PropertyName = "deviation")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Deviation { get; set; }
        /// <summary>
        /// Maximum standard deviation recorded.
        /// </summary>
        [JsonProperty(PropertyName = "max_std_dev")]
        [System.ComponentModel.DataAnnotations.Required]
        public double MaxStdDev { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "normal_high")]
        public double? NormalHigh { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "normal_low")]
        public double? NormalLow { get; set; }
        /// <summary>
        /// Predicted value for the metric at the time instant.
        /// </summary>
        [JsonProperty(PropertyName = "prediction")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Prediction { get; set; }
        /// <summary>
        /// Lower boundary of the range of normal values for this metric.
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_high")]
        public double? PredictionIntervalHigh { get; set; }
        /// <summary>
        /// Lower boundary of the range of normal values for this metric.
        /// </summary>
        [JsonProperty(PropertyName = "prediction_interval_low")]
        public double? PredictionIntervalLow { get; set; }
        /// <summary>
        /// Standard deviation.
        /// </summary>
        [JsonProperty(PropertyName = "std_dev")]
        [System.ComponentModel.DataAnnotations.Required]
        public double StdDev { get; set; }
    }
}
