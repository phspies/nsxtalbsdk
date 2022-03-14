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
    public class NSXTALBRmAddNetworksEventDetailsType 
    {
        public NSXTALBRmAddNetworksEventDetailsType()
        {
        }
        /// <summary>
        /// Placeholder for description of property networks of obj type RmAddNetworksEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<NSXTALBRmAddVnicType> Networks { get; set; }
        /// <summary>
        /// reason of RmAddNetworksEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_name of RmAddNetworksEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// vs_name of RmAddNetworksEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public IList<string> VsName { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public IList<string> VsUuid { get; set; }
    }
}
