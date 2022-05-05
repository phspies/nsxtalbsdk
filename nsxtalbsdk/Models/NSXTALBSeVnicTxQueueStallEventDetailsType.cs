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
    public class NSXTALBSeVnicTxQueueStallEventDetailsType 
    {
        /// <summary>
        /// Vnic name.
        /// </summary>
        [JsonProperty(PropertyName = "if_name")]
        public string? IfName { get; set; }
        /// <summary>
        /// Vnic Linux name.
        /// </summary>
        [JsonProperty(PropertyName = "linux_name")]
        public string? LinuxName { get; set; }
        /// <summary>
        /// Queue number.
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public int? Queue { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
    }
}
