using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServiceType
    {
        /// <summary>
        /// Enable HTTP2 on this port. Field introduced in 20.1.1. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_http2")]
        public bool? EnableHttp2 { get; set; }
        /// <summary>
        /// Enable SSL termination and offload for traffic from clients.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssl")]
        public bool? EnableSsl { get; set; }
        /// <summary>
        /// Used for Horizon deployment. If set used for L7 redirect. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "horizon_internal_ports")]
        public bool? HorizonInternalPorts { get; set; }
        /// <summary>
        /// Enable application layer specific features for the this specific service. It is a reference to an object of type
        /// ApplicationProfile. Field introduced in 17.2.4. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "override_application_profile_ref")]
        public string? OverrideApplicationProfileRef { get; set; }
        /// <summary>
        /// Override the network profile for this specific service port. It is a reference to an object of type NetworkProfile.
        /// </summary>
        [JsonProperty(PropertyName = "override_network_profile_ref")]
        public string? OverrideNetworkProfileRef { get; set; }
        /// <summary>
        /// The Virtual Service's port number. Allowed values are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Port { get; set; }
        /// <summary>
        /// The end of the Virtual Service's port number range. Allowed values are 1-65535. Special values are 0- single port.
        /// </summary>
        [JsonProperty(PropertyName = "port_range_end")]
        public int? PortRangeEnd { get; set; }
    }
}
