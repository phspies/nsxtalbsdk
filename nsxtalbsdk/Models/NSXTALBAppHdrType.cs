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
    public class NSXTALBAppHdrType 
    {
        /// <summary>
        /// Enum options - SENSITIVE, INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_match_case", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string HdrMatchCase { get; set; }
        /// <summary>
        /// hdr_name of AppHdr.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string HdrName { get; set; }
        /// <summary>
        /// Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS, DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,
        /// DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH. Allowed in Basic(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL) edition,
        /// Essentials(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_string_op", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string HdrStringOp { get; set; }
    }
}
