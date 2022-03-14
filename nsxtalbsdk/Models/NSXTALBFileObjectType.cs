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
    public class NSXTALBFileObjectType 
    {
        public NSXTALBFileObjectType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// SHA1 checksum of the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        public string? Checksum { get; set; }
        /// <summary>
        /// This field indicates whether the file is gzip-compressed. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "compressed")]
        public bool? Compressed { get; set; }
        /// <summary>
        /// Timestamp of creation for the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string? Created { get; set; }
        /// <summary>
        /// Description of the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Timestamp when the file will be no longer needed and can be removed by the system. If this is set, a garbage collector
        /// process will try to remove the file after this time. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "expires_at")]
        public string? ExpiresAt { get; set; }
        /// <summary>
        /// This field describes the object's replication scope. If the field is set to false, then the object is visible within the
        /// controller-cluster and its associated service-engines. If the field is set to true, then the object is replicated across
        /// the federation. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Name of the file object. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Path to the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// Enforce Read-Only on the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "read_only")]
        public bool? ReadOnly { get; set; }
        /// <summary>
        /// Flag to allow/restrict download of the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "restrict_download")]
        public bool? RestrictDownload { get; set; }
        /// <summary>
        /// Size of the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Type of the file. Enum options - OTHER_FILE_TYPES, IP_REPUTATION, GEO_DB, TECH_SUPPORT, HSMPACKAGES, IPAMDNSSCRIPTS,
        /// CONTROLLER_IMAGE. Field introduced in 20.1.1. Allowed in Basic(Allowed values- OTHER_FILE_TYPES) edition,
        /// Essentials(Allowed values- OTHER_FILE_TYPES) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Version of the file. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
