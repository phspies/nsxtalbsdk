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
    public class NSXTALBSeHbRecoveredEventDetailsType 
    {
        public NSXTALBSeHbRecoveredEventDetailsType()
        {
        }
        /// <summary>
        /// Heartbeat Request/Response received.
        /// </summary>
        [JsonProperty(PropertyName = "hb_type")]
        public int? HbType { get; set; }
        /// <summary>
        /// UUID of the remote SE with which dataplane heartbeat recovered. It is a reference to an object of type ServiceEngine.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "remote_se_ref")]
        public string? RemoteSeRef { get; set; }
        /// <summary>
        /// UUID of the SE reporting this event. It is a reference to an object of type ServiceEngine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reporting_se_ref")]
        public string? ReportingSeRef { get; set; }
        /// <summary>
        /// UUID of a VS which is placed on reporting-SE and remote-SE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
