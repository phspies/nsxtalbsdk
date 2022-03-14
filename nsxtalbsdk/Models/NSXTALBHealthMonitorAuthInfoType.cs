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
    public class NSXTALBHealthMonitorAuthInfoType 
    {
        /// <summary>
        /// Password for server authentication. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        /// <summary>
        /// Username for server authentication. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
    }
}
