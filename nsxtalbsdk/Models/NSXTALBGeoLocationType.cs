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
    public class NSXTALBGeoLocationType 
    {
        /// <summary>
        /// Latitude of the location. This is represented as degrees.minutes. The range is from -90.0 (south) to +90.0 (north).
        /// Allowed values are -90.0-+90.0. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }
        /// <summary>
        /// Longitude of the location. This is represented as degrees.minutes. The range is from -180.0 (west) to +180.0 (east).
        /// Allowed values are -180.0-+180.0. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }
        /// <summary>
        /// Location name in the format Country/State/City. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Location tag string - example  USEast. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
    }
}
