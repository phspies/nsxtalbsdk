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
    public class NSXTALBUpgradeOpsParamType 
    {
        public NSXTALBUpgradeOpsParamType()
        {
        }
        /// <summary>
        /// Image uuid for identifying base image. It is a reference to an object of type Image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "image_ref")]
        public string? ImageRef { get; set; }
        /// <summary>
        /// Image uuid for identifying patch. It is a reference to an object of type Image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_ref")]
        public string? PatchRef { get; set; }
        /// <summary>
        /// This field identifies SE group options that need to be applied during the upgrade operations. Field introduced in
        /// 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_options")]
        public NSXTALBSeGroupOptionsType SeGroupOptions { get; set; }
        /// <summary>
        /// Apply options while resuming SE group upgrade operations. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_resume_options")]
        public NSXTALBSeGroupResumeOptionsType SeGroupResumeOptions { get; set; }
    }
}
