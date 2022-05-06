using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMesosAttributeType
    {
        /// <summary>
        /// Attribute to match.
        /// </summary>
        [JsonProperty(PropertyName = "attribute")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Attribute { get; set; }
        /// <summary>
        /// Attribute value. If not set, match any value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
