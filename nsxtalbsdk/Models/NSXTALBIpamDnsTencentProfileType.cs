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
    public class NSXTALBIpamDnsTencentProfileType 
    {
        /// <summary>
        /// Credentials to access Tencent cloud. It is a reference to an object of type CloudConnectorUser. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_credentials_ref")]
        public string? CloudCredentialsRef { get; set; }
        /// <summary>
        /// VPC region. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Region { get; set; }
        /// <summary>
        /// Usable networks for Virtual IP. If VirtualService does not specify a network and auto_allocate_ip is set, then the first
        /// available network from this list will be chosen for IP allocation. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "usable_subnet_ids")]
        public IList<string> UsableSubnetIds { get; set; }
        /// <summary>
        /// VPC ID. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VpcId { get; set; }
        /// <summary>
        /// Network configuration for Virtual IP per AZ. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<NSXTALBTencentZoneNetworkType> Zones { get; set; }
    }
}
