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
    public class NSXTALBGslbThirdPartySiteType 
    {
        /// <summary>
        /// Third-party-site identifier generated by Avi. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
        /// <summary>
        /// Enable or disable the third-party Site.  This is useful in maintenance scenarios such as upgrade and routine
        /// maintenance. A disabled site's configuration shall be retained  but it will not get any new configuration updates.  
        /// VIPs associated with the disabled site shall not be sent in DNS response. . Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// User can designate certain Avi sites to run health monitor probes for VIPs/VS(es) for this site. This is useful in
        /// network deployments where the VIPs/VS(es) are reachable only from certain sites. A typical scenario is a firewall
        /// between two GSLB sites. User may want to run health monitor probes from sites on either side of the firewall so that
        /// each designated site can derive a datapath view of the reachable members. If the health monitor proxies are not
        /// configured, then the default behavior is to run health monitor probes from all the active sites. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hm_proxies")]
        public IList<NSXTALBGslbHealthMonitorProxyType> HmProxies { get; set; }
        /// <summary>
        /// Geographic location of the site. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGslbGeoLocationType Location { get; set; }
        /// <summary>
        /// Name of the third-party Site. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// User can overide the individual GslbPoolMember ratio for all the VIPs of this site. If this field is not configured,
        /// then the GslbPoolMember ratio gets applied. . Allowed values are 1-20. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
        /// <summary>
        /// This field is used as a key in the datastore for the GslbThirdPartySite table to encapsulate site-related info. . Field
        /// introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}