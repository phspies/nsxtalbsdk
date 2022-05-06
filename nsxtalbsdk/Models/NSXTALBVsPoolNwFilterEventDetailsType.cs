using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVsPoolNwFilterEventDetailsType
    {
        /// <summary>
        /// filter of VsPoolNwFilterEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Filter { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// network of VsPoolNwFilterEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Network { get; set; }
    }
}
