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
    public class NSXTALBMetricsDbDiskEventDetailsType 
    {
        public NSXTALBMetricsDbDiskEventDetailsType()
        {
        }
        /// <summary>
        /// metrics_deleted_tables of MetricsDbDiskEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_deleted_tables")]
        public IList<string> MetricsDeletedTables { get; set; }
        /// <summary>
        /// Number of metrics_free_sz.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_free_sz", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public long MetricsFreeSz { get; set; }
        /// <summary>
        /// Number of metrics_quota.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_quota", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public long MetricsQuota { get; set; }
    }
}
