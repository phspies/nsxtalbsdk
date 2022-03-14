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
    public class NSXTALBIpamDnsGCPProfileType 
    {
        public NSXTALBIpamDnsGCPProfileType()
        {
        }
        /// <summary>
        /// Match SE group subnets for VIP placement. Default is to not match SE group subnets. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_se_group_subnet")]
        public bool? MatchSeGroupSubnet { get; set; }
        /// <summary>
        /// Google Cloud Platform Network Host Project ID. This is the host project in which Google Cloud Platform Network resides.
        /// Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "network_host_project_id")]
        public string? NetworkHostProjectId { get; set; }
        /// <summary>
        /// Google Cloud Platform Region Name. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "region_name")]
        public string? RegionName { get; set; }
        /// <summary>
        /// Google Cloud Platform Project ID. This is the project where service engines are hosted. This field is optional. By
        /// default it will use the value of the field network_host_project_id. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_project_id")]
        public string? SeProjectId { get; set; }
        /// <summary>
        /// Usable networks for Virtual IP. If VirtualService does not specify a network and auto_allocate_ip is set, then the first
        /// available network from this list will be chosen for IP allocation. It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "usable_network_refs")]
        public IList<string> UsableNetworkRefs { get; set; }
        /// <summary>
        /// Use Google Cloud Platform Network for Private VIP allocation. By default Avi Vantage Network is used for Private VIP
        /// allocation. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "use_gcp_network")]
        public bool? UseGcpNetwork { get; set; }
        /// <summary>
        /// Google Cloud Platform VPC Network Name. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_network_name")]
        public string? VpcNetworkName { get; set; }
    }
}
