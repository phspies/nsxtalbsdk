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
    public class NSXTALBCloudPropertiesType 
    {
        public NSXTALBCloudPropertiesType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// CloudConnector properties.
        /// </summary>
        [JsonProperty(PropertyName = "cc_props")]
        public NSXTALBCC_PropertiesType CcProps { get; set; }
        /// <summary>
        /// Cloud types supported by CloudConnector. Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS,
        /// CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS, CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE,
        /// CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "cc_vtypes")]
        public IList<string> CcVtypes { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Hypervisor properties.
        /// </summary>
        [JsonProperty(PropertyName = "hyp_props")]
        public IList<NSXTALBHypervisor_PropertiesType> HypProps { get; set; }
        /// <summary>
        /// Properties specific to a cloud type.
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public IList<NSXTALBCloudInfoType> Info { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
