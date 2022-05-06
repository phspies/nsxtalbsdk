using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAbPoolType
    {
        /// <summary>
        /// Pool configured as B pool for A/B testing. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolRef { get; set; }
        /// <summary>
        /// Ratio of traffic diverted to the B pool, for A/B testing. Allowed values are 0-100.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
    }
}
