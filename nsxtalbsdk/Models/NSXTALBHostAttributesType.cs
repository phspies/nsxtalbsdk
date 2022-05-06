using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHostAttributesType
    {
        /// <summary>
        /// attr_key of HostAttributes.
        /// </summary>
        [JsonProperty(PropertyName = "attr_key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttrKey { get; set; }
        /// <summary>
        /// attr_val of HostAttributes.
        /// </summary>
        [JsonProperty(PropertyName = "attr_val")]
        public string? AttrVal { get; set; }
    }
}
