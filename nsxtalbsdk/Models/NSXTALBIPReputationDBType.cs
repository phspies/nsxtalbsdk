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
    public class NSXTALBIPReputationDBType 
    {
        public NSXTALBIPReputationDBType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// IP reputation DB base file. It is a reference to an object of type FileObject. Field introduced in 20.1.1. Maximum of 1
        /// items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "base_file_refs")]
        public IList<string> BaseFileRefs { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Description. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// IP reputation DB incremental update files. It is a reference to an object of type FileObject. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "incremental_file_refs")]
        public IList<string> IncrementalFileRefs { get; set; }
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
        /// IP reputation DB name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// If this object is managed by the IP reputation service, this field contain the status of this syncronization. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_status")]
        public NSXTALBIPReputationServiceStatusType ServiceStatus { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of this object. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Organization providing IP reputation data. Enum options - IP_REPUTATION_VENDOR_WEBROOT. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vendor { get; set; }
        /// <summary>
        /// A version number for this database object. This is informal for the consumer of this API only, a tool which manages this
        /// object can store version information here. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
