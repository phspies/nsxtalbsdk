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
    public class NSXTALBAuthMatchGroupMembershipType 
    {
        /// <summary>
        /// rule match criteria. Enum options - AUTH_MATCH_CONTAINS, AUTH_MATCH_DOES_NOT_CONTAIN, AUTH_MATCH_REGEX.
        /// </summary>
        [JsonProperty(PropertyName = "criteria", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Criteria { get; set; }
        /// <summary>
        /// groups of AuthMatchGroupMembership.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }
    }
}
