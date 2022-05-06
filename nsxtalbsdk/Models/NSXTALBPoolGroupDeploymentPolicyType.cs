using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPoolGroupDeploymentPolicyType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// It will automatically disable old production pools once there is a new production candidate.
        /// </summary>
        [JsonProperty(PropertyName = "auto_disable_old_prod_pools")]
        public bool? AutoDisableOldProdPools { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Duration of evaluation period for automatic deployment. Allowed values are 60-86400. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "evaluation_duration")]
        public int? EvaluationDuration { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// The name of the pool group deployment policy.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property rules of obj type PoolGroupDeploymentPolicy field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBPGDeploymentRuleType> Rules { get; set; }
        /// <summary>
        /// deployment scheme. Enum options - BLUE_GREEN, CANARY.
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        public string? Scheme { get; set; }
        /// <summary>
        /// Target traffic ratio before pool is made production. Allowed values are 1-100. Unit is RATIO.
        /// </summary>
        [JsonProperty(PropertyName = "target_test_traffic_ratio")]
        public int? TargetTestTrafficRatio { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Ratio of the traffic that is sent to the pool under test. test ratio of 100 means blue green. Allowed values are 1-100.
        /// </summary>
        [JsonProperty(PropertyName = "test_traffic_ratio_rampup")]
        public int? TestTrafficRatioRampup { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the pool group deployment policy.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Webhook configured with URL that Avi controller will pass back information about pool group, old and new pool
        /// information and current deployment rule results. It is a reference to an object of type Webhook. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "webhook_ref")]
        public string? WebhookRef { get; set; }
    }
}
