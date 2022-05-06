using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBURIInfoType
    {
        /// <summary>
        /// Information about various params under a URI. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_info")]
        public IList<NSXTALBParamInfoType> ParamInfo { get; set; }
        /// <summary>
        /// Total number of URI hits. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uri_hits")]
        public long? UriHits { get; set; }
        /// <summary>
        /// URI name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uri_key")]
        public string? UriKey { get; set; }
    }
}
