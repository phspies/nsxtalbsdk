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
    public class NSXTALBControllerInternalAuthType 
    {
        public NSXTALBControllerInternalAuthType()
        {
        }
        /// <summary>
        /// Symmetric keys used for signing/validating the JWT, only allowed with profile_type CONTROLLER_INTERNAL_AUTH. Field
        /// introduced in 20.1.6. Minimum of 1 items required. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "symmetric_jwks_keys")]
        public IList<NSXTALBJWSKeyType> SymmetricJwksKeys { get; set; }
    }
}
