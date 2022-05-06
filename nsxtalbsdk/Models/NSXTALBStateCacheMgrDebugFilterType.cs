using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBStateCacheMgrDebugFilterType
    {
        /// <summary>
        /// Pool UUID. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// VirtualService UUID. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_ref")]
        public string? VsRef { get; set; }
    }
}
