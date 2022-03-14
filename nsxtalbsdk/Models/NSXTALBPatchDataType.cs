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
    public class NSXTALBPatchDataType 
    {
        public NSXTALBPatchDataType()
        {
        }
        /// <summary>
        /// Image path of current patch image. . Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "patch_image_path")]
        public string? PatchImagePath { get; set; }
        /// <summary>
        /// Image uuid for identifying the patch. It is a reference to an object of type Image. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "patch_image_ref")]
        public string? PatchImageRef { get; set; }
        /// <summary>
        /// Patch version. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "patch_version")]
        public string? PatchVersion { get; set; }
    }
}
