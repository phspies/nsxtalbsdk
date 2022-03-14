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
    public class NSXTALBHSMAwsCloudHsmType 
    {
        /// <summary>
        /// Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "client_config")]
        public string? ClientConfig { get; set; }
        /// <summary>
        /// AWS CloudHSM Cluster Certificate. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_cert")]
        public string? ClusterCert { get; set; }
        /// <summary>
        /// Username of the Crypto User. This will be used to access the keys on the HSM . Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "crypto_user_name")]
        public string? CryptoUserName { get; set; }
        /// <summary>
        /// Password of the Crypto User. This will be used to access the keys on the HSM . Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "crypto_user_password")]
        public string? CryptoUserPassword { get; set; }
        /// <summary>
        /// IP address of the HSM in the cluster. If there are more than one HSMs, only one is sufficient. Field introduced in
        /// 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "hsm_ip")]
        public IList<string> HsmIp { get; set; }
        /// <summary>
        /// Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_config")]
        public string? MgmtConfig { get; set; }
    }
}
