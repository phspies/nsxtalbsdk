using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHealthMonitorAuthInfoType
    {
        /// <summary>
        /// Password for server authentication. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        /// <summary>
        /// Username for server authentication. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
    }
}
