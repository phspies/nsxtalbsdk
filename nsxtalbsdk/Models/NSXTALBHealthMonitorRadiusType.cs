using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHealthMonitorRadiusType
    {
        /// <summary>
        /// Radius monitor will query Radius server with this password. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        /// <summary>
        /// Radius monitor will query Radius server with this shared secret. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "shared_secret")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SharedSecret { get; set; }
        /// <summary>
        /// Radius monitor will query Radius server with this username. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
    }
}
