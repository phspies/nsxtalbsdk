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
    public class NSXTALBOpenStackHypervisorPropertiesType 
    {
        public NSXTALBOpenStackHypervisorPropertiesType()
        {
        }
        /// <summary>
        /// Hypervisor type. Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Hypervisor { get; set; }
        /// <summary>
        /// Custom properties to be associated with the SE image in Glance for this hypervisor type. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "image_properties")]
        public IList<NSXTALBPropertyType> ImageProperties { get; set; }
    }
}
