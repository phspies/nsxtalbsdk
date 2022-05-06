using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVipPlacementResolutionInfoType
    {
        /// <summary>
        /// Placeholder for description of property ip of obj type VipPlacementResolutionInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Placeholder for description of property networks of obj type VipPlacementResolutionInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<NSXTALBDiscoveredNetworkType> Networks { get; set; }
        /// <summary>
        /// Unique object identifier of pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
    }
}
