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
    public class NSXTALBGslbGeoDbEntryType 
    {
        /// <summary>
        /// This field describes the GeoDb file. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "file", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBGslbGeoDbFileType File { get; set; }
        /// <summary>
        /// Priority of this geodb entry. This value should be unique in a repeated list of geodb entries.  Higher the value, then
        /// greater is the priority.  . Allowed values are 1-100. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
    }
}
