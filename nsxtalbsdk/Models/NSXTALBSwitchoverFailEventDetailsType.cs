using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSwitchoverFailEventDetailsType
    {
        /// <summary>
        /// from_se_name of SwitchoverFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "from_se_name")]
        public string? FromSeName { get; set; }
        /// <summary>
        /// ip of SwitchoverFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// ip6 of SwitchoverFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// reason of SwitchoverFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// vs_name of SwitchoverFailEventDetails.
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
