using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServiceEnginePolicyApiResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTALBServiceEnginePolicyType> Results { get; set; }
    }
}
