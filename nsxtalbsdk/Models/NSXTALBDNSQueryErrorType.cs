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
    public class NSXTALBDNSQueryErrorType 
    {
        public NSXTALBDNSQueryErrorType()
        {
        }
        /// <summary>
        /// error of DNSQueryError.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// error_message of DNSQueryError.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// fqdn of DNSQueryError.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
    }
}
