using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBvCloudAirConfigurationType
    {
        /// <summary>
        /// vCloudAir access mode. Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Privilege { get; set; }
        /// <summary>
        /// vCloudAir host address.
        /// </summary>
        [JsonProperty(PropertyName = "vca_host")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaHost { get; set; }
        /// <summary>
        /// vCloudAir instance ID.
        /// </summary>
        [JsonProperty(PropertyName = "vca_instance")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaInstance { get; set; }
        /// <summary>
        /// vCloudAir management network.
        /// </summary>
        [JsonProperty(PropertyName = "vca_mgmt_network")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaMgmtNetwork { get; set; }
        /// <summary>
        /// vCloudAir orgnization ID.
        /// </summary>
        [JsonProperty(PropertyName = "vca_orgnization")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaOrgnization { get; set; }
        /// <summary>
        /// vCloudAir password.
        /// </summary>
        [JsonProperty(PropertyName = "vca_password")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaPassword { get; set; }
        /// <summary>
        /// vCloudAir username.
        /// </summary>
        [JsonProperty(PropertyName = "vca_username")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaUsername { get; set; }
        /// <summary>
        /// vCloudAir virtual data center name.
        /// </summary>
        [JsonProperty(PropertyName = "vca_vdc")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcaVdc { get; set; }
    }
}
