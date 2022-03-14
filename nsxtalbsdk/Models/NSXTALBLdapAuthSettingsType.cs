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
    public class NSXTALBLdapAuthSettingsType 
    {
        /// <summary>
        /// The LDAP base DN.  For example, avinetworks.com would be DC=avinetworks,DC=com.
        /// </summary>
        [JsonProperty(PropertyName = "base_dn")]
        public string? BaseDn { get; set; }
        /// <summary>
        /// LDAP administrator credentials are used to search for users and group memberships.
        /// </summary>
        [JsonProperty(PropertyName = "bind_as_administrator")]
        public bool? BindAsAdministrator { get; set; }
        /// <summary>
        /// LDAP attribute that refers to user email.
        /// </summary>
        [JsonProperty(PropertyName = "email_attribute")]
        public string? EmailAttribute { get; set; }
        /// <summary>
        /// LDAP attribute that refers to user's full name.
        /// </summary>
        [JsonProperty(PropertyName = "full_name_attribute")]
        public string? FullNameAttribute { get; set; }
        /// <summary>
        /// Query the LDAP servers on this port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// LDAP connection security mode. Enum options - AUTH_LDAP_SECURE_NONE, AUTH_LDAP_SECURE_USE_LDAPS.
        /// </summary>
        [JsonProperty(PropertyName = "security_mode")]
        public string? SecurityMode { get; set; }
        /// <summary>
        /// LDAP server IP address or Hostname. Use IP address if an auth profile is used to configure Virtual Service. Minimum of 1
        /// items required.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public IList<string> Server { get; set; }
        /// <summary>
        /// LDAP full directory configuration with administrator credentials.
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public NSXTALBLdapDirectorySettingsType Settings { get; set; }
        /// <summary>
        /// LDAP anonymous bind configuration.
        /// </summary>
        [JsonProperty(PropertyName = "user_bind")]
        public NSXTALBLdapUserBindSettingsType UserBind { get; set; }
    }
}
