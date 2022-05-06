using Newtonsoft.Json;
using System.Linq;
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
