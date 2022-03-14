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
    public class NSXTALBRmRebootSeEventDetailsType 
    {
        public NSXTALBRmRebootSeEventDetailsType()
        {
        }
        /// <summary>
        /// reason of RmRebootSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_name of RmRebootSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
    }
}
