using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBotClassificationType
    {
        /// <summary>
        /// One of the system-defined Bot classification types. Enum options - HUMAN, GOOD_BOT, BAD_BOT, DANGEROUS_BOT,
        /// USER_DEFINED_BOT, UNKNOWN_CLIENT. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// If 'type' has BotClassificationTypes value 'USER_DEFINED', this is the user-defined value. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "user_defined_type")]
        public string? UserDefinedType { get; set; }
    }
}
