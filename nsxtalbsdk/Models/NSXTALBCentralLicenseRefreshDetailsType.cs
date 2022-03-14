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
    public class NSXTALBCentralLicenseRefreshDetailsType 
    {
        public NSXTALBCentralLicenseRefreshDetailsType()
        {
        }
        /// <summary>
        /// Message. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Service units. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "service_units")]
        public double? ServiceUnits { get; set; }
    }
}
