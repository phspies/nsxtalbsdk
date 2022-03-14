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
    public class NSXTALBCdpLldpInfoType 
    {
        public NSXTALBCdpLldpInfoType()
        {
        }
        /// <summary>
        /// chassis of CdpLldpInfo.
        /// </summary>
        [JsonProperty(PropertyName = "chassis")]
        public string? Chassis { get; set; }
        /// <summary>
        /// device of CdpLldpInfo.
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public string? Device { get; set; }
        /// <summary>
        /// mgmtaddr of CdpLldpInfo.
        /// </summary>
        [JsonProperty(PropertyName = "mgmtaddr")]
        public string? Mgmtaddr { get; set; }
        /// <summary>
        /// port of CdpLldpInfo.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
        /// <summary>
        /// Enum options - CDP, LLDP, NOT_APPLICABLE.
        /// </summary>
        [JsonProperty(PropertyName = "switch_info_type")]
        public string? SwitchInfoType { get; set; }
        /// <summary>
        /// system_name of CdpLldpInfo.
        /// </summary>
        [JsonProperty(PropertyName = "system_name")]
        public string? SystemName { get; set; }
    }
}
