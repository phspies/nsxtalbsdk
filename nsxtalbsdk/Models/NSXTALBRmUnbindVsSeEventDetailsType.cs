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
    public class NSXTALBRmUnbindVsSeEventDetailsType 
    {
        public NSXTALBRmUnbindVsSeEventDetailsType()
        {
        }
        /// <summary>
        /// ip of RmUnbindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// ip6 of RmUnbindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// reason of RmUnbindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_name of RmUnbindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// vs_name of RmUnbindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
