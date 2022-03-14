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
    public class NSXTALBApicAgentVsNetworkErrorType 
    {
        public NSXTALBApicAgentVsNetworkErrorType()
        {
        }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pool_network")]
        public string? PoolNetwork { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_network")]
        public string? VsNetwork { get; set; }
    }
}
