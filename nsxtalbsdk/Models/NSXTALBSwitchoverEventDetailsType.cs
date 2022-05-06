using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSwitchoverEventDetailsType
    {
        /// <summary>
        /// from_se_name of SwitchoverEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "from_se_name")]
        public string? FromSeName { get; set; }
        /// <summary>
        /// ip of SwitchoverEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// ip6 of SwitchoverEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// Reason for switchover. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// to_se_name of SwitchoverEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "to_se_name")]
        public string? ToSeName { get; set; }
        /// <summary>
        /// vs_name of SwitchoverEventDetails.
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
