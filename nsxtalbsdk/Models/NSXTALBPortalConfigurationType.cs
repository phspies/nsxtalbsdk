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
    public class NSXTALBPortalConfigurationType 
    {
        public NSXTALBPortalConfigurationType()
        {
        }
        /// <summary>
        /// Enable/Disable HTTP basic authentication.
        /// </summary>
        [JsonProperty(PropertyName = "allow_basic_authentication")]
        public bool? AllowBasicAuthentication { get; set; }
        /// <summary>
        /// Force API session timeout after the specified time (in hours). Allowed values are 1-24. Field introduced in 18.2.3. Unit
        /// is HOURS.
        /// </summary>
        [JsonProperty(PropertyName = "api_force_timeout")]
        public int? ApiForceTimeout { get; set; }
        /// <summary>
        /// Disable Remote CLI Shell Client access.
        /// </summary>
        [JsonProperty(PropertyName = "disable_remote_cli_shell")]
        public bool? DisableRemoteCliShell { get; set; }
        /// <summary>
        /// Disable Swagger access. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "disable_swagger")]
        public bool? DisableSwagger { get; set; }
        /// <summary>
        /// Enable/Disable Clickjacking protection.
        /// </summary>
        [JsonProperty(PropertyName = "enable_clickjacking_protection")]
        public bool? EnableClickjackingProtection { get; set; }
        /// <summary>
        /// Placeholder for description of property enable_http of obj type PortalConfiguration field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "enable_http")]
        public bool? EnableHttp { get; set; }
        /// <summary>
        /// Placeholder for description of property enable_https of obj type PortalConfiguration field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "enable_https")]
        public bool? EnableHttps { get; set; }
        /// <summary>
        /// HTTP port.
        /// </summary>
        [JsonProperty(PropertyName = "http_port")]
        public int? HttpPort { get; set; }
        /// <summary>
        /// HTTPS port.
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public int? HttpsPort { get; set; }
        /// <summary>
        /// Minimum password length for user accounts. Allowed values are 6-32. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "minimum_password_length")]
        public int? MinimumPasswordLength { get; set; }
        /// <summary>
        /// Strict checking of password strength for user accounts.
        /// </summary>
        [JsonProperty(PropertyName = "password_strength_check")]
        public bool? PasswordStrengthCheck { get; set; }
        /// <summary>
        /// Placeholder for description of property redirect_to_https of obj type PortalConfiguration field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "redirect_to_https")]
        public bool? RedirectToHttps { get; set; }
        /// <summary>
        /// Certificates for system portal. Maximum 2 allowed. Leave list empty to use system default certs. It is a reference to an
        /// object of type SSLKeyAndCertificate. Maximum of 2 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "sslkeyandcertificate_refs")]
        public IList<string> SslkeyandcertificateRefs { get; set; }
        /// <summary>
        /// It is a reference to an object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "sslprofile_ref")]
        public string? SslprofileRef { get; set; }
        /// <summary>
        /// Use UUID in POST object data as UUID of the new object, instead of a generated UUID.
        /// </summary>
        [JsonProperty(PropertyName = "use_uuid_from_input")]
        public bool? UseUuidFromInput { get; set; }
    }
}
