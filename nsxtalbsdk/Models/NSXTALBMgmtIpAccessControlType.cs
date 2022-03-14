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
    public class NSXTALBMgmtIpAccessControlType 
    {
        /// <summary>
        /// Configure IP addresses to access controller using API.
        /// </summary>
        [JsonProperty(PropertyName = "api_access")]
        public NSXTALBIpAddrMatchType ApiAccess { get; set; }
        /// <summary>
        /// Configure IP addresses to access controller using CLI Shell.
        /// </summary>
        [JsonProperty(PropertyName = "shell_server_access")]
        public NSXTALBIpAddrMatchType ShellServerAccess { get; set; }
        /// <summary>
        /// Configure IP addresses to access controller using SNMP.
        /// </summary>
        [JsonProperty(PropertyName = "snmp_access")]
        public NSXTALBIpAddrMatchType SnmpAccess { get; set; }
        /// <summary>
        /// Configure IP addresses to access controller using SSH.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_access")]
        public NSXTALBIpAddrMatchType SshAccess { get; set; }
        /// <summary>
        /// Configure IP addresses to access controller using sysint access. Field introduced in 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sysint_access")]
        public NSXTALBIpAddrMatchType SysintAccess { get; set; }
    }
}
