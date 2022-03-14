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
    public class NSXTALBRoleType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Allow access to unlabelled objects. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "allow_unlabelled_access")]
        public bool? AllowUnlabelledAccess { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Filters for granular object access control based on object labels. Multiple filters are merged using the AND operator.
        /// If empty, all objects according to the privileges will be accessible to the user. Field introduced in 20.1.3. Maximum of
        /// 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<NSXTALBRoleFilterType> Filters { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property privileges of obj type Role field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "privileges")]
        public IList<NSXTALBPermissionType> Privileges { get; set; }
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
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
