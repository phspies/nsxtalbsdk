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
    public class NSXTALBSnmpTrapServerType 
    {
        /// <summary>
        /// The community string to communicate with the trap server.
        /// </summary>
        [JsonProperty(PropertyName = "community")]
        public string? Community { get; set; }
        /// <summary>
        /// IP Address of the SNMP trap destination.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpAddr { get; set; }
        /// <summary>
        /// The UDP port of the trap server. Field introduced in 16.5.4,17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// SNMP version 3 configuration. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public NSXTALBSnmpV3UserParamsType User { get; set; }
        /// <summary>
        /// SNMP version support. V2 or V3. Enum options - SNMP_VER2, SNMP_VER3. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
