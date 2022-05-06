using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBControllerPropertiesApiResponseType
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
        public IList<NSXTALBControllerPropertiesType> Results { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string? Next { get; set; }
    }
}
