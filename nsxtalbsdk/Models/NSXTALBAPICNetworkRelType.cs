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
    public class NSXTALBAPICNetworkRelType 
    {
        public NSXTALBAPICNetworkRelType()
        {
        }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "connector")]
        public string? Connector { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rel_key")]
        public string? RelKey { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "target_network")]
        public string? TargetNetwork { get; set; }
    }
}
