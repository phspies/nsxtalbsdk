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
    public class NSXTALBHTTPPolicySetType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for Pool. Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Geo database. It is a reference to an object of type GeoDB. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "geo_db_ref")]
        public string? GeoDbRef { get; set; }
        /// <summary>
        /// HTTP request policy for the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "http_request_policy")]
        public NSXTALBHTTPRequestPolicyType HttpRequestPolicy { get; set; }
        /// <summary>
        /// HTTP response policy for the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "http_response_policy")]
        public NSXTALBHTTPResponsePolicyType HttpResponsePolicy { get; set; }
        /// <summary>
        /// HTTP security policy for the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "http_security_policy")]
        public NSXTALBHTTPSecurityPolicyType HttpSecurityPolicy { get; set; }
        /// <summary>
        /// IP reputation database. It is a reference to an object of type IPReputationDB. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_db_ref")]
        public string? IpReputationDbRef { get; set; }
        /// <summary>
        /// Placeholder for description of property is_internal_policy of obj type HTTPPolicySet field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_internal_policy")]
        public bool? IsInternalPolicy { get; set; }
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
        /// Name of the HTTP Policy Set.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
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
        /// UUID of the HTTP Policy Set.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
