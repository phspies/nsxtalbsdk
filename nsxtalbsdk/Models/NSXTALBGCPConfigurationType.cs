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
    public class NSXTALBGCPConfigurationType 
    {
        /// <summary>
        /// Credentials to access Google Cloud Platform APIs. It is a reference to an object of type CloudConnectorUser. Field
        /// introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_credentials_ref")]
        public string? CloudCredentialsRef { get; set; }
        /// <summary>
        /// Deprecated, please use encryption_keys field. Field deprecated in 18.2.10, 20.1.2. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_key_id")]
        public string? EncryptionKeyId { get; set; }
        /// <summary>
        /// Encryption Keys for Google Cloud Services. Field introduced in 18.2.10, 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_keys")]
        public NSXTALBGCPEncryptionKeysType EncryptionKeys { get; set; }
        /// <summary>
        /// Firewall rule network target tags which will be applied on Service Engines to allow ingress and egress traffic for
        /// Service Engines. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "firewall_target_tags")]
        public IList<string> FirewallTargetTags { get; set; }
        /// <summary>
        /// Email of GCP Service Account to be associated to the Service Engines. Field introduced in 20.1.7, 21.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "gcp_service_account_email")]
        public string? GcpServiceAccountEmail { get; set; }
        /// <summary>
        /// Google Cloud Storage Bucket Name where Service Engine image will be uploaded. This image will be deleted once the image
        /// is created in Google compute images. By default, a bucket will be created if this field is not specified. Field
        /// introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "gcs_bucket_name")]
        public string? GcsBucketName { get; set; }
        /// <summary>
        /// Google Cloud Storage Project ID where Service Engine image will be uploaded. This image will be deleted once the image
        /// is created in Google compute images. By default, Service Engine Project ID will be used. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "gcs_project_id")]
        public string? GcsProjectId { get; set; }
        /// <summary>
        /// Deprecated, please use match_se_group_subnet in routes mode in . vip_allocation_strategy. Field deprecated in 20.1.1.
        /// Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_se_group_subnet")]
        public bool? MatchSeGroupSubnet { get; set; }
        /// <summary>
        /// Google Cloud Platform VPC Network configuration for the Service Engines. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "network_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBGCPNetworkConfigType NetworkConfig { get; set; }
        /// <summary>
        /// Google Cloud Platform Region Name where Service Engines will be spawned. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "region_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string RegionName { get; set; }
        /// <summary>
        /// Google Cloud Platform Project ID where Service Engines will be spawned. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_project_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeProjectId { get; set; }
        /// <summary>
        /// VIP allocation strategy defines how the VIPs will be created in Google Cloud. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vip_allocation_strategy", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBGCPVIPAllocationType VipAllocationStrategy { get; set; }
        /// <summary>
        /// Google Cloud Platform Zones where Service Engines will be distributed for HA. Field introduced in 18.2.1. Minimum of 1
        /// items required.
        /// </summary>
        [JsonProperty(PropertyName = "zones", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Zones { get; set; }
    }
}
