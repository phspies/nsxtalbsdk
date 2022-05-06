using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVlanRangeType
    {
        /// <summary>
        /// Number of end.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        [System.ComponentModel.DataAnnotations.Required]
        public int End { get; set; }
        /// <summary>
        /// Number of start.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Start { get; set; }
    }
}
