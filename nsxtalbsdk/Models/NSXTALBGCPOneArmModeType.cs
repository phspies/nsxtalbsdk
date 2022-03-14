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
    public class NSXTALBGCPOneArmModeType 
    {
        /// <summary>
        /// Service Engine Data Network Name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "data_vpc_network_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string DataVpcNetworkName { get; set; }
        /// <summary>
        /// Project ID of the Service Engine Data Network. By default, Service Engine Project ID will be used. Field introduced in
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "data_vpc_project_id")]
        public string? DataVpcProjectId { get; set; }
        /// <summary>
        /// Service Engine Data Network Subnet Name. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "data_vpc_subnet_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string DataVpcSubnetName { get; set; }
        /// <summary>
        /// Service Engine Management Network Name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "management_vpc_network_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagementVpcNetworkName { get; set; }
        /// <summary>
        /// Project ID of the Service Engine Management Network. By default, Service Engine Project ID will be used. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "management_vpc_project_id")]
        public string? ManagementVpcProjectId { get; set; }
        /// <summary>
        /// Service Engine Management Network Subnet Name. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "management_vpc_subnet_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagementVpcSubnetName { get; set; }
    }
}
