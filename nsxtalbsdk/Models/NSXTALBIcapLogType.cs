using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIcapLogType
    {
        /// <summary>
        /// Denotes whether the content was processed by ICAP server and an action was taken. Enum options - ICAP_DISABLED,
        /// ICAP_PASSED, ICAP_MODIFIED, ICAP_BLOCKED, ICAP_FAILED. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Logs for the HTTP request's content sent to the ICAP server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "request_logs")]
        public IList<NSXTALBIcapRequestLogType> RequestLogs { get; set; }
    }
}
