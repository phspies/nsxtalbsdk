using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBJWTClaimMatchType
    {
        /// <summary>
        /// Boolean value against which the claim is matched. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "bool_match")]
        public bool? BoolMatch { get; set; }
        /// <summary>
        /// Integer value against which the claim is matched. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "int_match")]
        public int? IntMatch { get; set; }
        /// <summary>
        /// Specified Claim should be present in the JWT. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_mandatory")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsMandatory { get; set; }
        /// <summary>
        /// JWT Claim name to be validated. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// String values against which the claim is matched. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "string_match")]
        public NSXTALBStringMatchType StringMatch { get; set; }
        /// <summary>
        /// Specifies the type of the Claim. Enum options - JWT_CLAIM_TYPE_BOOL, JWT_CLAIM_TYPE_INT, JWT_CLAIM_TYPE_STRING. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// Specifies whether to validate the Claim value. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "validate")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Validate { get; set; }
    }
}
