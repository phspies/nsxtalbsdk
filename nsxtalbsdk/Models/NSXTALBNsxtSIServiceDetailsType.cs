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
    public class NSXTALBNsxtSIServiceDetailsType 
    {
        /// <summary>
        /// Error message. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// NSX-T ServiceInsertion service name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string? Service { get; set; }
    }
}
