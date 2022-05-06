using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDNSVsSyncInfoType
    {
        /// <summary>
        /// error of DNSVsSyncInfo.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Number of total_records.
        /// </summary>
        [JsonProperty(PropertyName = "total_records")]
        public int? TotalRecords { get; set; }
    }
}
