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
    public class NSXTALBGslbSiteRuntimeInfoType 
    {
        public NSXTALBGslbSiteRuntimeInfoType()
        {
        }
        /// <summary>
        /// The Leader-IP/VIP/FQDN of the site-cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_leader")]
        public string? ClusterLeader { get; set; }
        /// <summary>
        /// Unique object identifier of cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
        /// <summary>
        /// operational dns state at the site.
        /// </summary>
        [JsonProperty(PropertyName = "dns_info")]
        public NSXTALBGslbDnsInfoType DnsInfo { get; set; }
        /// <summary>
        /// Enable/disable state retrieved from the cfg .
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// event-cache used for event throttling.
        /// </summary>
        [JsonProperty(PropertyName = "event_cache")]
        public NSXTALBEventCacheType EventCache { get; set; }
        /// <summary>
        /// Health-status monitoring enable or disable.
        /// </summary>
        [JsonProperty(PropertyName = "hs_state")]
        public bool? HsState { get; set; }
        /// <summary>
        /// Placeholder for description of property last_changed_time of obj type GslbSiteRuntimeInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Number of retry attempts to reach the remote site.
        /// </summary>
        [JsonProperty(PropertyName = "num_of_retries")]
        public int? NumOfRetries { get; set; }
        /// <summary>
        /// Placeholder for description of property oper_status of obj type GslbSiteRuntimeInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// Site Role  Leader or Follower. Enum options - GSLB_LEADER, GSLB_MEMBER, GSLB_NOT_A_MEMBER.
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string? Role { get; set; }
        /// <summary>
        /// Current outstanding request-response token of the message to this site.
        /// </summary>
        [JsonProperty(PropertyName = "rrtoken")]
        public IList<string> Rrtoken { get; set; }
        /// <summary>
        /// Indicates if it is Avi Site or third-party. Enum options - GSLB_AVI_SITE, GSLB_THIRD_PARTY_SITE. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "site_type")]
        public string? SiteType { get; set; }
        /// <summary>
        /// Enum options - SITE_STATE_NULL, SITE_STATE_JOIN_IN_PROGRESS, SITE_STATE_LEAVE_IN_PROGRESS, SITE_STATE_INIT,
        /// SITE_STATE_UNREACHABLE, SITE_STATE_MMODE, SITE_STATE_DISABLE_IN_PROGRESS, SITE_STATE_DISABLED.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
        /// <summary>
        /// State - Reason.
        /// </summary>
        [JsonProperty(PropertyName = "state_reason")]
        public string? StateReason { get; set; }
        /// <summary>
        /// Current Software version of the site.
        /// </summary>
        [JsonProperty(PropertyName = "sw_version")]
        public string? SwVersion { get; set; }
    }
}
