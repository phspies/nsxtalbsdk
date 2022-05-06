using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCloudConnectorDebugFilterType
    {
        /// <summary>
        /// filter debugs for an app.
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string? AppId { get; set; }
        /// <summary>
        /// Disable SE reboot via cloud connector on HB miss.
        /// </summary>
        [JsonProperty(PropertyName = "disable_se_reboot")]
        public bool? DisableSeReboot { get; set; }
        /// <summary>
        /// filter debugs for a SE.
        /// </summary>
        [JsonProperty(PropertyName = "se_id")]
        public string? SeId { get; set; }
    }
}
