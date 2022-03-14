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
    public class NSXTALBTacacsPlusAuthSettingsType 
    {
        /// <summary>
        /// TACACS+ authorization attribute value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "authorization_attrs")]
        public IList<NSXTALBAuthTacacsPlusAttributeValuePairType> AuthorizationAttrs { get; set; }
        /// <summary>
        /// TACACS+ server shared secret.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// TACACS+ server listening port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// TACACS+ server IP address or FQDN. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public IList<string> Server { get; set; }
        /// <summary>
        /// TACACS+ service. Enum options - AUTH_TACACS_PLUS_SERVICE_NONE, AUTH_TACACS_PLUS_SERVICE_LOGIN,
        /// AUTH_TACACS_PLUS_SERVICE_ENABLE, AUTH_TACACS_PLUS_SERVICE_PPP, AUTH_TACACS_PLUS_SERVICE_ARAP,
        /// AUTH_TACACS_PLUS_SERVICE_PT, AUTH_TACACS_PLUS_SERVICE_RCMD, AUTH_TACACS_PLUS_SERVICE_X25, AUTH_TACACS_PLUS_SERVICE_NASI,
        /// AUTH_TACACS_PLUS_SERVICE_FWPROXY.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string? Service { get; set; }
    }
}
