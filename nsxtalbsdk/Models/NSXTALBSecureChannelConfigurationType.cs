using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSecureChannelConfigurationType
    {
        /// <summary>
        /// Boolean which allowed force update of secure channel certificate. Forced updating has been disallowed. Field deprecated
        /// in 18.2.8. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "bypass_secure_channel_must_checks")]
        public bool? BypassSecureChannelMustChecks { get; set; }
        /// <summary>
        /// Certificate for secure channel. Leave list empty to use system default certs. It is a reference to an object of type
        /// SSLKeyAndCertificate. Field introduced in 18.1.4, 18.2.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "sslkeyandcertificate_refs")]
        public IList<string> SslkeyandcertificateRefs { get; set; }
    }
}
