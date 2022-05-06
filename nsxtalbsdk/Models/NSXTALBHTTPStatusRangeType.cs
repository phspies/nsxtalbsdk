using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPStatusRangeType
    {
        /// <summary>
        /// Starting HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "begin")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Begin { get; set; }
        /// <summary>
        /// Ending HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        [System.ComponentModel.DataAnnotations.Required]
        public int End { get; set; }
    }
}
