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
    public class NSXTALBBackupConfigurationType 
    {
        public NSXTALBBackupConfigurationType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// AWS Access Key ID. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "aws_access_key")]
        public string? AwsAccessKey { get; set; }
        /// <summary>
        /// AWS bucket. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "aws_bucket_id")]
        public string? AwsBucketId { get; set; }
        /// <summary>
        /// AWS Secret Access Key. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "aws_secret_access")]
        public string? AwsSecretAccess { get; set; }
        /// <summary>
        /// Prefix of the exported configuration file. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "backup_file_prefix")]
        public string? BackupFilePrefix { get; set; }
        /// <summary>
        /// Default passphrase for configuration export and periodic backup.
        /// </summary>
        [JsonProperty(PropertyName = "backup_passphrase")]
        public string? BackupPassphrase { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Rotate the backup files based on this count. Allowed values are 1-20.
        /// </summary>
        [JsonProperty(PropertyName = "maximum_backups_stored")]
        public int? MaximumBackupsStored { get; set; }
        /// <summary>
        /// Name of backup configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Directory at remote destination with write permission for ssh user.
        /// </summary>
        [JsonProperty(PropertyName = "remote_directory")]
        public string? RemoteDirectory { get; set; }
        /// <summary>
        /// Remote Destination.
        /// </summary>
        [JsonProperty(PropertyName = "remote_hostname")]
        public string? RemoteHostname { get; set; }
        /// <summary>
        /// Local Backup.
        /// </summary>
        [JsonProperty(PropertyName = "save_local")]
        public bool? SaveLocal { get; set; }
        /// <summary>
        /// Access Credentials for remote destination. It is a reference to an object of type CloudConnectorUser.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_user_ref")]
        public string? SshUserRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Remote Backup.
        /// </summary>
        [JsonProperty(PropertyName = "upload_to_remote_host")]
        public bool? UploadToRemoteHost { get; set; }
        /// <summary>
        /// Cloud Backup. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "upload_to_s3")]
        public bool? UploadToS3 { get; set; }
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
