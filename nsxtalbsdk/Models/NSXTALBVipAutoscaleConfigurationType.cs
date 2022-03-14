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
    public class NSXTALBVipAutoscaleConfigurationType 
    {
        public NSXTALBVipAutoscaleConfigurationType()
        {
        }
        /// <summary>
        /// This is the list of AZ+Subnet in which Vips will be spawned. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<NSXTALBVipAutoscaleZonesType> Zones { get; set; }
    }
}
