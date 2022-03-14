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
    public class NSXTALBBgpRoutingOptionsType 
    {
        public NSXTALBBgpRoutingOptionsType()
        {
        }
        /// <summary>
        /// Advertise self as default router to the BGP peer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_default_route")]
        public bool? AdvertiseDefaultRoute { get; set; }
        /// <summary>
        /// Advertise the learned routes to the BGP peer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_learned_routes")]
        public bool? AdvertiseLearnedRoutes { get; set; }
        /// <summary>
        /// Features are applied to peers matching this label. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Label { get; set; }
        /// <summary>
        /// Learn only default route from the BGP peer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "learn_only_default_route")]
        public bool? LearnOnlyDefaultRoute { get; set; }
        /// <summary>
        /// Learn routes from the BGP peer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "learn_routes")]
        public bool? LearnRoutes { get; set; }
        /// <summary>
        /// Maximum number of routes that can be learned from a BGP peer. Allowed values are 50-250. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_learn_limit")]
        public int? MaxLearnLimit { get; set; }
    }
}
