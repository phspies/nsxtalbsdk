using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPlacementScopeConfigType
    {
        /// <summary>
        /// Cluster vSphere HA configuration. Field introduced in 20.1.7, 21.1.3. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<NSXTALBClusterHAConfigType> Clusters { get; set; }
        /// <summary>
        /// List of transport node clusters include or exclude. Field introduced in 20.1.6. Allowed in Basic edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_clusters")]
        public NSXTALBNsxtClustersType NsxtClusters { get; set; }
        /// <summary>
        /// List of shared datastores to include or exclude. Field introduced in 20.1.2. Allowed in Basic edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_datastores")]
        public NSXTALBNsxtDatastoresType NsxtDatastores { get; set; }
        /// <summary>
        /// List of transport nodes include or exclude. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_hosts")]
        public NSXTALBNsxtHostsType NsxtHosts { get; set; }
        /// <summary>
        /// Folder to place all the Service Engine virtual machines in vCenter. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_folder")]
        public string? VcenterFolder { get; set; }
        /// <summary>
        /// VCenter server configuration. It is a reference to an object of type VCenterServer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcenterRef { get; set; }
    }
}
