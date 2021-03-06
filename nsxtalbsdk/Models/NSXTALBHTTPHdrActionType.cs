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
    public class NSXTALBHTTPHdrActionType 
    {
        /// <summary>
        /// ADD  A new header with the new value is added irrespective of the existence of an HTTP header of the given name. REPLACE
        /// A new header with the new value is added if no header of the given name exists, else existing headers with the given
        /// name are removed and a new header with the new value is added. REMOVE  All the headers of the given name are removed.
        /// Enum options - HTTP_ADD_HDR, HTTP_REMOVE_HDR, HTTP_REPLACE_HDR. Allowed in Basic(Allowed values-
        /// HTTP_REMOVE_HDR,HTTP_REPLACE_HDR) edition, Essentials(Allowed values- HTTP_REMOVE_HDR,HTTP_REPLACE_HDR) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Action { get; set; }
        /// <summary>
        /// Cookie information.
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        public NSXTALBHTTPCookieDataType Cookie { get; set; }
        /// <summary>
        /// HTTP header information.
        /// </summary>
        [JsonProperty(PropertyName = "hdr")]
        public NSXTALBHTTPHdrDataType Hdr { get; set; }
    }
}
