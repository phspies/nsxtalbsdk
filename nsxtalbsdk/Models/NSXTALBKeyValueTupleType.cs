using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBKeyValueTupleType
    {
        /// <summary>
        /// Key. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// Value. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
