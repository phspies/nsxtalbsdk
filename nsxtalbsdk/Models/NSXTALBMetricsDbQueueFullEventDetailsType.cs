using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMetricsDbQueueFullEventDetailsType
    {
        /// <summary>
        /// Number of high.
        /// </summary>
        [JsonProperty(PropertyName = "high")]
        public long? High { get; set; }
        /// <summary>
        /// Number of instanceport.
        /// </summary>
        [JsonProperty(PropertyName = "instanceport")]
        public long? Instanceport { get; set; }
        /// <summary>
        /// Number of low.
        /// </summary>
        [JsonProperty(PropertyName = "low")]
        public long? Low { get; set; }
        /// <summary>
        /// nodeid of MetricsDbQueueFullEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "nodeid")]
        public string? Nodeid { get; set; }
        /// <summary>
        /// period of MetricsDbQueueFullEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public string? Period { get; set; }
        /// <summary>
        /// Placeholder for description of property runtime of obj type MetricsDbQueueFullEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "runtime")]
        public NSXTALBMetricsDbRuntimeType Runtime { get; set; }
        /// <summary>
        /// Number of watermark.
        /// </summary>
        [JsonProperty(PropertyName = "watermark")]
        public long? Watermark { get; set; }
    }
}
