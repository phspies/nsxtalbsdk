using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCloudMetaType
    {
        /// <summary>
        /// key of CloudMeta.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// value of CloudMeta.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    }
}
