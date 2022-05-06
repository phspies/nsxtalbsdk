using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIAdminCredentialsType
    {
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// password of VIAdminCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        public string? Privilege { get; set; }
        /// <summary>
        /// vcenter_url of VIAdminCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcenterUrl { get; set; }
        /// <summary>
        /// vi_mgr_token of VIAdminCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "vi_mgr_token")]
        public string? ViMgrToken { get; set; }
    }
}
