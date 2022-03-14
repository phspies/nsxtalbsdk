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
    public class NSXTALBDnsRuleActionPoolSwitchingType 
    {
        public NSXTALBDnsRuleActionPoolSwitchingType()
        {
        }
        /// <summary>
        /// Reference of the pool group to serve the passthrough DNS query which cannot be served locally. It is a reference to an
        /// object of type PoolGroup. Field introduced in 18.1.3, 17.2.12.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_ref")]
        public string? PoolGroupRef { get; set; }
        /// <summary>
        /// Reference of the pool to serve the passthrough DNS query which cannot be served locally. It is a reference to an object
        /// of type Pool. Field introduced in 18.1.3, 17.2.12.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
    }
}
