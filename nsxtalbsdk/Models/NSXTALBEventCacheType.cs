using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBEventCacheType
    {
        /// <summary>
        /// Placeholder for description of property dns_state of obj type EventCache field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "dns_state")]
        public bool? DnsState { get; set; }
        /// <summary>
        /// Cache the exception strings in the system.
        /// </summary>
        [JsonProperty(PropertyName = "exceptions")]
        public IList<string> Exceptions { get; set; }
    }
}
