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
    public class NSXTALBNsxtClustersType 
    {
        /// <summary>
        /// List of transport node clusters. Field introduced in 20.1.6. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_ids")]
        public IList<string> ClusterIds { get; set; }
        /// <summary>
        /// Include or Exclude. Field introduced in 20.1.6. Allowed in Basic edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "include")]
        public bool? Include { get; set; }
    }
}
