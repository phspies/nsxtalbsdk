using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAppInfoType
    {
        /// <summary>
        /// app_hdr_name of AppInfo.
        /// </summary>
        [JsonProperty(PropertyName = "app_hdr_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AppHdrName { get; set; }
        /// <summary>
        /// app_hdr_value of AppInfo.
        /// </summary>
        [JsonProperty(PropertyName = "app_hdr_value")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AppHdrValue { get; set; }
    }
}
