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
    public class NSXTALBNTPConfigurationType 
    {
        /// <summary>
        /// NTP Authentication keys.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_authentication_keys")]
        public IList<NSXTALBNTPAuthenticationKeyType> NtpAuthenticationKeys { get; set; }
        /// <summary>
        /// List of NTP server hostnames or IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_server_list")]
        public IList<NSXTALBIpAddrType> NtpServerList { get; set; }
        /// <summary>
        /// List of NTP Servers.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_servers")]
        public IList<NSXTALBNTPServerType> NtpServers { get; set; }
    }
}
