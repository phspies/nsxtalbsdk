using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLKeyECParamsType
    {
        /// <summary>
        /// Enum options - SSL_KEY_EC_CURVE_SECP256R1, SSL_KEY_EC_CURVE_SECP384R1, SSL_KEY_EC_CURVE_SECP521R1.
        /// </summary>
        [JsonProperty(PropertyName = "curve")]
        public string? Curve { get; set; }
    }
}
