using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIngAttributeType
    {
        /// <summary>
        /// Attribute to match. Field introduced in 17.2.15, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "attribute")]
        public string? Attribute { get; set; }
        /// <summary>
        /// Attribute value. If not set, match any value. Field introduced in 17.2.15, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
