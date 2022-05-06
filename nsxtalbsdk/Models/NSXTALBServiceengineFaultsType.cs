using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServiceengineFaultsType
    {
        /// <summary>
        /// Enable debug faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "debug_faults")]
        public bool? DebugFaults { get; set; }
    }
}
