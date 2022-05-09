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
    public class NSXTALBSSLKeyParamsType 
    {
        /// <summary>
        /// Enum options - SSL_KEY_ALGORITHM_RSA, SSL_KEY_ALGORITHM_EC.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Algorithm { get; set; }
        /// <summary>
        /// Placeholder for description of property ec_params of obj type SSLKeyParams field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ec_params")]
        public NSXTALBSSLKeyECParamsType EcParams { get; set; }
        /// <summary>
        /// Placeholder for description of property rsa_params of obj type SSLKeyParams field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rsa_params")]
        public NSXTALBSSLKeyRSAParamsType RsaParams { get; set; }
    }
}
