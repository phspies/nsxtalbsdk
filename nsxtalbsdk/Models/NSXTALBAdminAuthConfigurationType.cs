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
    public class NSXTALBAdminAuthConfigurationType 
    {
        /// <summary>
        /// Allow any user created locally to login with local credentials. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow_local_user_login")]
        public bool? AllowLocalUserLogin { get; set; }
        /// <summary>
        /// Secondary authentication mechanisms to be used. Field introduced in 20.1.6. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "alternate_auth_configurations")]
        public IList<NSXTALBAlternateAuthConfigurationType> AlternateAuthConfigurations { get; set; }
        /// <summary>
        /// It is a reference to an object of type AuthProfile.
        /// </summary>
        [JsonProperty(PropertyName = "auth_profile_ref")]
        public string? AuthProfileRef { get; set; }
        /// <summary>
        /// Rules list for tenant or role mapping.
        /// </summary>
        [JsonProperty(PropertyName = "mapping_rules")]
        public IList<NSXTALBAuthMappingRuleType> MappingRules { get; set; }
    }
}
