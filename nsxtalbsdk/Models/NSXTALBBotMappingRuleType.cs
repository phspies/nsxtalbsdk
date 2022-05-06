using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBotMappingRuleType
    {
        /// <summary>
        /// How to match the BotClientClass. Field deprecated in 21.1.3. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "class_matcher")]
        public NSXTALBBotClassMatcherType ClassMatcher { get; set; }
        /// <summary>
        /// The assigned classification for this client. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "classification")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBBotClassificationType Classification { get; set; }
        /// <summary>
        /// The component for which this mapping is used. Enum options - BOT_DECIDER_CONSOLIDATION, BOT_DECIDER_USER_AGENT,
        /// BOT_DECIDER_IP_REPUTATION, BOT_DECIDER_IP_NETWORK_LOCATION. Field deprecated in 21.1.3. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "component_matcher")]
        public string? ComponentMatcher { get; set; }
        /// <summary>
        /// The list of bot identifier names and how they're matched. Field deprecated in 21.1.3. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "identifier_matcher")]
        public NSXTALBStringMatchType IdentifierMatcher { get; set; }
        /// <summary>
        /// Rules are processed in order of this index field. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// How to match the request  all the specified properties must be fulfilled. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBBotMappingRuleMatchTargetType Match { get; set; }
        /// <summary>
        /// A name describing the rule in a short form. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// How to match the BotClientType. Field deprecated in 21.1.3. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type_matcher")]
        public NSXTALBBotTypeMatcherType TypeMatcher { get; set; }
    }
}
