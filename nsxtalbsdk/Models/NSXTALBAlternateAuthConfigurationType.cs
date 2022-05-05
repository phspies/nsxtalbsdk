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
    public class NSXTALBAlternateAuthConfigurationType 
    {
        /// <summary>
        /// UUID of the authprofile. It is a reference to an object of type AuthProfile. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "auth_profile_ref")]
        public string? AuthProfileRef { get; set; }
        /// <summary>
        /// index used for maintaining order of AlternateAuthConfiguration. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Rules list for tenant or role mapping. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "mapping_rules")]
        public IList<NSXTALBAuthMappingRuleType> MappingRules { get; set; }
    }
}
