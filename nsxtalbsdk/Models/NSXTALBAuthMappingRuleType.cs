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
    public class NSXTALBAuthMappingRuleType 
    {
        /// <summary>
        /// Assignment rule for the Object Access Policy. Enum options - ASSIGN_ALL, ASSIGN_FROM_SELECT_LIST,
        /// ASSIGN_MATCHING_GROUP_NAME, ASSIGN_MATCHING_ATTRIBUTE_VALUE, ASSIGN_MATCHING_GROUP_REGEX,
        /// ASSIGN_MATCHING_ATTRIBUTE_REGEX. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "assign_policy")]
        public string? AssignPolicy { get; set; }
        /// <summary>
        /// Enum options - ASSIGN_ALL, ASSIGN_FROM_SELECT_LIST, ASSIGN_MATCHING_GROUP_NAME, ASSIGN_MATCHING_ATTRIBUTE_VALUE,
        /// ASSIGN_MATCHING_GROUP_REGEX, ASSIGN_MATCHING_ATTRIBUTE_REGEX.
        /// </summary>
        [JsonProperty(PropertyName = "assign_role")]
        public string? AssignRole { get; set; }
        /// <summary>
        /// Enum options - ASSIGN_ALL, ASSIGN_FROM_SELECT_LIST, ASSIGN_MATCHING_GROUP_NAME, ASSIGN_MATCHING_ATTRIBUTE_VALUE,
        /// ASSIGN_MATCHING_GROUP_REGEX, ASSIGN_MATCHING_ATTRIBUTE_REGEX.
        /// </summary>
        [JsonProperty(PropertyName = "assign_tenant")]
        public string? AssignTenant { get; set; }
        /// <summary>
        /// Assignment rule for the User Account Profile. Enum options - ASSIGN_ALL, ASSIGN_FROM_SELECT_LIST,
        /// ASSIGN_MATCHING_GROUP_NAME, ASSIGN_MATCHING_ATTRIBUTE_VALUE, ASSIGN_MATCHING_GROUP_REGEX,
        /// ASSIGN_MATCHING_ATTRIBUTE_REGEX. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "assign_userprofile")]
        public string? AssignUserprofile { get; set; }
        /// <summary>
        /// Placeholder for description of property attribute_match of obj type AuthMappingRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "attribute_match")]
        public NSXTALBAuthMatchAttributeType AttributeMatch { get; set; }
        /// <summary>
        /// Placeholder for description of property group_match of obj type AuthMappingRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "group_match")]
        public NSXTALBAuthMatchGroupMembershipType GroupMatch { get; set; }
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Placeholder for description of property is_superuser of obj type AuthMappingRule field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_superuser")]
        public bool? IsSuperuser { get; set; }
        /// <summary>
        /// Object Access Policies to assign to user on successful match. It is a reference to an object of type ObjectAccessPolicy.
        /// Field deprecated in 20.1.2. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "object_access_policy_refs")]
        public IList<string> ObjectAccessPolicyRefs { get; set; }
        /// <summary>
        /// Attribute name for Object Access Policy assignment. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "policy_attribute_name")]
        public string? PolicyAttributeName { get; set; }
        /// <summary>
        /// role_attribute_name of AuthMappingRule.
        /// </summary>
        [JsonProperty(PropertyName = "role_attribute_name")]
        public string? RoleAttributeName { get; set; }
        /// <summary>
        /// It is a reference to an object of type Role.
        /// </summary>
        [JsonProperty(PropertyName = "role_refs")]
        public IList<string> RoleRefs { get; set; }
        /// <summary>
        /// tenant_attribute_name of AuthMappingRule.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_attribute_name")]
        public string? TenantAttributeName { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_refs")]
        public IList<string> TenantRefs { get; set; }
        /// <summary>
        /// Attribute name for User Account Profile assignment. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "userprofile_attribute_name")]
        public string? UserprofileAttributeName { get; set; }
        /// <summary>
        /// User Account Profile to assign to user on successful match. It is a reference to an object of type UserAccountProfile.
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "userprofile_ref")]
        public string? UserprofileRef { get; set; }
    }
}
