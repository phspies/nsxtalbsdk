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
    public class NSXTALBApplicationPersistenceProfileType 
    {
        public NSXTALBApplicationPersistenceProfileType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Specifies the Application Cookie Persistence profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "app_cookie_persistence_profile")]
        public NSXTALBAppCookiePersistenceProfileType AppCookiePersistenceProfile { get; set; }
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
        /// Specifies the custom HTTP Header Persistence profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_persistence_profile")]
        public NSXTALBHdrPersistenceProfileType HdrPersistenceProfile { get; set; }
        /// <summary>
        /// Specifies the HTTP Cookie Persistence profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "http_cookie_persistence_profile")]
        public NSXTALBHttpCookiePersistenceProfileType HttpCookiePersistenceProfile { get; set; }
        /// <summary>
        /// Specifies the Client IP Persistence profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "ip_persistence_profile")]
        public NSXTALBIPPersistenceProfileType IpPersistenceProfile { get; set; }
        /// <summary>
        /// This field describes the object's replication scope. If the field is set to false, then the object is visible within the
        /// controller-cluster and its associated service-engines.  If the field is set to true, then the object is replicated
        /// across the federation.  . Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
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
        /// A user-friendly name for the persistence profile.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Method used to persist clients to the same server for a duration of time or a session. Enum options -
        /// PERSISTENCE_TYPE_CLIENT_IP_ADDRESS, PERSISTENCE_TYPE_HTTP_COOKIE, PERSISTENCE_TYPE_TLS,
        /// PERSISTENCE_TYPE_CLIENT_IPV6_ADDRESS, PERSISTENCE_TYPE_CUSTOM_HTTP_HEADER, PERSISTENCE_TYPE_APP_COOKIE,
        /// PERSISTENCE_TYPE_GSLB_SITE. Allowed in Basic(Allowed values-
        /// PERSISTENCE_TYPE_CLIENT_IP_ADDRESS,PERSISTENCE_TYPE_HTTP_COOKIE) edition, Essentials(Allowed values-
        /// PERSISTENCE_TYPE_CLIENT_IP_ADDRESS,PERSISTENCE_TYPE_HTTP_COOKIE) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PersistenceType { get; set; }
        /// <summary>
        /// Specifies behavior when a persistent server has been marked down by a health monitor. Enum options -
        /// HM_DOWN_PICK_NEW_SERVER, HM_DOWN_ABORT_CONNECTION, HM_DOWN_CONTINUE_PERSISTENT_SERVER. Allowed in Basic(Allowed values-
        /// HM_DOWN_PICK_NEW_SERVER) edition, Essentials(Allowed values- HM_DOWN_PICK_NEW_SERVER) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "server_hm_down_recovery")]
        public string? ServerHmDownRecovery { get; set; }
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
        /// UUID of the persistence profile.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
