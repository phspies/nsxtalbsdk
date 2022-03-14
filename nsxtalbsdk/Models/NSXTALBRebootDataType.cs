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
    public class NSXTALBRebootDataType 
    {
        public NSXTALBRebootDataType()
        {
        }
        /// <summary>
        /// Patch version for which reboot flag need to be computed. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "patch_version")]
        public string? PatchVersion { get; set; }
        /// <summary>
        /// This variable tells whether reboot has to be performed. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reboot")]
        public bool? Reboot { get; set; }
    }
}
