using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBTencentCredentialsType
    {
        /// <summary>
        /// Tencent secret ID. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "secret_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SecretId { get; set; }
        /// <summary>
        /// Tencent secret key. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "secret_key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SecretKey { get; set; }
    }
}
