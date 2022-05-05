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
    public class NSXTALBBfdProfileType 
    {
        /// <summary>
        /// Default required minimum receive interval (in ms) used in BFD. Allowed values are 500-4000000. Field introduced in
        /// 20.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "minrx")]
        public int? Minrx { get; set; }
        /// <summary>
        /// Default desired minimum transmit interval (in ms) used in BFD. Allowed values are 500-4000000. Field introduced in
        /// 20.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "mintx")]
        public int? Mintx { get; set; }
        /// <summary>
        /// Default detection multiplier used in BFD. Allowed values are 3-255. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "multi")]
        public int? Multi { get; set; }
    }
}
