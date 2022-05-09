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
    public class NSXTALBSubResourceType 
    {
        /// <summary>
        /// Allows modification of all fields except for the specified subresources. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_subresources")]
        public bool? ExcludeSubresources { get; set; }
        /// <summary>
        /// Subresources user can modify. Each subresource specifies and individual field. I.e. SUBRESOURCE_POOL_ENABLED allows
        /// modification of the enabled field in the Pool object. Enum options - SUBRESOURCE_POOL_ENABLED, SUBRESOURCE_POOL_SERVERS,
        /// SUBRESOURCE_POOL_SERVER_ENABLED, SUBRESOURCE_VIRTUALSERVICE_ENABLED, SUBRESOURCE_GSLBSERVICE_ENABLED,
        /// SUBRESOURCE_GSLBSERVICE_GROUPS, SUBRESOURCE_GSLBSERVICE_GROUP_ENABLED, SUBRESOURCE_GSLBSERVICE_GROUP_MEMBERS,
        /// SUBRESOURCE_GSLBSERVICE_GROUP_MEMBER_ENABLED. Field introduced in 20.1.5. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "subresources")]
        public IList<string> Subresources { get; set; }
    }
}
