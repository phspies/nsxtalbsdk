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
    public class NSXTALBLinuxConfigurationType 
    {
        /// <summary>
        /// Banner displayed before login to ssh, and UI.
        /// </summary>
        [JsonProperty(PropertyName = "banner")]
        public string? Banner { get; set; }
        /// <summary>
        /// Enforce CIS benchmark recommendations for Avi Controller and Service Engines. The enforcement is as per CIS DIL 1.0.1
        /// level 2, for applicable controls. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "cis_mode")]
        public bool? CisMode { get; set; }
        /// <summary>
        /// Message of the day, shown to users on login via the command line interface, web interface, or ssh.
        /// </summary>
        [JsonProperty(PropertyName = "motd")]
        public string? Motd { get; set; }
    }
}
