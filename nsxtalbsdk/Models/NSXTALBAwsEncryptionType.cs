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
    public class NSXTALBAwsEncryptionType 
    {
        /// <summary>
        /// AWS KMS ARN ID of the master key for encryption. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "master_key")]
        public string? MasterKey { get; set; }
        /// <summary>
        /// AWS encryption mode. Enum options - AWS_ENCRYPTION_MODE_NONE, AWS_ENCRYPTION_MODE_SSE_KMS. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
    }
}
