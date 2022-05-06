using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGCPVIPRoutesType
    {
        /// <summary>
        /// Match SE group subnets for VIP placement. Default is to not match SE group subnets. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_se_group_subnet")]
        public bool? MatchSeGroupSubnet { get; set; }
        /// <summary>
        /// Priority of the routes created in GCP. Field introduced in 20.1.7, 21.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "route_priority")]
        public int? RoutePriority { get; set; }
    }
}
