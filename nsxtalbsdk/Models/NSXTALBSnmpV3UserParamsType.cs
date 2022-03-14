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
    public class NSXTALBSnmpV3UserParamsType 
    {
        /// <summary>
        /// SNMP V3 authentication passphrase. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "auth_passphrase")]
        public string? AuthPassphrase { get; set; }
        /// <summary>
        /// SNMP V3 user authentication type. Enum options - SNMP_V3_AUTH_MD5, SNMP_V3_AUTH_SHA, SNMP_V3_AUTH_SHA_224,
        /// SNMP_V3_AUTH_SHA_256, SNMP_V3_AUTH_SHA_384, SNMP_V3_AUTH_SHA_512. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "auth_type")]
        public string? AuthType { get; set; }
        /// <summary>
        /// SNMP V3 privacy passphrase. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "priv_passphrase")]
        public string? PrivPassphrase { get; set; }
        /// <summary>
        /// SNMP V3 privacy setting. Enum options - SNMP_V3_PRIV_DES, SNMP_V3_PRIV_AES. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "priv_type")]
        public string? PrivType { get; set; }
        /// <summary>
        /// SNMP username to be used by SNMP clients for performing SNMP walk. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
