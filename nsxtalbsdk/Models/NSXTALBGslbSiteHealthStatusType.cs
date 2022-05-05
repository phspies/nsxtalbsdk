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
    public class NSXTALBGslbSiteHealthStatusType 
    {
        /// <summary>
        /// Controller retrieved GSLB service operational info based of virtual service state. .
        /// </summary>
        [JsonProperty(PropertyName = "controller_gsinfo")]
        public IList<NSXTALBGslbPoolMemberRuntimeInfoType> ControllerGsinfo { get; set; }
        /// <summary>
        /// Controller retrieved GSLB service operational info based of dns datapath resolution. This information is generated only
        /// on those sites that have DNS-VS participating in GSLB.
        /// </summary>
        [JsonProperty(PropertyName = "datapath_gsinfo")]
        public IList<NSXTALBGslbPoolMemberRuntimeInfoType> DatapathGsinfo { get; set; }
        /// <summary>
        /// DNS info at the site.
        /// </summary>
        [JsonProperty(PropertyName = "dns_info")]
        public NSXTALBGslbDnsInfoType DnsInfo { get; set; }
        /// <summary>
        /// GSLB application persistence profile state at member. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gap_table")]
        public IList<NSXTALBCfgStateType> GapTable { get; set; }
        /// <summary>
        /// GSLB Geo Db profile state at member. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "geo_table")]
        public IList<NSXTALBCfgStateType> GeoTable { get; set; }
        /// <summary>
        /// GSLB health monitor state at member.
        /// </summary>
        [JsonProperty(PropertyName = "ghm_table")]
        public IList<NSXTALBCfgStateType> GhmTable { get; set; }
        /// <summary>
        /// GSLB state at member.
        /// </summary>
        [JsonProperty(PropertyName = "glb_table")]
        public IList<NSXTALBCfgStateType> GlbTable { get; set; }
        /// <summary>
        /// GSLB service state at member.
        /// </summary>
        [JsonProperty(PropertyName = "gs_table")]
        public IList<NSXTALBCfgStateType> GsTable { get; set; }
        /// <summary>
        /// Current Software version of the site.
        /// </summary>
        [JsonProperty(PropertyName = "sw_version")]
        public string? SwVersion { get; set; }
        /// <summary>
        /// Timestamp of Health-Status generation.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public double? Timestamp { get; set; }
    }
}
