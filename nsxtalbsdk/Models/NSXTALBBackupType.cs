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
    public class NSXTALBBackupType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// BackupConfiguration Information. It is a reference to an object of type BackupConfiguration.
        /// </summary>
        [JsonProperty(PropertyName = "backup_config_ref")]
        public string? BackupConfigRef { get; set; }
        /// <summary>
        /// The file name of backup.
        /// </summary>
        [JsonProperty(PropertyName = "file_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FileName { get; set; }
        /// <summary>
        /// URL to download the backup file.
        /// </summary>
        [JsonProperty(PropertyName = "local_file_url")]
        public string? LocalFileUrl { get; set; }
        /// <summary>
        /// URL to download the backup file.
        /// </summary>
        [JsonProperty(PropertyName = "remote_file_url")]
        public string? RemoteFileUrl { get; set; }
        /// <summary>
        /// Scheduler Information. It is a reference to an object of type Scheduler.
        /// </summary>
        [JsonProperty(PropertyName = "scheduler_ref")]
        public string? SchedulerRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Unix Timestamp of when the backup file is created.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string? Timestamp { get; set; }
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
    }
}
