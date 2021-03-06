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
    public class NSXTALBL4ConnectionPolicyType 
    {
        /// <summary>
        /// Rules to apply when a new transport connection is setup. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBL4RuleType> Rules { get; set; }
    }
}
