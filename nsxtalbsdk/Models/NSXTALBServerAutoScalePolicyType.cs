using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServerAutoScalePolicyType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Delay in minutes after which a down server will be removed from Pool. Value 0 disables this functionality. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "delay_for_server_garbage_collection")]
        public int? DelayForServerGarbageCollection { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Use Avi intelligent autoscale algorithm where autoscale is performed by comparing load on the pool against estimated
        /// capacity of all the servers.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_autoscale")]
        public bool? IntelligentAutoscale { get; set; }
        /// <summary>
        /// Maximum extra capacity as percentage of load used by the intelligent scheme. Scale-in is triggered when available
        /// capacity is more than this margin. Allowed values are 1-99.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_scalein_margin")]
        public int? IntelligentScaleinMargin { get; set; }
        /// <summary>
        /// Minimum extra capacity as percentage of load used by the intelligent scheme. Scale-out is triggered when available
        /// capacity is less than this margin. Allowed values are 1-99.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_scaleout_margin")]
        public int? IntelligentScaleoutMargin { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.3. Maximum of 4 items allowed.
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
        /// Maximum number of servers to scale-in simultaneously. The actual number of servers to scale-in is chosen such that
        /// target number of servers is always more than or equal to the min_size.
        /// </summary>
        [JsonProperty(PropertyName = "max_scalein_adjustment_step")]
        public int? MaxScaleinAdjustmentStep { get; set; }
        /// <summary>
        /// Maximum number of servers to scale-out simultaneously. The actual number of servers to scale-out is chosen such that
        /// target number of servers is always less than or equal to the max_size.
        /// </summary>
        [JsonProperty(PropertyName = "max_scaleout_adjustment_step")]
        public int? MaxScaleoutAdjustmentStep { get; set; }
        /// <summary>
        /// Maximum number of servers after scale-out. Allowed values are 0-400.
        /// </summary>
        [JsonProperty(PropertyName = "max_size")]
        public int? MaxSize { get; set; }
        /// <summary>
        /// No scale-in happens once number of operationally up servers reach min_servers. Allowed values are 0-400.
        /// </summary>
        [JsonProperty(PropertyName = "min_size")]
        public int? MinSize { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Trigger scale-in when alerts due to any of these Alert configurations are raised. It is a reference to an object of type
        /// AlertConfig.
        /// </summary>
        [JsonProperty(PropertyName = "scalein_alertconfig_refs")]
        public IList<string> ScaleinAlertconfigRefs { get; set; }
        /// <summary>
        /// Cooldown period during which no new scale-in is triggered to allow previous scale-in to successfully complete. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "scalein_cooldown")]
        public int? ScaleinCooldown { get; set; }
        /// <summary>
        /// Trigger scale-out when alerts due to any of these Alert configurations are raised. It is a reference to an object of
        /// type AlertConfig.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_alertconfig_refs")]
        public IList<string> ScaleoutAlertconfigRefs { get; set; }
        /// <summary>
        /// Cooldown period during which no new scale-out is triggered to allow previous scale-out to successfully complete. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_cooldown")]
        public int? ScaleoutCooldown { get; set; }
        /// <summary>
        /// Scheduled-based scale-in/out policy. During scheduled intervals, metrics based autoscale is not enabled and number of
        /// servers will be solely derived from ScheduleScale policy. Field introduced in 21.1.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "scheduled_scalings")]
        public IList<NSXTALBScheduledScalingType> ScheduledScalings { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Use predicted load rather than current load.
        /// </summary>
        [JsonProperty(PropertyName = "use_predicted_load")]
        public bool? UsePredictedLoad { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
