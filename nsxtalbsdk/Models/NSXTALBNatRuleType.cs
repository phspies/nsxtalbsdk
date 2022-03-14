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
    public class NSXTALBNatRuleType 
    {
        /// <summary>
        /// Nat rule Action Information. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBNatPolicyActionType Action { get; set; }
        /// <summary>
        /// Creator name. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Nat rule enable flag. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enable { get; set; }
        /// <summary>
        /// Nat rule Index. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Nat rule Match Criteria. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "match", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBNatMatchTargetType Match { get; set; }
        /// <summary>
        /// Nat rule Name. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
