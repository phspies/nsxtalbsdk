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
    public class NSXTALBAuthProfileHTTPClientParamsType 
    {
        /// <summary>
        /// The max allowed length of time a clients authentication is cached. Allowed values are 1-30. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "cache_expiration_time")]
        public int? CacheExpirationTime { get; set; }
        /// <summary>
        /// Group member entries contain full DNs instead of just user id attribute values. This should now be configured using the
        /// LdapDirectorySettings field instead. Field deprecated in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "group_member_is_full_dn")]
        public bool? GroupMemberIsFullDn { get; set; }
        /// <summary>
        /// Insert an HTTP header.  This field is used to define the header name.  The value of the header is set to the client's
        /// HTTP Auth user ID.
        /// </summary>
        [JsonProperty(PropertyName = "request_header")]
        public string? RequestHeader { get; set; }
        /// <summary>
        /// A user should be a member of these groups.  Each group is defined by the DN.  For example,
        /// CN=testgroup,OU=groups,dc=example,dc=avinetworks,DC=com.
        /// </summary>
        [JsonProperty(PropertyName = "require_user_groups")]
        public IList<string> RequireUserGroups { get; set; }
    }
}
