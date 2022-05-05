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
    public class NSXTALBMetricsCollectionApiReqType 
    {
        /// <summary>
        /// list of metrics queries
        /// </summary>
        [JsonProperty(PropertyName = "metric_requests")]
        public IList<NSXTALBMetricsQueryType> MetricRequests { get; set; }
    }
}
