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
    public class NSXTALBSubJobType 
    {
        /// <summary>
        /// Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "expires_at")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ExpiresAt { get; set; }
        /// <summary>
        /// Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string? Metadata { get; set; }
        /// <summary>
        /// Number of times the sub job got scheduled. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_retries")]
        public int? NumRetries { get; set; }
        /// <summary>
        /// Enum options - JOB_TYPE_VS_FULL_LOGS, JOB_TYPE_VS_UDF, JOB_TYPE_VS_METRICS_RT, JOB_TYPE_SSL_CERT,
        /// JOB_TYPE_DEBUGVS_PKT_CAPTURE, JOB_TYPE_CONSISTENCY_CHECK, JOB_TYPE_TECHSUPPORT, JOB_TYPE_PKI_PROFILE, JOB_TYPE_NSP_RULE,
        /// JOB_TYPE_SEGROUP_METRICS_RT, JOB_TYPE_POSTGRES_STATUS, JOB_TYPE_VS_ROTATE_KEYS, JOB_TYPE_POOL_DNS,
        /// JOB_TYPE_GSLB_SERVICE, JOB_TYPE_APP_PERSISTENCE, JOB_TYPE_PROCESS_LOCKED_USER_ACCOUNTS, JOB_TYPE_SESSION,
        /// JOB_TYPE_AUTHTOKEN, JOB_TYPE_CLUSTER, JOB_TYPE_SE_SECURE_CHANNEL_CLEANUP, JOB_TYPE_OCSP_STAPLE_STATUS,
        /// JOB_TYPE_FILE_OBJECT_CLEANUP, JOB_TYPE_WAF_POLICY_REFRESH_APPLICATION_SIGNATURES, JOB_TYPE_POOL_ASYNC,
        /// JOB_TYPE_PROCESS_BASELINE_BENCHMARK, JOB_TYPE_GEODB_REFRESH_CONTROLLER_DATABASES, JOB_TYPE_POSTGRES_VACUUM. Field
        /// introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
