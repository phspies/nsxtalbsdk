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
    public class NSXTALBSSHSeDeploymentType 
    {
        /// <summary>
        /// Host OS distribution e.g. COREOS, UBUNTU, REDHAT. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "host_os")]
        public string? HostOs { get; set; }
        /// <summary>
        /// Password for ssh and/or sudo. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Username for SSH access to hosts. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_user")]
        public string? SshUser { get; set; }
        /// <summary>
        /// Username for sudo. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sudo_user")]
        public string? SudoUser { get; set; }
    }
}
