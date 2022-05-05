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
    public class NSXTALBGslbObjType 
    {
        /// <summary>
        /// Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_geo_db_profile_uuid")]
        public string? GslbGeoDbProfileUuid { get; set; }
        /// <summary>
        /// Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_service_uuid")]
        public string? GslbServiceUuid { get; set; }
        /// <summary>
        /// Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_uuid")]
        public string? GslbUuid { get; set; }
    }
}
