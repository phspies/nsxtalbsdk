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
    public class NSXTALBHealthMonitorType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// By default, multiple instances of the same healthmonitor to the same server are suppressed intelligently. In rare cases,
        /// the monitor may have specific constructs that go beyond the server keys (ip, port, etc.) during which such suppression
        /// is not desired. Use this knob to allow duplicates. Field introduced in 18.2.8. Allowed in Basic(Allowed values- true)
        /// edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "allow_duplicate_monitors")]
        public bool? AllowDuplicateMonitors { get; set; }
        /// <summary>
        /// Authentication information for username/password. Field introduced in 20.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public NSXTALBHealthMonitorAuthInfoType Authentication { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// During addition of a server or healthmonitors or during bootup, Avi performs sequential health checks rather than
        /// waiting for send-interval to kick in, to mark the server up as soon as possible. This knob may be used to turn this
        /// feature off. Field introduced in 18.2.7. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values-
        /// false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "disable_quickstart")]
        public bool? DisableQuickstart { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_monitor of obj type HealthMonitor field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dns_monitor")]
        public NSXTALBHealthMonitorDNSType DnsMonitor { get; set; }
        /// <summary>
        /// Placeholder for description of property external_monitor of obj type HealthMonitor field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "external_monitor")]
        public NSXTALBHealthMonitorExternalType ExternalMonitor { get; set; }
        /// <summary>
        /// Number of continuous failed health checks before the server is marked down. Allowed values are 1-50.
        /// </summary>
        [JsonProperty(PropertyName = "failed_checks")]
        public int? FailedChecks { get; set; }
        /// <summary>
        /// Health monitor for FTP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ftp_monitor")]
        public NSXTALBHealthMonitorFtpType FtpMonitor { get; set; }
        /// <summary>
        /// Health monitor for FTPS. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ftps_monitor")]
        public NSXTALBHealthMonitorFtpType FtpsMonitor { get; set; }
        /// <summary>
        /// Placeholder for description of property http_monitor of obj type HealthMonitor field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "http_monitor")]
        public NSXTALBHealthMonitorHttpType HttpMonitor { get; set; }
        /// <summary>
        /// Placeholder for description of property https_monitor of obj type HealthMonitor field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "https_monitor")]
        public NSXTALBHealthMonitorHttpType HttpsMonitor { get; set; }
        /// <summary>
        /// Health monitor for IMAP. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "imap_monitor")]
        public NSXTALBHealthMonitorImapType ImapMonitor { get; set; }
        /// <summary>
        /// Health monitor for IMAPS. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "imaps_monitor")]
        public NSXTALBHealthMonitorImapType ImapsMonitor { get; set; }
        /// <summary>
        /// This field describes the object's replication scope. If the field is set to false, then the object is visible within the
        /// controller-cluster and its associated service-engines.  If the field is set to true, then the object is replicated
        /// across the federation.  . Field introduced in 17.1.3. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Health monitor for LDAP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ldap_monitor")]
        public NSXTALBHealthMonitorLdapType LdapMonitor { get; set; }
        /// <summary>
        /// Health monitor for LDAPS. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ldaps_monitor")]
        public NSXTALBHealthMonitorLdapType LdapsMonitor { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Use this port instead of the port defined for the server in the Pool. If the monitor succeeds to this port, the load
        /// balanced traffic will still be sent to the port of the server defined within the Pool. Allowed values are 1-65535.
        /// Special values are 0 - Use server port.
        /// </summary>
        [JsonProperty(PropertyName = "monitor_port")]
        public int? MonitorPort { get; set; }
        /// <summary>
        /// A user friendly name for this health monitor.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Health monitor for POP3. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pop3_monitor")]
        public NSXTALBHealthMonitorPop3Type Pop3Monitor { get; set; }
        /// <summary>
        /// Health monitor for POP3S. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pop3s_monitor")]
        public NSXTALBHealthMonitorPop3Type Pop3sMonitor { get; set; }
        /// <summary>
        /// Health monitor for Radius. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "radius_monitor")]
        public NSXTALBHealthMonitorRadiusType RadiusMonitor { get; set; }
        /// <summary>
        /// A valid response from the server is expected within the receive timeout window.  This timeout must be less than the send
        /// interval.  If server status is regularly flapping up and down, consider increasing this value. Allowed values are
        /// 1-2400. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "receive_timeout")]
        public int? ReceiveTimeout { get; set; }
        /// <summary>
        /// Frequency, in seconds, that monitors are sent to a server. Allowed values are 1-3600. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "send_interval")]
        public int? SendInterval { get; set; }
        /// <summary>
        /// Health monitor for SIP. Field introduced in 17.2.8, 18.1.3, 18.2.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sip_monitor")]
        public NSXTALBHealthMonitorSIPType SipMonitor { get; set; }
        /// <summary>
        /// Health monitor for SMTP. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "smtp_monitor")]
        public NSXTALBHealthMonitorSmtpType SmtpMonitor { get; set; }
        /// <summary>
        /// Health monitor for SMTPS. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "smtps_monitor")]
        public NSXTALBHealthMonitorSmtpType SmtpsMonitor { get; set; }
        /// <summary>
        /// Number of continuous successful health checks before server is marked up. Allowed values are 1-50.
        /// </summary>
        [JsonProperty(PropertyName = "successful_checks")]
        public int? SuccessfulChecks { get; set; }
        /// <summary>
        /// Placeholder for description of property tcp_monitor of obj type HealthMonitor field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "tcp_monitor")]
        public NSXTALBHealthMonitorTcpType TcpMonitor { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Type of the health monitor. Enum options - HEALTH_MONITOR_PING, HEALTH_MONITOR_TCP, HEALTH_MONITOR_HTTP,
        /// HEALTH_MONITOR_HTTPS, HEALTH_MONITOR_EXTERNAL, HEALTH_MONITOR_UDP, HEALTH_MONITOR_DNS, HEALTH_MONITOR_GSLB,
        /// HEALTH_MONITOR_SIP, HEALTH_MONITOR_RADIUS, HEALTH_MONITOR_SMTP, HEALTH_MONITOR_SMTPS, HEALTH_MONITOR_POP3,
        /// HEALTH_MONITOR_POP3S, HEALTH_MONITOR_IMAP, HEALTH_MONITOR_IMAPS, HEALTH_MONITOR_FTP, HEALTH_MONITOR_FTPS,
        /// HEALTH_MONITOR_LDAP, HEALTH_MONITOR_LDAPS. Allowed in Basic(Allowed values-
        /// HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP,HEALTH_MONITOR_HTTP,HEALTH_MONITOR_HTTPS) edition,
        /// Essentials(Allowed values- HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// Placeholder for description of property udp_monitor of obj type HealthMonitor field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "udp_monitor")]
        public NSXTALBHealthMonitorUdpType UdpMonitor { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the health monitor.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
