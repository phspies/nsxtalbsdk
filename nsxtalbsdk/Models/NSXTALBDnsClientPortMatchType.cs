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
    public class NSXTALBDnsClientPortMatchType 
    {
        /// <summary>
        /// Port number to match against client port number in request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_ports", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBPortMatchGenericType ClientPorts { get; set; }
    }
}
