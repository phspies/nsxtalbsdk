using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPRewriteURLActionType
    {
        /// <summary>
        /// Host config.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBURIParamType HostHdr { get; set; }
        /// <summary>
        /// Path config.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBURIParamType Path { get; set; }
        /// <summary>
        /// Query config.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public NSXTALBURIParamQueryType Query { get; set; }
    }
}
