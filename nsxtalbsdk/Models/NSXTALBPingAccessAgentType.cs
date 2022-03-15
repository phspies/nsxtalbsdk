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
    public class NSXTALBPingAccessAgentType 
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
        /// Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
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
        /// Name of the PingAccess Agent. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Pool containing a primary PingAccess Server, as well as any failover servers included in the agent.properties file. It
        /// is a reference to an object of type Pool. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "pingaccess_pool_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PingaccessPoolRef { get; set; }
        /// <summary>
        /// The ip and port of the primary PingAccess Server. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "primary_server", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBPoolServerType PrimaryServer { get; set; }
        /// <summary>
        /// PingAccessAgent's agent.properties file generated by PingAccess server. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "properties_file_data", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PropertiesFileData { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the PingAccess Agent. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}