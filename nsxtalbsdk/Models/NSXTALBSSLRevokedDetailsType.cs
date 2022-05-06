using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLRevokedDetailsType
    {
        /// <summary>
        /// Name of SSL Certificate. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Certificate revocation reason provided by OCSP Responder. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
    }
}
