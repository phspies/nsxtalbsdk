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
    public class NSXTALBNetworkSubnetClashType 
    {
        public NSXTALBNetworkSubnetClashType()
        {
        }
        /// <summary>
        /// ip_nw of NetworkSubnetClash.
        /// </summary>
        [JsonProperty(PropertyName = "ip_nw", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string IpNw { get; set; }
        /// <summary>
        /// networks of NetworkSubnetClash.
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
    }
}
