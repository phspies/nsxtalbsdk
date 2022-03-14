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
    public class NSXTALBGslbPerDnsStateType 
    {
        /// <summary>
        /// This field describes the GeoDbProfile download status to the dns-vs. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "geo_download")]
        public NSXTALBGslbDownloadStatusType GeoDownload { get; set; }
        /// <summary>
        /// This field describes the Gslb, GslbService, HealthMonitor download status to the dns-vs. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_download")]
        public NSXTALBGslbDownloadStatusType GslbDownload { get; set; }
        /// <summary>
        /// Configured dns-vs-name at the site.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property oper_status of obj type GslbPerDnsState field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// This field describes the SubDomain placement rules for this DNS-VS. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "placement_rules")]
        public IList<NSXTALBGslbSubDomainPlacementRuntimeType> PlacementRules { get; set; }
        /// <summary>
        /// The service engines associated with the DNS-VS. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_list")]
        public IList<string> SeList { get; set; }
        /// <summary>
        /// Configured dns-vs-uuid at the site.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// This field indicates that the local VS is configured to be a DNS service. The services, network profile and application
        /// profile are configured in Virtual Service for DNS operations. .
        /// </summary>
        [JsonProperty(PropertyName = "valid_dns_vs")]
        public bool? ValidDnsVs { get; set; }
    }
}
