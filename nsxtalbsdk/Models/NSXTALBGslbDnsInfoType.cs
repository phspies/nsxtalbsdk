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
    public class NSXTALBGslbDnsInfoType 
    {
        public NSXTALBGslbDnsInfoType()
        {
        }
        /// <summary>
        /// This field indicates that atleast one DNS is active at the site.
        /// </summary>
        [JsonProperty(PropertyName = "dns_active")]
        public bool? DnsActive { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_vs_states of obj type GslbDnsInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dns_vs_states")]
        public IList<NSXTALBGslbPerDnsStateType> DnsVsStates { get; set; }
        /// <summary>
        /// This field encapsulates the Gs-status edge-triggered framework. . Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gs_status")]
        public NSXTALBGslbDnsGsStatusType GsStatus { get; set; }
        /// <summary>
        /// This field is used to track the retry attempts for SE download errors. . Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "retry_count")]
        public int? RetryCount { get; set; }
        /// <summary>
        /// This tables holds all the se-related info across all DNS-VS(es). . Field deprecated in 18.2.3. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_table")]
        public IList<NSXTALBGslbDnsSeInfoType> SeTable { get; set; }
    }
}
