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
    public class NSXTALBServerType 
    {
        /// <summary>
        /// Name of autoscaling group this server belongs to. Field introduced in 17.1.2. Allowed in Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "autoscaling_group_name")]
        public string? AutoscalingGroupName { get; set; }
        /// <summary>
        /// Availability-zone of the server VM.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// A description of the Server.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// (internal-use) Discovered network for this server. This field is deprecated. It is a reference to an object of type
        /// Network. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_network_ref")]
        public IList<string> DiscoveredNetworkRef { get; set; }
        /// <summary>
        /// (internal-use) Discovered networks providing reachability for server IP. This field is used internally by Avi, not
        /// editable by the user.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_networks")]
        public IList<NSXTALBDiscoveredNetworkType> DiscoveredNetworks { get; set; }
        /// <summary>
        /// (internal-use) Discovered subnet for this server. This field is deprecated. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_subnet")]
        public IList<NSXTALBIpAddrPrefixType> DiscoveredSubnet { get; set; }
        /// <summary>
        /// Enable, Disable or Graceful Disable determine if new or existing connections to the server are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// UID of server in external orchestration systems.
        /// </summary>
        [JsonProperty(PropertyName = "external_orchestration_id")]
        public string? ExternalOrchestrationId { get; set; }
        /// <summary>
        /// UUID identifying VM in OpenStack and other external compute.
        /// </summary>
        [JsonProperty(PropertyName = "external_uuid")]
        public string? ExternalUuid { get; set; }
        /// <summary>
        /// DNS resolvable name of the server.  May be used in place of the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// IP Address of the server.  Required if there is no resolvable host name.
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// (internal-use) Geographic location of the server.Currently only for internal usage. Field introduced in 17.1.1. Allowed
        /// in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGeoLocationType Location { get; set; }
        /// <summary>
        /// MAC address of server.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// (internal-use) This field is used internally by Avi, not editable by the user. It is a reference to an object of type
        /// VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "nw_ref")]
        public string? NwRef { get; set; }
        /// <summary>
        /// Optionally specify the servers port number.  This will override the pool's default server port attribute. Allowed values
        /// are 1-65535. Special values are 0- use backend port in pool.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// Header value for custom header persistence. .
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_val")]
        public string? PrstHdrVal { get; set; }
        /// <summary>
        /// Ratio of selecting eligible servers in the pool. Allowed values are 1-20.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public int? Ratio { get; set; }
        /// <summary>
        /// Auto resolve server's IP using DNS name. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values-
        /// false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "resolve_server_by_dns")]
        public bool? ResolveServerByDns { get; set; }
        /// <summary>
        /// Rewrite incoming Host Header to server name.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_host_header")]
        public bool? RewriteHostHeader { get; set; }
        /// <summary>
        /// Hostname of the node where the server VM or container resides.
        /// </summary>
        [JsonProperty(PropertyName = "server_node")]
        public string? ServerNode { get; set; }
        /// <summary>
        /// If statically learned.
        /// </summary>
        [JsonProperty(PropertyName = "static")]
        public bool? Static { get; set; }
        /// <summary>
        /// Verify server belongs to a discovered network or reachable via a discovered network. Verify reachable network isn't the
        /// OpenStack management network.
        /// </summary>
        [JsonProperty(PropertyName = "verify_network")]
        public bool? VerifyNetwork { get; set; }
        /// <summary>
        /// (internal-use) This field is used internally by Avi, not editable by the user. It is a reference to an object of type
        /// VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vm_ref")]
        public string? VmRef { get; set; }
    }
}
