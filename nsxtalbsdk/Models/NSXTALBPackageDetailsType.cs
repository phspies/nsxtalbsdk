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
    public class NSXTALBPackageDetailsType 
    {
        /// <summary>
        /// This contains build related information. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "build")]
        public NSXTALBBuildInfoType Build { get; set; }
        /// <summary>
        /// MD5 checksum over the entire package. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "hash")]
        public string? Hash { get; set; }
        /// <summary>
        /// Patch related necessary information. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch")]
        public NSXTALBPatchInfoType Patch { get; set; }
        /// <summary>
        /// Path of the package in the repository. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
    }
}
