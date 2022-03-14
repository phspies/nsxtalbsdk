using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBotEvaluationResultType 
    {
        public NSXTALBBotEvaluationResultType()
        {
        }
        /// <summary>
        /// The component of the bot module that made this evaluation. Enum options - BOT_DECIDER_CONSOLIDATION,
        /// BOT_DECIDER_USER_AGENT, BOT_DECIDER_IP_REPUTATION, BOT_DECIDER_IP_NETWORK_LOCATION. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string? Component { get; set; }
        /// <summary>
        /// The confidence of this evaluation. Enum options - LOW_CONFIDENCE, MEDIUM_CONFIDENCE, HIGH_CONFIDENCE. Field introduced
        /// in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public string? Confidence { get; set; }
        /// <summary>
        /// The resulting Bot Identification. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "identification")]
        public NSXTALBBotIdentificationType Identification { get; set; }
        /// <summary>
        /// Additional notes for this result. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public IList<string> Notes { get; set; }
    }
}
