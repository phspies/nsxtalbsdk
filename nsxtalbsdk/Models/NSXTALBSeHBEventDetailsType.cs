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
    public class NSXTALBSeHBEventDetailsType 
    {
        public NSXTALBSeHBEventDetailsType()
        {
        }
        /// <summary>
        /// HB Request/Response not received.
        /// </summary>
        [JsonProperty(PropertyName = "hb_type")]
        public int? HbType { get; set; }
        /// <summary>
        /// UUID of the SE with which Heartbeat failed. It is a reference to an object of type ServiceEngine. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "remote_se_ref")]
        public string? RemoteSeRef { get; set; }
        /// <summary>
        /// UUID of the SE reporting this event. It is a reference to an object of type ServiceEngine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reporting_se_ref")]
        public string? ReportingSeRef { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine. Field deprecated in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref1")]
        public string? SeRef1 { get; set; }
        /// <summary>
        /// UUID of a SE in the SE-Group which failed to respond. It is a reference to an object of type ServiceEngine. Field
        /// deprecated in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref2")]
        public string? SeRef2 { get; set; }
        /// <summary>
        /// UUID of the virtual service which is placed on reporting-SE and remote-SE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
