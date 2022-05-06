using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVssPlacementType
    {
        /// <summary>
        /// Degree of core non-affinity for VS placement. Allowed values are 1-256. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "core_nonaffinity")]
        public int? CoreNonaffinity { get; set; }
        /// <summary>
        /// Number of sub-cores that comprise a CPU core. Allowed values are 1-128. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_subcores")]
        public int? NumSubcores { get; set; }
    }
}
