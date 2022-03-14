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
    public class NSXTALBVSDataScriptSetType 
    {
        public NSXTALBVSDataScriptSetType()
        {
        }
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
        /// Creator name. Field introduced in 17.1.11,17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// DataScripts to execute.
        /// </summary>
        [JsonProperty(PropertyName = "datascript")]
        public IList<NSXTALBVSDataScriptType> Datascript { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Geo Location Mapping Database used by this DataScriptSet. It is a reference to an object of type GeoDB. Field introduced
        /// in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "geo_db_ref")]
        public string? GeoDbRef { get; set; }
        /// <summary>
        /// IP reputation database that can be used by DataScript functions. It is a reference to an object of type IPReputationDB.
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_db_ref")]
        public string? IpReputationDbRef { get; set; }
        /// <summary>
        /// UUID of IP Groups that could be referred by VSDataScriptSet objects. It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "ipgroup_refs")]
        public IList<string> IpgroupRefs { get; set; }
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
        /// Name for the virtual service datascript collection.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// UUIDs of PKIProfile objects that could be referred by VSDataScriptSet objects. It is a reference to an object of type
        /// PKIProfile. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_refs")]
        public IList<string> PkiProfileRefs { get; set; }
        /// <summary>
        /// UUID of pool groups that could be referred by VSDataScriptSet objects. It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_refs")]
        public IList<string> PoolGroupRefs { get; set; }
        /// <summary>
        /// UUID of pools that could be referred by VSDataScriptSet objects. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_refs")]
        public IList<string> PoolRefs { get; set; }
        /// <summary>
        /// List of protocol parsers that could be referred by VSDataScriptSet objects. It is a reference to an object of type
        /// ProtocolParser. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "protocol_parser_refs")]
        public IList<string> ProtocolParserRefs { get; set; }
        /// <summary>
        /// The Rate Limit definitions needed for this DataScript. The name is composed of the Virtual Service name and the
        /// DataScript name. Field introduced in 18.2.9. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiters")]
        public IList<NSXTALBRateLimiterType> RateLimiters { get; set; }
        /// <summary>
        /// UUIDs of SSLKeyAndCertificate objects that could be referred by VSDataScriptSet objects. It is a reference to an object
        /// of type SSLKeyAndCertificate. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_certificate_refs")]
        public IList<string> SslKeyCertificateRefs { get; set; }
        /// <summary>
        /// UUIDs of SSLProfile objects that could be referred by VSDataScriptSet objects. It is a reference to an object of type
        /// SSLProfile. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_refs")]
        public IList<string> SslProfileRefs { get; set; }
        /// <summary>
        /// UUID of String Groups that could be referred by VSDataScriptSet objects. It is a reference to an object of type
        /// StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "string_group_refs")]
        public IList<string> StringGroupRefs { get; set; }
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
        /// UUID of the virtual service datascript collection.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
