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
    public class NSXTALBLicenseUsageType 
    {
        /// <summary>
        /// Total license cores available for consumption. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public double? Available { get; set; }
        /// <summary>
        /// Total license cores consumed. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "consumed")]
        public double? Consumed { get; set; }
        /// <summary>
        /// Total license cores reserved or escrowed. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "escrow")]
        public double? Escrow { get; set; }
        /// <summary>
        /// Total license cores remaining for consumption. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "remaining")]
        public double? Remaining { get; set; }
    }
}
