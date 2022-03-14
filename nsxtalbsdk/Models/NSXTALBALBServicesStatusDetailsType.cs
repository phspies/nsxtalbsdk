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
    public class NSXTALBALBServicesStatusDetailsType 
    {
        public NSXTALBALBServicesStatusDetailsType()
        {
        }
        /// <summary>
        /// Connection status of the controller cluster to ALBServices. Enum options - ALBSERVICES_CONNECTIVITY_UNKNOWN,
        /// ALBSERVICES_DISCONNECTED, ALBSERVICES_CONNECTED. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity")]
        public string? Connectivity { get; set; }
        /// <summary>
        /// Status change reason. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Registration status of the controller cluster to ALBServices. Enum options - ALBSERVICES_REGISTRATION_UNKNOWN,
        /// ALBSERVICES_REGISTERED, ALBSERVICES_DEREGISTERED. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "registration")]
        public string? Registration { get; set; }
    }
}
