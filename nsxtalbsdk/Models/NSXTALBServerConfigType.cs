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
    public class NSXTALBServerConfigType 
    {
        public NSXTALBServerConfigType()
        {
        }
        /// <summary>
        /// Placeholder for description of property def_port of obj type ServerConfig field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "def_port")]
        public bool? DefPort { get; set; }
        /// <summary>
        /// hostname of ServerConfig.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_addr of obj type ServerConfig field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpAddr { get; set; }
        /// <summary>
        /// Placeholder for description of property is_enabled of obj type ServerConfig field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_enabled", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsEnabled { get; set; }
        /// <summary>
        /// Enum options - OPER_UP, OPER_DOWN, OPER_CREATING, OPER_RESOURCES, OPER_INACTIVE, OPER_DISABLED, OPER_UNUSED,
        /// OPER_UNKNOWN, OPER_PROCESSING, OPER_INITIALIZING, OPER_ERROR_DISABLED, OPER_AWAIT_MANUAL_PLACEMENT, OPER_UPGRADING,
        /// OPER_SE_PROCESSING, OPER_PARTITIONED, OPER_DISABLING, OPER_FAILED, OPER_UNAVAIL.
        /// </summary>
        [JsonProperty(PropertyName = "last_state")]
        public string? LastState { get; set; }
        /// <summary>
        /// VirtualService member in case this server is a member of GS group, and Geo Location available.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGeoLocationType Location { get; set; }
        /// <summary>
        /// Placeholder for description of property oper_status of obj type ServerConfig field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// Number of port.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Port { get; set; }
        /// <summary>
        /// If this is set, propogate this server state to other SEs for this VS. Applicable to EastWest VS and GS HM-sharding.
        /// </summary>
        [JsonProperty(PropertyName = "propogate_state")]
        public bool? PropogateState { get; set; }
        /// <summary>
        /// Placeholder for description of property timer_exists of obj type ServerConfig field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "timer_exists")]
        public bool? TimerExists { get; set; }
    }
}
