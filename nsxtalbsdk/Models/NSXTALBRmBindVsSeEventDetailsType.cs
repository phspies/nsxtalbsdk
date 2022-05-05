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
    public class NSXTALBRmBindVsSeEventDetailsType 
    {
        /// <summary>
        /// ip of RmBindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// ip6 of RmBindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// List of placement_networks configured on this interface. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// Placeholder for description of property primary of obj type RmBindVsSeEventDetails field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public bool? Primary { get; set; }
        /// <summary>
        /// se_name of RmBindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Placeholder for description of property standby of obj type RmBindVsSeEventDetails field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "standby")]
        public bool? Standby { get; set; }
        /// <summary>
        /// type of RmBindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// vip_vnics of RmBindVsSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vip_vnics")]
        public IList<string> VipVnics { get; set; }
        /// <summary>
        /// vs_name of RmBindVsSeEventDetails.
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
