using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPReselectRespCodeType 
    {
        public NSXTALBHTTPReselectRespCodeType()
        {
        }
        /// <summary>
        /// HTTP response code to be matched. Allowed values are 400-599.
        /// </summary>
        [JsonProperty(PropertyName = "codes")]
        public int? Codes { get; set; }
        /// <summary>
        /// HTTP response code ranges to match.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBHTTPStatusRangeType> Ranges { get; set; }
        /// <summary>
        /// Block of HTTP response codes to match for server reselect. Enum options - HTTP_RSP_4XX, HTTP_RSP_5XX.
        /// </summary>
        [JsonProperty(PropertyName = "resp_code_block")]
        public IList<string> RespCodeBlock { get; set; }
    }
}
