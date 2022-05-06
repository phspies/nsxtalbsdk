using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNsxtCredentialsType
    {
        /// <summary>
        /// Password to talk to Nsx-t manager. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Username to talk to Nsx-t manager. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
