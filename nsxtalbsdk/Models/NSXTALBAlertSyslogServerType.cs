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
    public class NSXTALBAlertSyslogServerType 
    {
        /// <summary>
        /// Enable anonymous authentication of Syslog Serverwhich will disable server certificate authentication. Field introduced
        /// in 17.2.17, 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "anon_auth")]
        public bool? AnonAuth { get; set; }
        /// <summary>
        /// Syslog output format - legacy, RFC 5424, JSON. Enum options - SYSLOG_LEGACY, SYSLOG_RFC5424, SYSLOG_JSON,
        /// SYSLOG_RFC5425_ENHANCED. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string? Format { get; set; }
        /// <summary>
        /// Select the PKIProfile containing a CA or list of CA chainswhich will validate the certificate of the syslog server. It
        /// is a reference to an object of type PKIProfile. Field introduced in 17.2.17, 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "pkiprofile_ref")]
        public string? PkiprofileRef { get; set; }
        /// <summary>
        /// Select a certificate and key which will be used to authenticate to the syslog server. It is a reference to an object of
        /// type SSLKeyAndCertificate. Field introduced in 17.2.17, 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_ref")]
        public string? SslKeyAndCertificateRef { get; set; }
        /// <summary>
        /// The destination Syslog server IP address or hostname.
        /// </summary>
        [JsonProperty(PropertyName = "syslog_server")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SyslogServer { get; set; }
        /// <summary>
        /// The destination Syslog server's service port.
        /// </summary>
        [JsonProperty(PropertyName = "syslog_server_port")]
        public int? SyslogServerPort { get; set; }
        /// <summary>
        /// Enable TLS to the syslog server. Field introduced in 17.2.16, 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "tls_enable")]
        public bool? TlsEnable { get; set; }
        /// <summary>
        /// Network protocol to establish syslog session.
        /// </summary>
        [JsonProperty(PropertyName = "udp")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Udp { get; set; }
    }
}
