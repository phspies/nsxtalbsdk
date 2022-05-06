using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDetachIpStatusEventDetailsType
    {
        /// <summary>
        /// Reason if Detach IP failed. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Name of the Service Engine. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// VIP ID. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// Name of the Virtual Service. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
    }
}
