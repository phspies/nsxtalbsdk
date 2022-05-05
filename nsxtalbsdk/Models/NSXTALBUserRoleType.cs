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
    public class NSXTALBUserRoleType 
    {
        /// <summary>
        /// Placeholder for description of property all_tenants of obj type UserRole field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "all_tenants")]
        public bool? AllTenants { get; set; }
        /// <summary>
        /// Reference to the Object Access Policy that defines a User's access in the corresponding Tenant. It is a reference to an
        /// object of type ObjectAccessPolicy. Field deprecated in 20.1.2. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "object_access_policy_ref")]
        public string? ObjectAccessPolicyRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Role.
        /// </summary>
        [JsonProperty(PropertyName = "role_ref")]
        public string? RoleRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
    }
}
