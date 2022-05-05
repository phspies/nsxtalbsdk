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
    public class NSXTALBSCServerStateInfoType 
    {
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        public NSXTALBIpAddrType ServerIp { get; set; }
        /// <summary>
        /// Allowed values are 1-65535. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_port")]
        public int? ServerPort { get; set; }
    }
}
