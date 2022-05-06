using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBLogManagerDebugFilterType
    {
        /// <summary>
        /// UUID of the entity. It is a reference to an object of type Virtualservice. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "entity_ref")]
        public string? EntityRef { get; set; }
    }
}
