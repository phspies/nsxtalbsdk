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
    public class NSXTALBVCenterCredentialsType 
    {
        /// <summary>
        /// Password to talk to VCenter server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Username to talk to VCenter server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
