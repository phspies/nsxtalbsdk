using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVcenterHostsType
    {
        /// <summary>
        /// It is a reference to an object of type VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host_refs")]
        public IList<string> HostRefs { get; set; }
        /// <summary>
        /// Placeholder for description of property include of obj type VcenterHosts field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "include")]
        public bool? Include { get; set; }
    }
}
