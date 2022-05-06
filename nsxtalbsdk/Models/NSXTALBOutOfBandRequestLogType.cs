using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOutOfBandRequestLogType
    {
        /// <summary>
        /// Logs for out-of-band requests sent from the DataScript. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ds_req_logs")]
        public IList<NSXTALBDSRequestLogType> DsReqLogs { get; set; }
    }
}
