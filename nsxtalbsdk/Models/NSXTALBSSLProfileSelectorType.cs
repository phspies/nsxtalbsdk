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
    public class NSXTALBSSLProfileSelectorType 
    {
        /// <summary>
        /// Configure client IP address groups. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_list")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrMatchType ClientIpList { get; set; }
        /// <summary>
        /// SSL profile for the client IP addresses listed. It is a reference to an object of type SSLProfile. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SslProfileRef { get; set; }
    }
}
