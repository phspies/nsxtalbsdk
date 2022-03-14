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
    public class NSXTALBLinuxServerHostType 
    {
        public NSXTALBLinuxServerHostType()
        {
        }
        /// <summary>
        /// Placeholder for description of property host_attr of obj type LinuxServerHost field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "host_attr")]
        public IList<NSXTALBHostAttributesType> HostAttr { get; set; }
        /// <summary>
        /// Placeholder for description of property host_ip of obj type LinuxServerHost field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "host_ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType HostIp { get; set; }
        /// <summary>
        /// Node's availability zone. ServiceEngines belonging to the availability zone will be rebooted during a manual DR
        /// failover.
        /// </summary>
        [JsonProperty(PropertyName = "node_availability_zone")]
        public string? NodeAvailabilityZone { get; set; }
        /// <summary>
        /// The SE Group association for the SE. If None, then 'Default-Group' SEGroup is associated with the SE. It is a reference
        /// to an object of type ServiceEngineGroup. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        public string? SeGroupRef { get; set; }
    }
}
