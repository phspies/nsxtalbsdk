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
    public class NSXTALBSSLRenewDetailsType 
    {
        public NSXTALBSSLRenewDetailsType()
        {
        }
        /// <summary>
        /// Name of SSL Certificate.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
