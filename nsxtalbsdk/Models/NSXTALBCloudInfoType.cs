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
    public class NSXTALBCloudInfoType 
    {
        /// <summary>
        /// CloudConnectorAgent properties specific to this cloud type.
        /// </summary>
        [JsonProperty(PropertyName = "cca_props")]
        public NSXTALBCC_AgentPropertiesType CcaProps { get; set; }
        /// <summary>
        /// Controller properties specific to this cloud type.
        /// </summary>
        [JsonProperty(PropertyName = "controller_props")]
        public NSXTALBControllerPropertiesType ControllerProps { get; set; }
        /// <summary>
        /// Flavor properties specific to this cloud type.
        /// </summary>
        [JsonProperty(PropertyName = "flavor_props")]
        public IList<NSXTALBCloudFlavorType> FlavorProps { get; set; }
        /// <summary>
        /// flavor_regex_filter of CloudInfo.
        /// </summary>
        [JsonProperty(PropertyName = "flavor_regex_filter")]
        public string? FlavorRegexFilter { get; set; }
        /// <summary>
        /// Supported hypervisors. Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN.
        /// </summary>
        [JsonProperty(PropertyName = "htypes")]
        public IList<string> Htypes { get; set; }
        /// <summary>
        /// Cloud type. Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "vtype")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vtype { get; set; }
    }
}
