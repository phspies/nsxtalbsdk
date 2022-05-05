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
    public class NSXTALBPoolDeploymentFailureInfoType 
    {
        /// <summary>
        /// Curent in-service pool. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "curr_in_service_pool_name")]
        public string? CurrInServicePoolName { get; set; }
        /// <summary>
        /// Curent in service pool. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "curr_in_service_pool_ref")]
        public string? CurrInServicePoolRef { get; set; }
        /// <summary>
        /// Operational traffic ratio for the pool.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
        /// <summary>
        /// Placeholder for description of property results of obj type PoolDeploymentFailureInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTALBPGDeploymentRuleResultType> Results { get; set; }
        /// <summary>
        /// Pool's ID.
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
