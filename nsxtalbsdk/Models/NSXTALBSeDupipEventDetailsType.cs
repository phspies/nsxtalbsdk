using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeDupipEventDetailsType
    {
        /// <summary>
        /// Mac Address.
        /// </summary>
        [JsonProperty(PropertyName = "local_mac")]
        public string? LocalMac { get; set; }
        /// <summary>
        /// Mac Address.
        /// </summary>
        [JsonProperty(PropertyName = "remote_mac")]
        public string? RemoteMac { get; set; }
        /// <summary>
        /// Vnic IP.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_ip")]
        public string? VnicIp { get; set; }
        /// <summary>
        /// Vnic name.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_name")]
        public string? VnicName { get; set; }
    }
}
