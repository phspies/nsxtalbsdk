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
    public class NSXTALBGslbPoolRuntimeType 
    {
        /// <summary>
        /// Placeholder for description of property members of obj type GslbPoolRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTALBGslbPoolMemberRuntimeInfoType> Members { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Gslb Pool's consolidated operational status . Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
    }
}
