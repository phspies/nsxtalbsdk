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
    public class NSXTALBGslbPoolMemberType 
    {
        /// <summary>
        /// The Cloud UUID of the Site. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// The Cluster UUID of the Site.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
        /// <summary>
        /// User provided information that records member details such as application owner name, contact, etc. Field introduced in
        /// 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable or Disable member to decide if this address should be provided in DNS responses.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The pool member is configured with a fully qualified domain name.  The FQDN is resolved to an IP address by the
        /// controller. DNS service shall health monitor the resolved IP address while it will return the fqdn(cname) in the DNS
        /// response.If the user has configured an IP address (in addition to the FQDN), then the IP address will get overwritten
        /// whenever periodic FQDN refresh is done by the controller. .
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Internal generated system-field. Field deprecated in 18.2.2. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hm_proxies")]
        public IList<NSXTALBGslbHealthMonitorProxyType> HmProxies { get; set; }
        /// <summary>
        /// Hostname to be used as host header for http health monitors and as TLS server name for https health monitors.(By
        /// default, the fqdn of the GSLB pool member or GSLB service is used.) Note  this field is not used as http host header
        /// when exact_http_request is set in the health monitor. . Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// IP address of the pool member. If this IP address is hosted via an AVI virtual service, then the user should configure
        /// the cluster uuid and virtual service uuid. If this IP address is hosted on a third-party device and the device is
        /// tagged/tethered to a third-party site, then user can configure the third-party site uuid.  User may configure the IP
        /// address without the cluster uuid or the virtual service uuid.  In this option, some advanced site related features
        /// cannot be enabled. If the user has configured a fqdn for the pool member, then it takes precedence and will overwrite
        /// the configured IP address. .
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Geographic location of the pool member. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGslbGeoLocationType Location { get; set; }
        /// <summary>
        /// Alternate IP addresses of the pool member. In usual deployments, the VIP in the virtual service is a private IP address.
        /// This gets configured in the 'ip' field of the GSLB service. This field is used to host the public IP address for the
        /// VIP, which gets NATed to the private IP by a firewall. Client DNS requests coming in from within the intranet should
        /// have the private IP served in the A record, and requests from outside this should be served the public IP address. Field
        /// introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "public_ip")]
        public NSXTALBGslbIpAddrType PublicIp { get; set; }
        /// <summary>
        /// Overrides the default ratio of 1.  Reduces the percentage the LB algorithm would pick the server in relation to its
        /// peers.  Range is 1-20. Allowed values are 1-20.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
        /// <summary>
        /// This field indicates if the fqdn should be resolved to a v6 or a v4 address family. . Field introduced in 18.2.8,
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "resolve_fqdn_to_v6")]
        public bool? ResolveFqdnToV6 { get; set; }
        /// <summary>
        /// Select local virtual service in the specified controller cluster belonging to this GSLB service. The virtual service may
        /// have multiple IP addresses and FQDNs.  User will have to choose IP address or FQDN and configure it in the respective
        /// field. .
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
