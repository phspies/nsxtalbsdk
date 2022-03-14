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
    public class NSXTALBDnsSrvRdataType 
    {
        public NSXTALBDnsSrvRdataType()
        {
        }
        /// <summary>
        /// Service port. Allowed values are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Port { get; set; }
        /// <summary>
        /// Priority of the target hosting the service, low value implies higher priority for this service record. Allowed values
        /// are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// Canonical hostname, of the machine hosting the service, with no trailing period. 'default.host' is valid but not
        /// 'default.host.'.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string? Target { get; set; }
        /// <summary>
        /// Relative weight for service records with same priority, high value implies higher preference for this service record.
        /// Allowed values are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }
    }
}
