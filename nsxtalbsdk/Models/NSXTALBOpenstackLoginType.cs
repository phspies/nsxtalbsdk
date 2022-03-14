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
    public class NSXTALBOpenstackLoginType 
    {
        /// <summary>
        /// admin_tenant of OpenstackLogin.
        /// </summary>
        [JsonProperty(PropertyName = "admin_tenant")]
        public string? AdminTenant { get; set; }
        /// <summary>
        /// auth_url of OpenstackLogin.
        /// </summary>
        [JsonProperty(PropertyName = "auth_url")]
        public string? AuthUrl { get; set; }
        /// <summary>
        /// keystone_host of OpenstackLogin.
        /// </summary>
        [JsonProperty(PropertyName = "keystone_host")]
        public string? KeystoneHost { get; set; }
        /// <summary>
        /// password of OpenstackLogin.
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        /// <summary>
        /// region of OpenstackLogin.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// username of OpenstackLogin.
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
    }
}
