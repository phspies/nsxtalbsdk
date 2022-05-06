using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAwsConfigurationType
    {
        /// <summary>
        /// AWS access key ID.
        /// </summary>
        [JsonProperty(PropertyName = "access_key_id")]
        public string? AccessKeyId { get; set; }
        /// <summary>
        /// Time interval between periodic polling of all Auto Scaling Groups. Allowed values are 60-1800. Field introduced in
        /// 17.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "asg_poll_interval")]
        public int? AsgPollInterval { get; set; }
        /// <summary>
        /// EBS encryption mode and the master key to be used for encrypting SE AMI, Volumes, and Snapshots. Field introduced in
        /// 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "ebs_encryption")]
        public NSXTALBAwsEncryptionType EbsEncryption { get; set; }
        /// <summary>
        /// Free unused elastic IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "free_elasticips")]
        public bool? FreeElasticips { get; set; }
        /// <summary>
        /// IAM assume role for cross-account access.
        /// </summary>
        [JsonProperty(PropertyName = "iam_assume_role")]
        public string? IamAssumeRole { get; set; }
        /// <summary>
        /// If enabled and the virtual service is not floating ip capable, vip will be published to both private and public zones.
        /// Field introduced in 17.2.10.
        /// </summary>
        [JsonProperty(PropertyName = "publish_vip_to_public_zone")]
        public bool? PublishVipToPublicZone { get; set; }
        /// <summary>
        /// AWS region.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string? Region { get; set; }
        /// <summary>
        /// If enabled, create/update DNS entries in Amazon Route 53 zones.
        /// </summary>
        [JsonProperty(PropertyName = "route53_integration")]
        public bool? Route53Integration { get; set; }
        /// <summary>
        /// S3 encryption mode and the master key to be used for encrypting S3 buckets during SE AMI upload. Only SSE-KMS mode is
        /// supported. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "s3_encryption")]
        public NSXTALBAwsEncryptionType S3Encryption { get; set; }
        /// <summary>
        /// AWS secret access key.
        /// </summary>
        [JsonProperty(PropertyName = "secret_access_key")]
        public string? SecretAccessKey { get; set; }
        /// <summary>
        /// Server Side Encryption to be used for encrypting SQS Queues. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "sqs_encryption")]
        public NSXTALBAwsEncryptionType SqsEncryption { get; set; }
        /// <summary>
        /// Default TTL for all records. Allowed values are 1-172800. Field introduced in 17.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public int? Ttl { get; set; }
        /// <summary>
        /// Use IAM roles instead of access and secret key.
        /// </summary>
        [JsonProperty(PropertyName = "use_iam_roles")]
        public bool? UseIamRoles { get; set; }
        /// <summary>
        /// Use SNS/SQS based notifications for monitoring Auto Scaling Groups. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "use_sns_sqs")]
        public bool? UseSnsSqs { get; set; }
        /// <summary>
        /// VPC name.
        /// </summary>
        [JsonProperty(PropertyName = "vpc")]
        public string? Vpc { get; set; }
        /// <summary>
        /// VPC ID.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VpcId { get; set; }
        /// <summary>
        /// If enabled, program SE security group with ingress rule to allow SSH (port 22) access from 0.0.0.0/0. Field deprecated
        /// in 17.1.5. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "wildcard_access")]
        public bool? WildcardAccess { get; set; }
        /// <summary>
        /// Placeholder for description of property zones of obj type AwsConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<NSXTALBAwsZoneConfigType> Zones { get; set; }
    }
}
