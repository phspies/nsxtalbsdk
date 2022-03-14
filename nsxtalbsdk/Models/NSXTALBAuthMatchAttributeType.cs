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
    public class NSXTALBAuthMatchAttributeType 
    {
        public NSXTALBAuthMatchAttributeType()
        {
        }
        /// <summary>
        /// rule match criteria. Enum options - AUTH_MATCH_CONTAINS, AUTH_MATCH_DOES_NOT_CONTAIN, AUTH_MATCH_REGEX.
        /// </summary>
        [JsonProperty(PropertyName = "criteria", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Criteria { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// values of AuthMatchAttribute.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }
    }
}
