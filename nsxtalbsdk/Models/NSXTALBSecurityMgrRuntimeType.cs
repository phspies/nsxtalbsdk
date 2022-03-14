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
    public class NSXTALBSecurityMgrRuntimeType 
    {
        public NSXTALBSecurityMgrRuntimeType()
        {
        }
        /// <summary>
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "thresholds")]
        public IList<NSXTALBSecMgrThresholdType> Thresholds { get; set; }
    }
}
