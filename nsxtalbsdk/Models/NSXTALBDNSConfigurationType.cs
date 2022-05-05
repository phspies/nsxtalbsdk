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
    public class NSXTALBDNSConfigurationType 
    {
        /// <summary>
        /// Search domain to use in DNS lookup.
        /// </summary>
        [JsonProperty(PropertyName = "search_domain")]
        public string? SearchDomain { get; set; }
        /// <summary>
        /// List of DNS Server IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "server_list")]
        public IList<NSXTALBIpAddrType> ServerList { get; set; }
    }
}
