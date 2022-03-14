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
    public class NSXTALBBuildInfoType 
    {
        public NSXTALBBuildInfoType()
        {
        }
        /// <summary>
        /// Build number for easy identification. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "build_no")]
        public int? BuildNo { get; set; }
        /// <summary>
        /// Date when the package created. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public string? Date { get; set; }
        /// <summary>
        /// Min version of the image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "min_version")]
        public string? MinVersion { get; set; }
        /// <summary>
        /// Patch version of the image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_version")]
        public string? PatchVersion { get; set; }
        /// <summary>
        /// Product type. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string? Product { get; set; }
        /// <summary>
        /// Product Name. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "product_name")]
        public string? ProductName { get; set; }
        /// <summary>
        /// Tag related to the package. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
        /// <summary>
        /// Major version of the image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
