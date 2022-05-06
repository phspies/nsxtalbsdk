using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGCPCredentialsType
    {
        /// <summary>
        /// Google Cloud Platform Service Account keyfile data in JSON format. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_account_keyfile_data")]
        public string? ServiceAccountKeyfileData { get; set; }
    }
}
