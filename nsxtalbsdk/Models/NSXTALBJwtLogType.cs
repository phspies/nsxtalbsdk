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
    public class NSXTALBJwtLogType 
    {
        /// <summary>
        /// Authentication policy rule match. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "authn_rule_match")]
        public NSXTALBAuthnRuleMatchType AuthnRuleMatch { get; set; }
        /// <summary>
        /// Authorization policy rule match. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "authz_rule_match")]
        public NSXTALBAuthzRuleMatchType AuthzRuleMatch { get; set; }
        /// <summary>
        /// Set to true, if JWT validation is successful. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_jwt_verified")]
        public bool? IsJwtVerified { get; set; }
        /// <summary>
        /// JWT token payload. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "token_payload")]
        public string? TokenPayload { get; set; }
    }
}
