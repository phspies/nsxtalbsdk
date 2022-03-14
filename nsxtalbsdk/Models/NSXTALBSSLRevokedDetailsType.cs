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
    public class NSXTALBSSLRevokedDetailsType 
    {
        public NSXTALBSSLRevokedDetailsType()
        {
        }
        /// <summary>
        /// Name of SSL Certificate. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Certificate revocation reason provided by OCSP Responder. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
    }
}
