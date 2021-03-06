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
    public class NSXTALBDebugSeCpuSharesType 
    {
        /// <summary>
        /// Number of cpu.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Cpu { get; set; }
        /// <summary>
        /// Number of shares.
        /// </summary>
        [JsonProperty(PropertyName = "shares")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Shares { get; set; }
    }
}
