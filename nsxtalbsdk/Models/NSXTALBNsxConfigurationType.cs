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
    public class NSXTALBNsxConfigurationType 
    {
        /// <summary>
        /// This prefix will be added to the names of all NSX objects created by Avi Controller. It should be unique across all the
        /// Avi Controller clusters. Field deprecated in 21.1.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "avi_nsx_prefix", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AviNsxPrefix { get; set; }
        /// <summary>
        /// The hostname or IP address of the NSX MGr. Field deprecated in 21.1.1. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_manager_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NsxManagerName { get; set; }
        /// <summary>
        /// The password Avi Vantage will use when authenticating with NSX Mgr. Field deprecated in 21.1.1. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_manager_password", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NsxManagerPassword { get; set; }
        /// <summary>
        /// The username Avi Vantage will use when authenticating with NSX Mgr. Field deprecated in 21.1.1. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_manager_username", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NsxManagerUsername { get; set; }
        /// <summary>
        /// The interval (in secs) with which Avi Controller polls the NSX Manager for updates. Field deprecated in 21.1.1. Field
        /// introduced in 17.1.1. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_poll_time", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int NsxPollTime { get; set; }
    }
}
