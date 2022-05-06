using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBParamInURIType
    {
        /// <summary>
        /// Param name in hitted signature rule match_element. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_name")]
        public string? ParamName { get; set; }
        /// <summary>
        /// Param value in hitted signature rule match_element. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
