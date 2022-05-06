using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIpAddrRangeType
    {
        /// <summary>
        /// Starting IP address of the range.
        /// </summary>
        [JsonProperty(PropertyName = "begin")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Begin { get; set; }
        /// <summary>
        /// Ending IP address of the range.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType End { get; set; }
    }
}
