using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeThreshEventDetailsType
    {
        /// <summary>
        /// Number of curr_value.
        /// </summary>
        [JsonProperty(PropertyName = "curr_value")]
        [System.ComponentModel.DataAnnotations.Required]
        public long CurrValue { get; set; }
        /// <summary>
        /// Number of thresh.
        /// </summary>
        [JsonProperty(PropertyName = "thresh")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Thresh { get; set; }
    }
}
