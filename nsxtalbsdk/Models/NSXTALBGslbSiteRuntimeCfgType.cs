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
    public class NSXTALBGslbSiteRuntimeCfgType 
    {
        public NSXTALBGslbSiteRuntimeCfgType()
        {
        }
        /// <summary>
        /// Gslb GeoDb files published for a site. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fd_info")]
        public NSXTALBConfigInfoType FdInfo { get; set; }
        /// <summary>
        /// Gslb Application Persistence info published for a site. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gap_info")]
        public NSXTALBConfigInfoType GapInfo { get; set; }
        /// <summary>
        /// Gslb GeoDb info published for a site. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "geo_info")]
        public NSXTALBConfigInfoType GeoInfo { get; set; }
        /// <summary>
        /// GHM info published for a site.
        /// </summary>
        [JsonProperty(PropertyName = "ghm_info")]
        public NSXTALBConfigInfoType GhmInfo { get; set; }
        /// <summary>
        /// Gslb JWTProfile info published for a site. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "gjwt_info")]
        public NSXTALBConfigInfoType GjwtInfo { get; set; }
        /// <summary>
        /// Gslb info published for a site.
        /// </summary>
        [JsonProperty(PropertyName = "glb_info")]
        public NSXTALBConfigInfoType GlbInfo { get; set; }
        /// <summary>
        /// Gslb PKI info published for a site. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gpki_info")]
        public NSXTALBConfigInfoType GpkiInfo { get; set; }
        /// <summary>
        /// GS info published for a site.
        /// </summary>
        [JsonProperty(PropertyName = "gs_info")]
        public NSXTALBConfigInfoType GsInfo { get; set; }
        /// <summary>
        /// Maintenance mode info published for a site.
        /// </summary>
        [JsonProperty(PropertyName = "mm_info")]
        public NSXTALBConfigInfoType MmInfo { get; set; }
        /// <summary>
        /// The replication queue for all object-types for a site. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "repl_queue")]
        public NSXTALBConfigInfoType ReplQueue { get; set; }
        /// <summary>
        /// Configuration sync-info of the site .
        /// </summary>
        [JsonProperty(PropertyName = "sync_info")]
        public NSXTALBGslbSiteCfgSyncInfoType SyncInfo { get; set; }
    }
}
