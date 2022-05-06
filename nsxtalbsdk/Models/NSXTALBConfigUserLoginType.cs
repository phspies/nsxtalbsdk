using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBConfigUserLoginType
    {
        /// <summary>
        /// client ip.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public string? ClientIp { get; set; }
        /// <summary>
        /// Type of client used to login UI, CLI, others(API). Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "client_type")]
        public string? ClientType { get; set; }
        /// <summary>
        /// error message if authentication failed.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Local user. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public bool? Local { get; set; }
        /// <summary>
        /// Additional attributes from login handler. Field introduced in 18.1.4,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "remote_attributes")]
        public string? RemoteAttributes { get; set; }
        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// Request user.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
    }
}
