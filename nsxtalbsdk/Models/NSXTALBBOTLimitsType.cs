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
    public class NSXTALBBOTLimitsType 
    {
        public NSXTALBBOTLimitsType()
        {
        }
        /// <summary>
        /// Maximum number of rules to control which requests undergo BOT detection. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow_rules")]
        public int? AllowRules { get; set; }
        /// <summary>
        /// Maximum number of configurable HTTP header(s). Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hdrs")]
        public int? Hdrs { get; set; }
        /// <summary>
        /// Maximum number of rules in a BotMapping object. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mapping_rules")]
        public int? MappingRules { get; set; }
    }
}
