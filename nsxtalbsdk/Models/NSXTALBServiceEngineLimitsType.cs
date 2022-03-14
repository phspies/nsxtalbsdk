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
    public class NSXTALBServiceEngineLimitsType 
    {
        public NSXTALBServiceEngineLimitsType()
        {
        }
        /// <summary>
        /// Maximum number of virtualservices per serviceengine, including east-west virtualservices. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "all_virtualservices_per_serviceengine")]
        public int? AllVirtualservicesPerServiceengine { get; set; }
        /// <summary>
        /// Maximum number of east-west virtualservices per serviceengine, excluding north-south virtualservices. Field introduced
        /// in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ew_virtualservices_per_serviceengine")]
        public int? EwVirtualservicesPerServiceengine { get; set; }
        /// <summary>
        /// Maximum number of north-south virtualservices per serviceengine, excluding east-west virtualservices. Field introduced
        /// in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ns_virtualservices_per_serviceengine")]
        public int? NsVirtualservicesPerServiceengine { get; set; }
        /// <summary>
        /// Maximum number of logical interfaces (vlan, bond) per serviceengine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_intf_per_se")]
        public int? NumLogicalIntfPerSe { get; set; }
        /// <summary>
        /// Maximum number of physical interfaces per serviceengine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_phy_intf_per_se")]
        public int? NumPhyIntfPerSe { get; set; }
        /// <summary>
        /// Maximum number of virtualservices with realtime metrics enabled. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_virtualservices_rt_metrics")]
        public int? NumVirtualservicesRtMetrics { get; set; }
        /// <summary>
        /// Maximum number of vlan interfaces per physical interface. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_vlan_intf_per_phy_intf")]
        public int? NumVlanIntfPerPhyIntf { get; set; }
        /// <summary>
        /// Maximum number of vlan interfaces per serviceengine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_vlan_intf_per_se")]
        public int? NumVlanIntfPerSe { get; set; }
        /// <summary>
        /// Serviceengine system limits specific to cloud type. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_cloud_limits")]
        public IList<NSXTALBServiceEngineCloudLimitsType> ServiceengineCloudLimits { get; set; }
    }
}
