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
    public class NSXTALBVsEvStatusType 
    {
        /// <summary>
        /// notes of VsEvStatus.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public IList<string> Notes { get; set; }
        /// <summary>
        /// request of VsEvStatus.
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public string? Request { get; set; }
        /// <summary>
        /// result of VsEvStatus.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string? Result { get; set; }
    }
}
