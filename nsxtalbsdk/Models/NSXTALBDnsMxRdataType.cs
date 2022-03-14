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
    public class NSXTALBDnsMxRdataType 
    {
        public NSXTALBDnsMxRdataType()
        {
        }
        /// <summary>
        /// Fully qualified domain name of a mailserver . The host name maps directly to one or more address records in the DNS
        /// table, and must not point to any CNAME records (RFC 2181). Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Host { get; set; }
        /// <summary>
        /// The priority field identifies which mail server should be preferred. Allowed values are 0-65535. Field introduced in
        /// 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Priority { get; set; }
    }
}
