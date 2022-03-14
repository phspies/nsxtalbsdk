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
    public class NSXTALBTencentCredentialsType 
    {
        public NSXTALBTencentCredentialsType()
        {
        }
        /// <summary>
        /// Tencent secret ID. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "secret_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SecretId { get; set; }
        /// <summary>
        /// Tencent secret key. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "secret_key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SecretKey { get; set; }
    }
}
