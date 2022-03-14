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
    public class NSXTALBEventCacheType 
    {
        public NSXTALBEventCacheType()
        {
        }
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
