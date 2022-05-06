using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBClusterHAConfigType
    {
        /// <summary>
        /// Transport node cluster. Avi derives vSphere HA property from vCenter cluster.If vSphere HA enabled on vCenter cluster,
        /// vSphere will handle HA of ServiceEngine VMs in case of underlying ESX failure.Ex MOB  domain-c23. Field introduced in
        /// 20.1.7, 21.1.3. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// If this flag set to True, Avi handles ServiceEngine failure irrespective of vSphere HA enabled on vCenter cluster or
        /// not. Field introduced in 20.1.7, 21.1.3. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "override_vsphere_ha")]
        public bool? OverrideVsphereHa { get; set; }
        /// <summary>
        /// Cluster VM Group name.VM Group name is unique inside cluster. Field introduced in 20.1.7, 21.1.3. Allowed in Basic
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "vmg_name")]
        public string? VmgName { get; set; }
    }
}
