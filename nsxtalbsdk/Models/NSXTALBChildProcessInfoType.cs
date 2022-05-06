using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBChildProcessInfoType
    {
        /// <summary>
        /// Amount of memory (in MB) used by the sub process.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public int? Memory { get; set; }
        /// <summary>
        /// Process Id of the sub process.
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public int? Pid { get; set; }
    }
}
