using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAttackMetaDataType
    {
        /// <summary>
        /// DNS amplification attack record. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "amplification")]
        public NSXTALBAttackDnsAmplificationType Amplification { get; set; }
        /// <summary>
        /// ip of AttackMetaData.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// Number of max_resp_time.
        /// </summary>
        [JsonProperty(PropertyName = "max_resp_time")]
        public int? MaxRespTime { get; set; }
        /// <summary>
        /// url of AttackMetaData.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
    }
}
