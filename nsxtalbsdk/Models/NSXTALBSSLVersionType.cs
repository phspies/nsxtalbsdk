using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLVersionType
    {
        /// <summary>
        /// Enum options - SSL_VERSION_SSLV3, SSL_VERSION_TLS1, SSL_VERSION_TLS1_1, SSL_VERSION_TLS1_2, SSL_VERSION_TLS1_3. Allowed
        /// in Basic(Allowed values- SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2) edition,
        /// Essentials(Allowed values- SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
