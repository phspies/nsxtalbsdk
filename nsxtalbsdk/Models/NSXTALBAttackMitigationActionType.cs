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
    public class NSXTALBAttackMitigationActionType 
    {
        public NSXTALBAttackMitigationActionType()
        {
        }
        /// <summary>
        /// Deny the attack packets further processing and drop them. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "deny")]
        public bool? Deny { get; set; }
    }
}
