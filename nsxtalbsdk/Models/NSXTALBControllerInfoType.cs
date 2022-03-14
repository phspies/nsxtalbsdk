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
    public class NSXTALBControllerInfoType 
    {
        public NSXTALBControllerInfoType()
        {
        }
        /// <summary>
        /// Total controller memory usage in GBs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "current_controller_mem_usage")]
        public double? CurrentControllerMemUsage { get; set; }
    }
}
