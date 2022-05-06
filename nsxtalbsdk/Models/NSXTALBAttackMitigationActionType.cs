using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAttackMitigationActionType
    {
        /// <summary>
        /// Deny the attack packets further processing and drop them. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "deny")]
        public bool? Deny { get; set; }
    }
}
