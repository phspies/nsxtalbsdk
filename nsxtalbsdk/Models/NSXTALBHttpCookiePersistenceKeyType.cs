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
    public class NSXTALBHttpCookiePersistenceKeyType 
    {
        public NSXTALBHttpCookiePersistenceKeyType()
        {
        }
        /// <summary>
        /// aes_key of HttpCookiePersistenceKey.
        /// </summary>
        [JsonProperty(PropertyName = "aes_key")]
        public string? AesKey { get; set; }
        /// <summary>
        /// hmac_key of HttpCookiePersistenceKey.
        /// </summary>
        [JsonProperty(PropertyName = "hmac_key")]
        public string? HmacKey { get; set; }
        /// <summary>
        /// name to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
