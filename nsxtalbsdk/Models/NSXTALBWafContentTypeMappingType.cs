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
    public class NSXTALBWafContentTypeMappingType 
    {
        /// <summary>
        /// Request Content-Type. When it is equal to request Content-Type header value, the specified request_body_parser is used.
        /// Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "content_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ContentType { get; set; }
        /// <summary>
        /// Request body parser. Enum options - WAF_REQUEST_PARSER_URLENCODED, WAF_REQUEST_PARSER_MULTIPART,
        /// WAF_REQUEST_PARSER_JSON, WAF_REQUEST_PARSER_XML, WAF_REQUEST_PARSER_HANDLE_AS_STRING, WAF_REQUEST_PARSER_DO_NOT_PARSE.
        /// Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "request_body_parser")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RequestBodyParser { get; set; }
    }
}
