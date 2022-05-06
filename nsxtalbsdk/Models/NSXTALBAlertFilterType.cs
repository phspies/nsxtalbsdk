using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAlertFilterType
    {
        /// <summary>
        /// filter_action of AlertFilter.
        /// </summary>
        [JsonProperty(PropertyName = "filter_action")]
        public string? FilterAction { get; set; }
        /// <summary>
        /// filter_string of AlertFilter.
        /// </summary>
        [JsonProperty(PropertyName = "filter_string")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FilterString { get; set; }
    }
}
