using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBParamSizeClassType
    {
        /// <summary>
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public long? Hits { get; set; }
        /// <summary>
        /// Enum options - EMPTY, SMALL, MEDIUM, LARGE, UNLIMITED. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "len")]
        public string? Len { get; set; }
    }
}
