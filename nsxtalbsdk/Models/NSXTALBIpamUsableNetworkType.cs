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
    public class NSXTALBIpamUsableNetworkType 
    {
        public NSXTALBIpamUsableNetworkType()
        {
        }
        /// <summary>
        /// Labels as key value pairs, used for selection of IPAM networks. Field introduced in 20.1.3. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueTupleType> Labels { get; set; }
        /// <summary>
        /// Network. It is a reference to an object of type Network. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "nw_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NwRef { get; set; }
    }
}
