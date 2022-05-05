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
    public class NSXTALBVipAutoscaleGroupType 
    {
        /// <summary>
        /// Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public NSXTALBVipAutoscaleConfigurationType Configuration { get; set; }
        /// <summary>
        /// Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public NSXTALBVipAutoscalePolicyType Policy { get; set; }
    }
}
