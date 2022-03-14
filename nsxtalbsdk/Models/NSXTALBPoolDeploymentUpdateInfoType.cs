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
    public class NSXTALBPoolDeploymentUpdateInfoType 
    {
        /// <summary>
        /// Pool deployment state used with the PG deployment policy. Enum options - EVALUATION_IN_PROGRESS, IN_SERVICE,
        /// OUT_OF_SERVICE, EVALUATION_FAILED.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_state")]
        public string? DeploymentState { get; set; }
        /// <summary>
        /// Evaluation period for deployment update. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "evaluation_duration")]
        public int? EvaluationDuration { get; set; }
        /// <summary>
        /// Operational traffic ratio for the pool.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
        /// <summary>
        /// List of results for each deployment rule.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTALBPGDeploymentRuleResultType> Results { get; set; }
        /// <summary>
        /// Member Pool's ID.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Reason returned in webhook callback when configured.
        /// </summary>
        [JsonProperty(PropertyName = "webhook_reason")]
        public string? WebhookReason { get; set; }
        /// <summary>
        /// Result of webhook callback when configured.
        /// </summary>
        [JsonProperty(PropertyName = "webhook_result")]
        public bool? WebhookResult { get; set; }
    }
}
