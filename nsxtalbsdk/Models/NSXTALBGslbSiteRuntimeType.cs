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
    public class NSXTALBGslbSiteRuntimeType 
    {
        /// <summary>
        /// This field shadows glb_cfg.clear_on_max_retries. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "clear_on_max_retries")]
        public int? ClearOnMaxRetries { get; set; }
        /// <summary>
        /// This field tracks the glb-uuid. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "glb_uuid")]
        public string? GlbUuid { get; set; }
        /// <summary>
        /// Carries replication stats for a given site. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "replication_stats")]
        public NSXTALBGslbReplicationStatsType ReplicationStats { get; set; }
        /// <summary>
        /// Placeholder for description of property rxed_site_hs of obj type GslbSiteRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rxed_site_hs")]
        public NSXTALBGslbSiteHealthStatusType RxedSiteHs { get; set; }
        /// <summary>
        /// Frequency with which group members communicate. This field shadows glb_cfg.send_interval. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "send_interval")]
        public int? SendInterval { get; set; }
        /// <summary>
        /// Placeholder for description of property site_cfg of obj type GslbSiteRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "site_cfg")]
        public NSXTALBGslbSiteRuntimeCfgType SiteCfg { get; set; }
        /// <summary>
        /// Placeholder for description of property site_info of obj type GslbSiteRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "site_info")]
        public NSXTALBGslbSiteRuntimeInfoType SiteInfo { get; set; }
        /// <summary>
        /// Placeholder for description of property site_stats of obj type GslbSiteRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "site_stats")]
        public NSXTALBGslbSiteRuntimeStatsType SiteStats { get; set; }
        /// <summary>
        /// Remap the tenant_uuid to its tenant-name so that we can use the tenant_name directly in remote-site ops. . Field
        /// introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_name")]
        public string? TenantName { get; set; }
        /// <summary>
        /// This field shadows the glb_cfg.view_id.  . Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "view_id")]
        public long? ViewId { get; set; }
    }
}
