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
    public class NSXTALBGslbSiteType 
    {
        public NSXTALBGslbSiteType()
        {
        }
        /// <summary>
        /// IP Address or a DNS resolvable, fully qualified domain name of the Site Controller Cluster.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
        /// <summary>
        /// UUID of the 'Cluster' object of the Controller Cluster in this site.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClusterUuid { get; set; }
        /// <summary>
        /// The DNS VSes on which the GslbServices shall be placed. The site has to be an ACTIVE member.  This field is deprecated
        /// in 17.2.3 and replaced by 'dns_vses' field. . Field deprecated in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "dns_vs_uuids")]
        public IList<string> DnsVsUuids { get; set; }
        /// <summary>
        /// This field identifies the DNS VS and the subdomains it hosts for Gslb services. . Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "dns_vses")]
        public IList<NSXTALBGslbSiteDnsVsType> DnsVses { get; set; }
        /// <summary>
        /// Enable or disable the Site.  This is useful in maintenance scenarios such as upgrade and routine maintenance.  A
        /// disabled site's configuration shall be retained but it will not get any new configuration updates.  It shall not
        /// participate in Health-Status monitoring.  VIPs of the Virtual Services on the disabled site shall not be sent in DNS
        /// response.  When a site transitions from disabled to enabled, it is treated similar to the addition of a new site.
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
        /// This field enables the health monitor shard functionality on a site-basis. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "hm_shard_enabled")]
        public bool? HmShardEnabled { get; set; }
        /// <summary>
        /// IP Address(es) of the Site's Cluster. For a 3-node cluster, either the cluster vIP is provided, or the list of
        /// controller IPs in the cluster are provided. Maximum of 3 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<NSXTALBIpAddrType> IpAddresses { get; set; }
        /// <summary>
        /// Geographic location of the site. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGslbGeoLocationType Location { get; set; }
        /// <summary>
        /// The site's member type  A leader is set to ACTIVE while allmembers are set to passive. . Enum options -
        /// GSLB_ACTIVE_MEMBER, GSLB_PASSIVE_MEMBER.
        /// </summary>
        [JsonProperty(PropertyName = "member_type")]
        public string? MemberType { get; set; }
        /// <summary>
        /// Name for the Site Controller Cluster. After any changes to site name, references to GSLB site name should be updated
        /// manually. Ex  Site name used in DNS policies or Topology policies should be updated to use the new site name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// The password used when authenticating with the Site.
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        /// <summary>
        /// The Site Controller Cluster's REST API port number. Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// User can overide the individual GslbPoolMember ratio for all the VIPs/VS(es) of this site. If this field is not 
        /// configured then the GslbPoolMember ratio gets applied. . Allowed values are 1-20. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
        /// <summary>
        /// This modes applies to follower sites. When an active site is in suspend mode, the site does not receive any further
        /// federated objects. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "suspend_mode")]
        public bool? SuspendMode { get; set; }
        /// <summary>
        /// The username used when authenticating with the Site. .
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
        /// <summary>
        /// This field is used as a key in the datastore for the GslbSite table to encapsulate site-related info. . Field introduced
        /// in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
