using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBParamTypeClassType
    {
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public long? Hits { get; set; }
        /// <summary>
        /// Enum options - PARAM_FLAG, PARAM_DIGITS, PARAM_HEXDIGITS, PARAM_WORD, PARAM_SAFE_TEXT, PARAM_SAFE_TEXT_MULTILINE,
        /// PARAM_TEXT, PARAM_TEXT_MULTILINE, PARAM_ALL. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
