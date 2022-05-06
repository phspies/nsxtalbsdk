using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRmModifyNetworksEventDetailsType
    {
        /// <summary>
        /// Placeholder for description of property networks of obj type RmModifyNetworksEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<NSXTALBRmModifyVnicType> Networks { get; set; }
        /// <summary>
        /// reason of RmModifyNetworksEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_name of RmModifyNetworksEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// vs_name of RmModifyNetworksEventDetails.
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
