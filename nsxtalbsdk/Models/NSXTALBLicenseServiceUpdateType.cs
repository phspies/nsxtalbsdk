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
    public class NSXTALBLicenseServiceUpdateType 
    {
        /// <summary>
        /// Name. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Organization id. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "service_units")]
        public NSXTALBOrgServiceUnitsType ServiceUnits { get; set; }
    }
}
