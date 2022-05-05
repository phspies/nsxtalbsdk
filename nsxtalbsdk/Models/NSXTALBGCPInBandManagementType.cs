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
    public class NSXTALBGCPInBandManagementType 
    {
        /// <summary>
        /// Service Engine Network Name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_network_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VpcNetworkName { get; set; }
        /// <summary>
        /// Project ID of the Service Engine Network. By default, Service Engine Project ID will be used. Field introduced in
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_project_id")]
        public string? VpcProjectId { get; set; }
        /// <summary>
        /// Service Engine Network Subnet Name. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_subnet_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VpcSubnetName { get; set; }
    }
}
