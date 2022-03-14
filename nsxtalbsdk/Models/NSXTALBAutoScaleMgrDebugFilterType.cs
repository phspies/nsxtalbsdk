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
    public class NSXTALBAutoScaleMgrDebugFilterType 
    {
        /// <summary>
        /// Enable aws autoscale integration. This is an alpha feature. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_aws_autoscale_integration")]
        public bool? EnableAwsAutoscaleIntegration { get; set; }
        /// <summary>
        /// period of running intelligent autoscale check.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_autoscale_period")]
        public int? IntelligentAutoscalePeriod { get; set; }
        /// <summary>
        /// uuid of the Pool. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
    }
}
