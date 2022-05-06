using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNsxtTier1SegmentManualModeType
    {
        /// <summary>
        /// Tier1 logical router placement information. Field introduced in 20.1.1. Minimum of 1 items required. Maximum of 128
        /// items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_lrs")]
        public IList<NSXTALBTier1LogicalRouterInfoType> Tier1Lrs { get; set; }
    }
}
