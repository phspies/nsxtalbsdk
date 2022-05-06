using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBJWSKeyType
    {
        /// <summary>
        /// Algorithm that need to be used while signing/validation, allowed values  HS256, HS384, HS512. Field introduced in
        /// 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "alg")]
        public string? Alg { get; set; }
        /// <summary>
        /// Secret JWK for signing/validation, length of the key varies depending upon the type of algorithm used for key generation
        /// {HS256  32 bytes, HS384  48bytes, HS512  64 bytes}. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// Unique key id across all keys. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Kid { get; set; }
        /// <summary>
        /// Secret key type/format, allowed value  octet(oct). Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "kty")]
        public string? Kty { get; set; }
    }
}
