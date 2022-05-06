using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGCPEncryptionKeysType
    {
        /// <summary>
        /// CMEK Resource ID to encrypt Google Cloud Storage Bucket. This Bucket is used to upload Service Engine raw image. Field
        /// introduced in 18.2.10, 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "gcs_bucket_kms_key_id")]
        public string? GcsBucketKmsKeyId { get; set; }
        /// <summary>
        /// CMEK Resource ID to encrypt Service Engine raw image. The raw image is a Google Cloud Storage Object. Field introduced
        /// in 18.2.10, 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "gcs_objects_kms_key_id")]
        public string? GcsObjectsKmsKeyId { get; set; }
        /// <summary>
        /// CMEK Resource ID to encrypt Service Engine Disks. Field introduced in 18.2.10, 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_disk_kms_key_id")]
        public string? SeDiskKmsKeyId { get; set; }
        /// <summary>
        /// CMEK Resource ID to encrypt Service Engine GCE Image. Field introduced in 18.2.10, 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_image_kms_key_id")]
        public string? SeImageKmsKeyId { get; set; }
    }
}
