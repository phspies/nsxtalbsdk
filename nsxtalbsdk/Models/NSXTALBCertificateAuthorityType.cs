using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCertificateAuthorityType
    {
        /// <summary>
        /// It is a reference to an object of type SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ca_ref")]
        public string? CaRef { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
