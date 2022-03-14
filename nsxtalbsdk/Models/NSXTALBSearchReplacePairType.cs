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
    public class NSXTALBSearchReplacePairType 
    {
        public NSXTALBSearchReplacePairType()
        {
        }
        /// <summary>
        /// String to replace the searched value. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "replacement_string")]
        public NSXTALBReplaceStringVarType ReplacementString { get; set; }
        /// <summary>
        /// String to search for in the body. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "search_string", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBSearchStringVarType SearchString { get; set; }
    }
}
