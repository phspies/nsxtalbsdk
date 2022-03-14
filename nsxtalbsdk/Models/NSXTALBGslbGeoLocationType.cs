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
    public class NSXTALBGslbGeoLocationType 
    {
        public NSXTALBGslbGeoLocationType()
        {
        }
        /// <summary>
        /// Geographic location of the site. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGeoLocationType Location { get; set; }
        /// <summary>
        /// This field describes the source of the GeoLocation. . Enum options - GSLB_LOCATION_SRC_USER_CONFIGURED,
        /// GSLB_LOCATION_SRC_INHERIT_FROM_SITE, GSLB_LOCATION_SRC_FROM_GEODB. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Source { get; set; }
    }
}
