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
    public class NSXTALBSeVsFaultEventDetailsType 
    {
        /// <summary>
        /// Name of the object responsible for the fault.
        /// </summary>
        [JsonProperty(PropertyName = "fault_object")]
        public string? FaultObject { get; set; }
        /// <summary>
        /// Reason for the fault.
        /// </summary>
        [JsonProperty(PropertyName = "fault_reason")]
        public string? FaultReason { get; set; }
        /// <summary>
        /// SE uuid. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "service_engine")]
        public string? ServiceEngine { get; set; }
        /// <summary>
        /// VS name. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_service")]
        public string? VirtualService { get; set; }
    }
}
