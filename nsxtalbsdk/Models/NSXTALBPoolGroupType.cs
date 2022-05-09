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
    public class NSXTALBPoolGroupType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for PoolGroup. Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Name of the user who created the object.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Deactivate primary pool for selection when down until it is activated by user via clear poolgroup command. Field
        /// introduced in 20.1.7, 21.1.2, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "deactivate_primary_pool_on_down")]
        public bool? DeactivatePrimaryPoolOnDown { get; set; }
        /// <summary>
        /// When setup autoscale manager will automatically promote new pools into production when deployment goals are met. It is a
        /// reference to an object of type PoolGroupDeploymentPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_policy_ref")]
        public string? DeploymentPolicyRef { get; set; }
        /// <summary>
        /// Description of Pool Group.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable HTTP/2 for traffic from VirtualService to all the backend servers in all the pools configured under this
        /// PoolGroup. Field introduced in 20.1.1. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values-
        /// false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_http2")]
        public bool? EnableHttp2 { get; set; }
        /// <summary>
        /// Enable an action - Close Connection, HTTP Redirect, or Local HTTP Response - when a pool group failure happens. By
        /// default, a connection will be closed, in case the pool group experiences a failure.
        /// </summary>
        [JsonProperty(PropertyName = "fail_action")]
        public NSXTALBFailActionType FailAction { get; set; }
        /// <summary>
        /// Whether an implicit set of priority labels is generated. Field introduced in 17.1.9,17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "implicit_priority_labels")]
        public bool? ImplicitPriorityLabels { get; set; }
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
        /// List of pool group members object of type PoolGroupMember.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTALBPoolGroupMemberType> Members { get; set; }
        /// <summary>
        /// The minimum number of servers to distribute traffic to. Allowed values are 1-65535. Special values are 0 - Disable.
        /// Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "min_servers")]
        public int? MinServers { get; set; }
        /// <summary>
        /// The name of the pool group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// UUID of the priority labels. If not provided, pool group member priority label will be interpreted as a number with a
        /// larger number considered higher priority. It is a reference to an object of type PriorityLabels.
        /// </summary>
        [JsonProperty(PropertyName = "priority_labels_ref")]
        public string? PriorityLabelsRef { get; set; }
        /// <summary>
        /// Metadata pertaining to the service provided by this PoolGroup. In Openshift/Kubernetes environments, app metadata info
        /// is stored. Any user input to this field will be overwritten by Avi Vantage. Field introduced in 17.2.14,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_metadata")]
        public string? ServiceMetadata { get; set; }
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
        /// UUID of the pool group.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
