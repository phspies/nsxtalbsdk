using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSEFaultInjectExhaustParamType
    {
        /// <summary>
        /// Placeholder for description of property leak of obj type SEFaultInjectExhaustParam field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "leak")]
        public bool? Leak { get; set; }
        /// <summary>
        /// Number of num.
        /// </summary>
        [JsonProperty(PropertyName = "num")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Num { get; set; }
    }
}
