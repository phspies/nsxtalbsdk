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
    public class NSXTALBSePoolLbEventDetailsType 
    {
        /// <summary>
        /// Reason code for load balancing failure. Enum options - PERSISTENT_SERVER_INVALID, PERSISTENT_SERVER_DOWN, SRVR_DOWN,
        /// ADD_PENDING, SLOW_START_MAX_CONN, MAX_CONN, NO_LPORT, SUSPECT_STATE, MAX_CONN_RATE, CAPEST_RAND_MAX_CONN, GET_NEXT.
        /// </summary>
        [JsonProperty(PropertyName = "failure_code")]
        public string? FailureCode { get; set; }
        /// <summary>
        /// Pool name. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public string? Pool { get; set; }
        /// <summary>
        /// Reason for Load balancing failure.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// UUID of event generator.
        /// </summary>
        [JsonProperty(PropertyName = "src_uuid")]
        public string? SrcUuid { get; set; }
        /// <summary>
        /// Virtual Service name. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_service")]
        public string? VirtualService { get; set; }
    }
}
