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
    public class NSXTALBMetricStatisticsType 
    {
        /// <summary>
        /// value of the last sample.
        /// </summary>
        [JsonProperty(PropertyName = "last_sample")]
        public double? LastSample { get; set; }
        /// <summary>
        /// maximum value in time series requested.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public double? Max { get; set; }
        /// <summary>
        /// timestamp of the minimum value.
        /// </summary>
        [JsonProperty(PropertyName = "max_ts")]
        public string? MaxTs { get; set; }
        /// <summary>
        /// arithmetic mean.
        /// </summary>
        [JsonProperty(PropertyName = "mean")]
        public double? Mean { get; set; }
        /// <summary>
        /// minimum value in time series requested.
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public double? Min { get; set; }
        /// <summary>
        /// timestamp of the minimum value.
        /// </summary>
        [JsonProperty(PropertyName = "min_ts")]
        public string? MinTs { get; set; }
        /// <summary>
        /// Number of actual data samples. It excludes fake data.
        /// </summary>
        [JsonProperty(PropertyName = "num_samples")]
        public int? NumSamples { get; set; }
        /// <summary>
        /// summation of all values.
        /// </summary>
        [JsonProperty(PropertyName = "sum")]
        public double? Sum { get; set; }
        /// <summary>
        /// slope of the data points across the time series requested. trend = (last_value - avg)/avg.
        /// </summary>
        [JsonProperty(PropertyName = "trend")]
        public double? Trend { get; set; }
    }
}
