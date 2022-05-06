using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBStaticIpAllocInfoType
    {
        /// <summary>
        /// IP address. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Object metadata. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_info")]
        public string? ObjInfo { get; set; }
        /// <summary>
        /// Object which this IP address is allocated to. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_uuid")]
        public string? ObjUuid { get; set; }
    }
}
