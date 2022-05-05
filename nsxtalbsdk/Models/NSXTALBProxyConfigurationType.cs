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
    public class NSXTALBProxyConfigurationType 
    {
        /// <summary>
        /// Proxy hostname or IP address.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Host { get; set; }
        /// <summary>
        /// Password for proxy.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Proxy port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Port { get; set; }
        /// <summary>
        /// Username for proxy.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
