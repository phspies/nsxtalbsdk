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
    public class NSXTALBControllerFaultsType 
    {
        public NSXTALBControllerFaultsType()
        {
        }
        /// <summary>
        /// Enable backup scheduler faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "backup_scheduler_faults")]
        public bool? BackupSchedulerFaults { get; set; }
        /// <summary>
        /// Enable cluster faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_faults")]
        public bool? ClusterFaults { get; set; }
        /// <summary>
        /// Enable deprecated api version faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "deprecated_api_version_faults")]
        public bool? DeprecatedApiVersionFaults { get; set; }
        /// <summary>
        /// Enable license faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "license_faults")]
        public bool? LicenseFaults { get; set; }
        /// <summary>
        /// Enable DB migration faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "migration_faults")]
        public bool? MigrationFaults { get; set; }
        /// <summary>
        /// Enable SSL Profile faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "sslprofile_faults")]
        public bool? SslprofileFaults { get; set; }
    }
}
