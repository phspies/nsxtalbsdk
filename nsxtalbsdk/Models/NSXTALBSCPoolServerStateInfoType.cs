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
    public class NSXTALBSCPoolServerStateInfoType 
    {
        public NSXTALBSCPoolServerStateInfoType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_server")]
        public bool? IsServer { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pool_id")]
        public string? PoolId { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_states")]
        public IList<NSXTALBSCServerStateInfoType> ServerStates { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
