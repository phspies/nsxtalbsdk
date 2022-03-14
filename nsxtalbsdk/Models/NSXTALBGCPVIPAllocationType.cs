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
    public class NSXTALBGCPVIPAllocationType 
    {
        /// <summary>
        /// Configure Google Cloud Internal LoadBalancer for VIP. The VIP will be auto allocated from a Google Cloud VPC Subnet.
        /// Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ilb")]
        public NSXTALBGCPVIPILBType Ilb { get; set; }
        /// <summary>
        /// VIP Allocation Mode. Enum options - ROUTES, ILB. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mode { get; set; }
        /// <summary>
        /// Configure Google Cloud VPC Routes for VIP. The VIP can either be a static IP or auto allocted from AVI Internal Network.
        /// The VIP should not overlap with any of the subnet ranges in Google Cloud VPC. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public NSXTALBGCPVIPRoutesType Routes { get; set; }
    }
}
