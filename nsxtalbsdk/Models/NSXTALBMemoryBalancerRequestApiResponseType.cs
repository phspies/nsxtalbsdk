using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMemoryBalancerRequestApiResponseType
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
        public IList<NSXTALBMemoryBalancerRequestType> Results { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string? Next { get; set; }
    }
}
