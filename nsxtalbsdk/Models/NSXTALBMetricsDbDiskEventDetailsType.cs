using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMetricsDbDiskEventDetailsType
    {
        /// <summary>
        /// metrics_deleted_tables of MetricsDbDiskEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_deleted_tables")]
        public IList<string> MetricsDeletedTables { get; set; }
        /// <summary>
        /// Number of metrics_free_sz.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_free_sz")]
        [System.ComponentModel.DataAnnotations.Required]
        public long MetricsFreeSz { get; set; }
        /// <summary>
        /// Number of metrics_quota.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_quota")]
        [System.ComponentModel.DataAnnotations.Required]
        public long MetricsQuota { get; set; }
    }
}
