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
    public class NSXTALBSeRpcProxyDebugFilterType 
    {
        public NSXTALBSeRpcProxyDebugFilterType()
        {
        }
        /// <summary>
        /// Method name of RPC. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "method_name")]
        public string? MethodName { get; set; }
        /// <summary>
        /// Queue name of RPC. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public string? Queue { get; set; }
        /// <summary>
        /// UUID of Service Engine. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
    }
}
