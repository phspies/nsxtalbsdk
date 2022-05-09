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
    public class NSXTALBUserType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Placeholder for description of property access of obj type User field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public IList<NSXTALBUserRoleType> Access { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "default_tenant_ref")]
        public string? DefaultTenantRef { get; set; }
        /// <summary>
        /// email of User.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
        /// <summary>
        /// full_name of User.
        /// </summary>
        [JsonProperty(PropertyName = "full_name")]
        public string? FullName { get; set; }
        /// <summary>
        /// Placeholder for description of property is_superuser of obj type User field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_superuser")]
        public bool? IsSuperuser { get; set; }
        /// <summary>
        /// Placeholder for description of property local of obj type User field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public bool? Local { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// password of User.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// It is a reference to an object of type UserAccountProfile.
        /// </summary>
        [JsonProperty(PropertyName = "user_profile_ref")]
        public string? UserProfileRef { get; set; }
        /// <summary>
        /// username of User.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
