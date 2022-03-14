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
    public class NSXTALBRoleMatchOperationMatchLabelType 
    {
        /// <summary>
        /// List of labels allowed for the tenant. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "match_label", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRoleFilterMatchLabelType MatchLabel { get; set; }
        /// <summary>
        /// Label match operation criteria. Enum options - ROLE_FILTER_EQUALS, ROLE_FILTER_DOES_NOT_EQUAL, ROLE_FILTER_GLOB_MATCH,
        /// ROLE_FILTER_GLOB_DOES_NOT_MATCH. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "match_operation")]
        public string? MatchOperation { get; set; }
    }
}
