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
    public class NSXTALBPoolGroupMemberType 
    {
        public NSXTALBPoolGroupMemberType()
        {
        }
        /// <summary>
        /// Pool deployment state used with the PG deployment policy. Enum options - EVALUATION_IN_PROGRESS, IN_SERVICE,
        /// OUT_OF_SERVICE, EVALUATION_FAILED.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_state")]
        public string? DeploymentState { get; set; }
        /// <summary>
        /// UUID of the pool. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolRef { get; set; }
        /// <summary>
        /// All pools with same label are treated similarly in a pool group. A pool with a higher priority is selected, as long as
        /// the pool is eligible or an explicit policy chooses a different pool.
        /// </summary>
        [JsonProperty(PropertyName = "priority_label")]
        public string? PriorityLabel { get; set; }
        /// <summary>
        /// Ratio of selecting eligible pools in the pool group. . Allowed values are 1-1000. Special values are 0 - Do not select
        /// this pool for new connections. Allowed in Basic(Allowed values- 1) edition, Essentials(Allowed values- 1) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
    }
}
