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
    public class NSXTALBvCenterConfigurationType 
    {
        /// <summary>
        /// Datacenter for virtual infrastructure discovery.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter")]
        public string? Datacenter { get; set; }
        /// <summary>
        /// If true, VM's on the vCenter will not be discovered.Set it to true if there are more than 10000 VMs in the datacenter.
        /// Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "deactivate_vm_discovery")]
        public bool? DeactivateVmDiscovery { get; set; }
        /// <summary>
        /// Management subnet to use for Avi Service Engines.
        /// </summary>
        [JsonProperty(PropertyName = "management_ip_subnet")]
        public NSXTALBIpAddrPrefixType ManagementIpSubnet { get; set; }
        /// <summary>
        /// Management network to use for Avi Service Engines. It is a reference to an object of type VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "management_network")]
        public string? ManagementNetwork { get; set; }
        /// <summary>
        /// The password Avi Vantage will use when authenticating with vCenter.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Set the access mode to vCenter as either Read, which allows Avi to discover networks and servers, or Write, which also
        /// allows Avi to create Service Engines and configure their network properties. Enum options - NO_ACCESS, READ_ACCESS,
        /// WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Privilege { get; set; }
        /// <summary>
        /// The username Avi Vantage will use when authenticating with vCenter.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Avi Service Engine Template in vCenter to be used for creating Service Engines.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_template_se_location")]
        public string? VcenterTemplateSeLocation { get; set; }
        /// <summary>
        /// vCenter hostname or IP address.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url")]
        public string? VcenterUrl { get; set; }
    }
}
