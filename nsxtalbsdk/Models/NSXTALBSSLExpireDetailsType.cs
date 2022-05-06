using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLExpireDetailsType
    {
        /// <summary>
        /// Number of days until certificate is expired.
        /// </summary>
        [JsonProperty(PropertyName = "days_left")]
        public int? DaysLeft { get; set; }
        /// <summary>
        /// Name of SSL Certificate.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
