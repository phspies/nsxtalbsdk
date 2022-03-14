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
    public class NSXTALBSeIpfailureEventDetailsType 
    {
        public NSXTALBSeIpfailureEventDetailsType()
        {
        }
        /// <summary>
        /// Mac Address.
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// Network UUID.
        /// </summary>
        [JsonProperty(PropertyName = "network_uuid")]
        public string? NetworkUuid { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
        /// <summary>
        /// Vnic name.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_name")]
        public string? VnicName { get; set; }
    }
}
