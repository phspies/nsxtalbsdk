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
    public class NSXTALBMetricsCollectionApiRspType 
    {
        /// <summary>
        /// list of metrics data series map
        /// </summary>
        [JsonProperty(PropertyName = "series")]
        public object Series { get; set; }
    }
}
