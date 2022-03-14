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
    public class NSXTALBDNSConfigType 
    {
        public NSXTALBDNSConfigType()
        {
        }
        /// <summary>
        /// GSLB subdomain used for GSLB service FQDN match and placement. .
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string DomainName { get; set; }
    }
}
