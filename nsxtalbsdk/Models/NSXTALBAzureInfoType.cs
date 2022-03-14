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
    public class NSXTALBAzureInfoType 
    {
        /// <summary>
        /// Name of the availability set of which the VM is a part of. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "availability_set")]
        public string? AvailabilitySet { get; set; }
        /// <summary>
        /// Fault domain within the availability set the VM is a part of. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "fault_domain")]
        public string? FaultDomain { get; set; }
        /// <summary>
        /// Name of the Azure VM. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Resource group name for the VM. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "resource_group")]
        public string? ResourceGroup { get; set; }
        /// <summary>
        /// Subnet ID of the primary nic of the VM. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_id")]
        public string? SubnetId { get; set; }
        /// <summary>
        /// Update domain within the availability set the VM is a part of. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "update_domain")]
        public string? UpdateDomain { get; set; }
        /// <summary>
        /// Azure VM uuid for the SE VM. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "vm_uuid")]
        public string? VmUuid { get; set; }
        /// <summary>
        /// VNIC id of the primary nic of the VM. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_id")]
        public string? VnicId { get; set; }
    }
}
