using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBWafCRSType
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
        /// A short description of this ruleset. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Description { get; set; }
        /// <summary>
        /// WAF Rules are sorted in groups based on their characterization. Field introduced in 18.1.1. Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<NSXTALBWafRuleGroupType> Groups { get; set; }
        /// <summary>
        /// Integrity protection value. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "integrity")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Integrity { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.6. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// The name of this ruleset object. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// The release date of this version in RFC 3339 / ISO 8601 format. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "release_date")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ReleaseDate { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// The version of this ruleset object. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Version { get; set; }
    }
}
