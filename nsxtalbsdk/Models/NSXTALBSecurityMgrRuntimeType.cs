using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSecurityMgrRuntimeType
    {
        /// <summary>
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "thresholds")]
        public IList<NSXTALBSecMgrThresholdType> Thresholds { get; set; }
    }
}
