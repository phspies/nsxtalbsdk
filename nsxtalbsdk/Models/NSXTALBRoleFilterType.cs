using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRoleFilterType
    {
        /// <summary>
        /// Enable this filter. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Label key to match against objects for values. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_label")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRoleFilterMatchLabelType MatchLabel { get; set; }
        /// <summary>
        /// Label match operation criteria. Enum options - ROLE_FILTER_EQUALS, ROLE_FILTER_DOES_NOT_EQUAL, ROLE_FILTER_GLOB_MATCH,
        /// ROLE_FILTER_GLOB_DOES_NOT_MATCH. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_operation")]
        public string? MatchOperation { get; set; }
        /// <summary>
        /// Name for the filter. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
