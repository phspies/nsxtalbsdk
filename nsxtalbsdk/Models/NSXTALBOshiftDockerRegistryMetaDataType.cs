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
    public class NSXTALBOshiftDockerRegistryMetaDataType 
    {
        public NSXTALBOshiftDockerRegistryMetaDataType()
        {
        }
        /// <summary>
        /// Namespace for the ServiceEngine image to be hosted in Openshift Integrated registry.
        /// </summary>
        [JsonProperty(PropertyName = "registry_namespace")]
        public string? RegistryNamespace { get; set; }
        /// <summary>
        /// Name of the Integrated registry Service in Openshift.
        /// </summary>
        [JsonProperty(PropertyName = "registry_service")]
        public string? RegistryService { get; set; }
        /// <summary>
        /// Static VIP for 'docker-registry' service in Openshift if Avi is proxying for this service.This VIP should be outside the
        /// cluster IP subnet in Kubernetes and within the subnet configured (but outside the available pool of IPs) in the East
        /// West IPAM profile configuration for this Cloud. For example, if kubernetes cluster VIP range is 172.30.0.0/16 and subnet
        /// configured in East West IPAM profile is 172.50.0.0/16, then 172.50.0.2 can be used for this vip and IP pool can start
        /// from 172.50.0.3 onwards. Use this static VIP in '--insecure-registry <this-vip> 5000' docker config if using an insecure
        /// registry or add this to the list of IPs/hostnames when generating certificates if using a secure TLS registry.
        /// </summary>
        [JsonProperty(PropertyName = "registry_vip")]
        public NSXTALBIpAddrType RegistryVip { get; set; }
    }
}
