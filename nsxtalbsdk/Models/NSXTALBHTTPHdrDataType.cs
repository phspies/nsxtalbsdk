using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPHdrDataType
    {
        /// <summary>
        /// HTTP header name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// HTTP header value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public NSXTALBHTTPHdrValueType Value { get; set; }
    }
}
