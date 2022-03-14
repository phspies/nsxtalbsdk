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
    public class NSXTALBPatchInfoType 
    {
        public NSXTALBPatchInfoType()
        {
        }
        /// <summary>
        /// Patch type describes the controller or se patch type. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_type")]
        public string? PatchType { get; set; }
        /// <summary>
        /// This variable tells whether reboot has to be performed. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "reboot")]
        public bool? Reboot { get; set; }
        /// <summary>
        /// This variable is for full list of patch reboot details. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reboot_list")]
        public IList<NSXTALBRebootDataType> RebootList { get; set; }
    }
}
