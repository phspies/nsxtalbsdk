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
    public class NSXTALBBotClassMatcherType 
    {
        public NSXTALBBotClassMatcherType()
        {
        }
        /// <summary>
        /// The list of client classes. Enum options - UNDETERMINED_CLIENT, HUMAN_CLIENT, BOT_CLIENT. Field introduced in 21.1.1.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "client_classes")]
        public IList<string> ClientClasses { get; set; }
        /// <summary>
        /// The match operation. Enum options - IS_IN, IS_NOT_IN. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "op")]
        public string? Op { get; set; }
    }
}
