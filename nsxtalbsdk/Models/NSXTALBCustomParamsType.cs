using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCustomParamsType
    {
        /// <summary>
        /// Placeholder for description of property is_dynamic of obj type CustomParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_dynamic")]
        public bool? IsDynamic { get; set; }
        /// <summary>
        /// Placeholder for description of property is_sensitive of obj type CustomParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_sensitive")]
        public bool? IsSensitive { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// value of CustomParams.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
