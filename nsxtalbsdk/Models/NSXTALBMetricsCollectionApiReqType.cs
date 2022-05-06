using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMetricsCollectionApiReqType
    {
        /// <summary>
        /// list of metrics queries
        /// </summary>
        [JsonProperty(PropertyName = "metric_requests")]
        public IList<NSXTALBMetricsQueryType> MetricRequests { get; set; }
    }
}
