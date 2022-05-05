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
    public class NSXTALBGCPSeGroupConfigType 
    {
        /// <summary>
        /// Service Engine Backend Data Network Name, used only for GCP cloud.Overrides the cloud level setting for Backend Data
        /// Network in GCP Two Arm Mode. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "backend_data_vpc_network_name")]
        public string? BackendDataVpcNetworkName { get; set; }
        /// <summary>
        /// Project ID of the Service Engine Backend Data Network. By default, Service Engine Project ID will be used. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "backend_data_vpc_project_id")]
        public string? BackendDataVpcProjectId { get; set; }
        /// <summary>
        /// Service Engine Backend Data Subnet Name, used only for GCP cloud.Overrides the cloud level setting for Backend Data
        /// Subnet in GCP Two Arm Mode. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "backend_data_vpc_subnet_name")]
        public string? BackendDataVpcSubnetName { get; set; }
    }
}
