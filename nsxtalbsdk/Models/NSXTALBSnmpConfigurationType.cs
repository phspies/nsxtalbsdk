using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSnmpConfigurationType
    {
        /// <summary>
        /// Community string for SNMP v2c.
        /// </summary>
        [JsonProperty(PropertyName = "community")]
        public string? Community { get; set; }
        /// <summary>
        /// Support for 4096 bytes trap payload. Field introduced in 17.2.13,18.1.4,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "large_trap_payload")]
        public bool? LargeTrapPayload { get; set; }
        /// <summary>
        /// SNMP version 3 configuration. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "snmp_v3_config")]
        public NSXTALBSnmpV3ConfigurationType SnmpV3Config { get; set; }
        /// <summary>
        /// Sets the sysContact in system MIB.
        /// </summary>
        [JsonProperty(PropertyName = "sys_contact")]
        public string? SysContact { get; set; }
        /// <summary>
        /// Sets the sysLocation in system MIB.
        /// </summary>
        [JsonProperty(PropertyName = "sys_location")]
        public string? SysLocation { get; set; }
        /// <summary>
        /// SNMP version support. V2 or V3. Enum options - SNMP_VER2, SNMP_VER3. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
