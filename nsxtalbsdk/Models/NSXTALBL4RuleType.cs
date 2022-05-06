using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBL4RuleType
    {
        /// <summary>
        /// Action to be performed upon successful rule match. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public NSXTALBL4RuleActionType Action { get; set; }
        /// <summary>
        /// Enable or disable the rule. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Index of the rule. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Match criteria of the rule. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBL4RuleMatchTargetType Match { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
