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
    public class NSXTALBWafPositiveSecurityModelType 
    {
        /// <summary>
        /// These groups should be used to separate different levels of concern. The order of the groups matters, one group may mark
        /// parts of the request as valid, so that subsequent groups will not check these parts. It is a reference to an object of
        /// type WafPolicyPSMGroup. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "group_refs")]
        public IList<string> GroupRefs { get; set; }
    }
}
