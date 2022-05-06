using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNsxtHostsType
    {
        /// <summary>
        /// List of transport nodes. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "host_ids")]
        public IList<string> HostIds { get; set; }
        /// <summary>
        /// Include or Exclude. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "include")]
        public bool? Include { get; set; }
    }
}
