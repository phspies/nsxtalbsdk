using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbPoolMemberRuntimeInfoType
    {
        /// <summary>
        /// Application type of the VS. Enum options - APPLICATION_PROFILE_TYPE_L4, APPLICATION_PROFILE_TYPE_HTTP,
        /// APPLICATION_PROFILE_TYPE_SYSLOG, APPLICATION_PROFILE_TYPE_DNS, APPLICATION_PROFILE_TYPE_SSL,
        /// APPLICATION_PROFILE_TYPE_SIP. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "app_type")]
        public string? AppType { get; set; }
        /// <summary>
        /// The Site Controller Cluster UUID to which this member belongs.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
        /// <summary>
        /// Controller retrieved member status at the site.
        /// </summary>
        [JsonProperty(PropertyName = "controller_status")]
        public NSXTALBOperationalStatusType ControllerStatus { get; set; }
        /// <summary>
        /// DNS computed member status from different sites.
        /// </summary>
        [JsonProperty(PropertyName = "datapath_status")]
        public IList<NSXTALBGslbPoolMemberDatapathStatusType> DatapathStatus { get; set; }
        /// <summary>
        /// FQDN address of the member. .
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// gs_name of GslbPoolMemberRuntimeInfo.
        /// </summary>
        [JsonProperty(PropertyName = "gs_name")]
        public string? GsName { get; set; }
        /// <summary>
        /// The GSLB service to which this member belongs.
        /// </summary>
        [JsonProperty(PropertyName = "gs_uuid")]
        public string? GsUuid { get; set; }
        /// <summary>
        /// GSLB pool member's configured VIP. .
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// This is an internal field that conveys the IP address from the controller to service engine in binary format. .
        /// </summary>
        [JsonProperty(PropertyName = "ip_value_to_se")]
        public int? IpValueToSe { get; set; }
        /// <summary>
        /// This is an internal field that conveys the IPV6 address from the controller to service engine in binary format. . Field
        /// introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_value_to_se")]
        public int? Ipv6ValueToSe { get; set; }
        /// <summary>
        /// Operational VIPs of the member  that can map to multiple VS IP addresses such as private, public and floating addresses.
        /// </summary>
        [JsonProperty(PropertyName = "oper_ips")]
        public IList<NSXTALBIpAddrType> OperIps { get; set; }
        /// <summary>
        /// Gslb Pool member's consolidated operational status .
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// services configured on the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<NSXTALBServiceType> Services { get; set; }
        /// <summary>
        /// The Site 's name is required for event-generation etc.
        /// </summary>
        [JsonProperty(PropertyName = "site_name")]
        public string? SiteName { get; set; }
        /// <summary>
        /// Site persistence pools associated with the VS. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sp_pools")]
        public IList<NSXTALBGslbServiceSitePersistencePoolType> SpPools { get; set; }
        /// <summary>
        /// Describes the VIP type  Avi or third-party. Enum options - NON_AVI_VIP, AVI_VIP.
        /// </summary>
        [JsonProperty(PropertyName = "vip_type")]
        public string? VipType { get; set; }
        /// <summary>
        /// VS name belonging to this GSLB service.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// VS UUID belonging to this GSLB service.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
        /// <summary>
        /// Front end L4 metrics of the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "vserver_l4_metrics")]
        public NSXTALBVserverL4MetricsObjType VserverL4Metrics { get; set; }
        /// <summary>
        /// Front end L7 metrics of the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "vserver_l7_metrics")]
        public NSXTALBVserverL7MetricsObjType VserverL7Metrics { get; set; }
    }
}
