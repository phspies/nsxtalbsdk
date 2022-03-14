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
    public class NSXTALBClusterType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property nodes of obj type Cluster field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<NSXTALBClusterNodeType> Nodes { get; set; }
        /// <summary>
        /// Re-join cluster nodes automatically in the event one of the node is reset to factory.
        /// </summary>
        [JsonProperty(PropertyName = "rejoin_nodes_automatically")]
        public bool? RejoinNodesAutomatically { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
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
        /// <summary>
        /// A virtual IP address. This IP address will be dynamically reconfigured so that it always is the IP of the cluster
        /// leader.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_ip")]
        public NSXTALBIpAddrType VirtualIp { get; set; }
    }
}
