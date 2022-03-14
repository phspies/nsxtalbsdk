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
    public class NSXTALBNTPAuthenticationKeyType 
    {
        /// <summary>
        /// Message Digest Algorithm used for NTP authentication. Default is NTP_AUTH_ALGORITHM_MD5. Enum options -
        /// NTP_AUTH_ALGORITHM_MD5, NTP_AUTH_ALGORITHM_SHA1.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        public string? Algorithm { get; set; }
        /// <summary>
        /// NTP Authentication key.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// Key number to be assigned to the authentication-key. Allowed values are 1-65534.
        /// </summary>
        [JsonProperty(PropertyName = "key_number", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int KeyNumber { get; set; }
    }
}
