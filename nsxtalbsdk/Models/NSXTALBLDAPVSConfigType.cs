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
    public class NSXTALBLDAPVSConfigType 
    {
        /// <summary>
        /// Basic authentication realm to present to a user along with the prompt for credentials. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "realm")]
        public string? Realm { get; set; }
        /// <summary>
        /// Default bind timeout enforced on connections to LDAP server. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_bind_timeout")]
        public int? SeAuthLdapBindTimeout { get; set; }
        /// <summary>
        /// Size of LDAP auth credentials cache used on the dataplane. Field introduced in 21.1.1. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_cache_size")]
        public int? SeAuthLdapCacheSize { get; set; }
        /// <summary>
        /// Default connection timeout enforced on connections to LDAP server. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_connect_timeout")]
        public int? SeAuthLdapConnectTimeout { get; set; }
        /// <summary>
        /// Number of concurrent connections to LDAP server by a single basic auth LDAP process. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_conns_per_server")]
        public int? SeAuthLdapConnsPerServer { get; set; }
        /// <summary>
        /// Default reconnect timeout enforced on connections to LDAP server. Field introduced in 21.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_reconnect_timeout")]
        public int? SeAuthLdapReconnectTimeout { get; set; }
        /// <summary>
        /// Default login or group search request timeout enforced on connections to LDAP server. Field introduced in 21.1.1. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_request_timeout")]
        public int? SeAuthLdapRequestTimeout { get; set; }
        /// <summary>
        /// If enabled, connections are always made to the first available LDAP server in the list and will failover to subsequent
        /// servers. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_servers_failover_only")]
        public bool? SeAuthLdapServersFailoverOnly { get; set; }
    }
}
