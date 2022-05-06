using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBFalsePositiveDetailsType
    {
        /// <summary>
        /// false positive result details. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "false_positive_results")]
        public IList<NSXTALBFalsePositiveResultType> FalsePositiveResults { get; set; }
        /// <summary>
        /// vs id for this false positive details. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
