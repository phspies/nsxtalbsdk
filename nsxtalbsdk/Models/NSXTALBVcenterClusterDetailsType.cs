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
    public class NSXTALBVcenterClusterDetailsType 
    {
        /// <summary>
        /// Cloud Id. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Cluster name in vCenter. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Error message. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Hosts in vCenter Cluster. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// VC url. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vc_url")]
        public string? VcUrl { get; set; }
    }
}
