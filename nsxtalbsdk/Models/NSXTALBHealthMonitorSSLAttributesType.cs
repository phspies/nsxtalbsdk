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
    public class NSXTALBHealthMonitorSSLAttributesType 
    {
        /// <summary>
        /// PKI profile used to validate the SSL certificate presented by a server. It is a reference to an object of type
        /// PKIProfile. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_ref")]
        public string? PkiProfileRef { get; set; }
        /// <summary>
        /// Fully qualified DNS hostname which will be used in the TLS SNI extension in server connections indicating SNI is
        /// enabled. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        public string? ServerName { get; set; }
        /// <summary>
        /// Service engines will present this SSL certificate to the server. It is a reference to an object of type
        /// SSLKeyAndCertificate. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_ref")]
        public string? SslKeyAndCertificateRef { get; set; }
        /// <summary>
        /// SSL profile defines ciphers and SSL versions to be used for healthmonitor traffic to the back-end servers. It is a
        /// reference to an object of type SSLProfile. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SslProfileRef { get; set; }
    }
}
