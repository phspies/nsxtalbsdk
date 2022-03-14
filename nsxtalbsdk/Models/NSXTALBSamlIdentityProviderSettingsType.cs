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
    public class NSXTALBSamlIdentityProviderSettingsType 
    {
        public NSXTALBSamlIdentityProviderSettingsType()
        {
        }
        /// <summary>
        /// SAML IDP metadata. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string? Metadata { get; set; }
    }
}
