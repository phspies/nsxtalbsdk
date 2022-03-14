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
    public class NSXTALBAutoScaleOpenStackSettingsType 
    {
        /// <summary>
        /// Avi Controller will use this URL to scale downthe pool. Cloud connector will automatically update the membership. This
        /// is an alpha feature. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "heat_scale_down_url")]
        public string? HeatScaleDownUrl { get; set; }
        /// <summary>
        /// Avi Controller will use this URL to scale upthe pool. Cloud connector will automatically update the membership. This is
        /// an alpha feature. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "heat_scale_up_url")]
        public string? HeatScaleUpUrl { get; set; }
    }
}
