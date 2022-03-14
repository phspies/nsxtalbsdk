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
    public class NSXTALBVcenterLoginType 
    {
        public NSXTALBVcenterLoginType()
        {
        }
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// password of VcenterLogin.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Number of start_ts.
        /// </summary>
        [JsonProperty(PropertyName = "start_ts")]
        public long? StartTs { get; set; }
        /// <summary>
        /// username of VcenterLogin.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// vcenter_url of VcenterLogin.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url")]
        public string? VcenterUrl { get; set; }
    }
}
