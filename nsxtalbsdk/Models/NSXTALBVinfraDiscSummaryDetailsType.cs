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
    public class NSXTALBVinfraDiscSummaryDetailsType 
    {
        public NSXTALBVinfraDiscSummaryDetailsType()
        {
        }
        /// <summary>
        /// Number of num_clusters.
        /// </summary>
        [JsonProperty(PropertyName = "num_clusters")]
        public long? NumClusters { get; set; }
        /// <summary>
        /// Number of num_dcs.
        /// </summary>
        [JsonProperty(PropertyName = "num_dcs")]
        public long? NumDcs { get; set; }
        /// <summary>
        /// Number of num_hosts.
        /// </summary>
        [JsonProperty(PropertyName = "num_hosts")]
        public long? NumHosts { get; set; }
        /// <summary>
        /// Number of num_nws.
        /// </summary>
        [JsonProperty(PropertyName = "num_nws")]
        public long? NumNws { get; set; }
        /// <summary>
        /// Number of num_vms.
        /// </summary>
        [JsonProperty(PropertyName = "num_vms")]
        public long? NumVms { get; set; }
        /// <summary>
        /// vcenter of VinfraDiscSummaryDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
