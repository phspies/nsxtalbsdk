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
    public class NSXTALBDebugDnsOptionsType 
    {
        /// <summary>
        /// This field filters the FQDN for Dns debug. Field introduced in 18.2.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        public IList<string> DomainName { get; set; }
        /// <summary>
        /// This field filters the Gslb service for Dns debug. Field introduced in 18.2.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_service_name")]
        public IList<string> GslbServiceName { get; set; }
    }
}
