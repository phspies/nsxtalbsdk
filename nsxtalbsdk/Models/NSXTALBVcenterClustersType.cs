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
    public class NSXTALBVcenterClustersType 
    {
        public NSXTALBVcenterClustersType()
        {
        }
        /// <summary>
        /// It is a reference to an object of type VIMgrClusterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_refs")]
        public IList<string> ClusterRefs { get; set; }
        /// <summary>
        /// Placeholder for description of property include of obj type VcenterClusters field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "include")]
        public bool? Include { get; set; }
    }
}
