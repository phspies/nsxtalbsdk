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
    public class NSXTALBGCPTwoArmModeType 
    {
        /// <summary>
        /// Service Engine Backend Data Network Name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "backend_data_vpc_network_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string BackendDataVpcNetworkName { get; set; }
        /// <summary>
        /// Project ID of the Service Engine Backend Data Network. By default, Service Engine Project ID will be used. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "backend_data_vpc_project_id")]
        public string? BackendDataVpcProjectId { get; set; }
        /// <summary>
        /// Service Engine Backend Data Network Subnet Name. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "backend_data_vpc_subnet_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string BackendDataVpcSubnetName { get; set; }
        /// <summary>
        /// Service Engine Frontend Data Network Name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "frontend_data_vpc_network_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FrontendDataVpcNetworkName { get; set; }
        /// <summary>
        /// Project ID of the Service Engine Frontend Data Network. By default, Service Engine Project ID will be used. Field
        /// introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "frontend_data_vpc_project_id")]
        public string? FrontendDataVpcProjectId { get; set; }
        /// <summary>
        /// Service Engine Frontend Data Network Subnet Name. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "frontend_data_vpc_subnet_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FrontendDataVpcSubnetName { get; set; }
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
