using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCloudRouteNotifDetailsType
    {
        /// <summary>
        /// Cloud id. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Detailed reason for the route update notification. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Name of route table for which update was performed. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "route_table")]
        public string? RouteTable { get; set; }
        /// <summary>
        /// Names of routes for which update was performed. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<string> Routes { get; set; }
    }
}
