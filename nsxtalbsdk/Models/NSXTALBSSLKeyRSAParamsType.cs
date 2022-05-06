using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLKeyRSAParamsType
    {
        /// <summary>
        /// Number of exponent.
        /// </summary>
        [JsonProperty(PropertyName = "exponent")]
        public int? Exponent { get; set; }
        /// <summary>
        /// Enum options - SSL_KEY_1024_BITS, SSL_KEY_2048_BITS, SSL_KEY_3072_BITS, SSL_KEY_4096_BITS.
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        public string? KeySize { get; set; }
    }
}
