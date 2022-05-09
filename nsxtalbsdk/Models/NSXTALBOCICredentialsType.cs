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
    public class NSXTALBOCICredentialsType 
    {
        /// <summary>
        /// API key with respect to the Public Key. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        public string? Fingerprint { get; set; }
        /// <summary>
        /// Private Key file (pem file) content. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "key_content")]
        public string? KeyContent { get; set; }
        /// <summary>
        /// Pass phrase for the key. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pass_phrase")]
        public string? PassPhrase { get; set; }
        /// <summary>
        /// Oracle Cloud Id for the User. Field introduced in 18.2.1,18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
    }
}
