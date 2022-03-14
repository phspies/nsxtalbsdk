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
    public class NSXTALBACSubjectInfoType 
    {
        /// <summary>
        /// Subject type for the audit event (e.g. DNS Hostname, IP address, URI). Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// Subject value for the audit event (e.g. www.example.com, 10.10.10.10, www.foo.com/index.html). Field introduced in
        /// 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    }
}
