using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLCertificateDescriptionType
    {
        /// <summary>
        /// common_name of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string? CommonName { get; set; }
        /// <summary>
        /// country of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string? Country { get; set; }
        /// <summary>
        /// distinguished_name of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "distinguished_name")]
        public string? DistinguishedName { get; set; }
        /// <summary>
        /// email_address of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "email_address")]
        public string? EmailAddress { get; set; }
        /// <summary>
        /// locality of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "locality")]
        public string? Locality { get; set; }
        /// <summary>
        /// organization of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public string? Organization { get; set; }
        /// <summary>
        /// organization_unit of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "organization_unit")]
        public string? OrganizationUnit { get; set; }
        /// <summary>
        /// state of SSLCertificateDescription.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
    }
}
