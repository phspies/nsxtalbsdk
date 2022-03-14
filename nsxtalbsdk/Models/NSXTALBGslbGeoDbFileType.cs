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
    public class NSXTALBGslbGeoDbFileType 
    {
        public NSXTALBGslbGeoDbFileType()
        {
        }
        /// <summary>
        /// File checksum is internally computed. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        public string? Checksum { get; set; }
        /// <summary>
        /// System internal identifier for the file. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "file_id")]
        public string? FileId { get; set; }
        /// <summary>
        /// Geodb Filename in the Avi supported formats. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string? Filename { get; set; }
        /// <summary>
        /// This field indicates the file format. Enum options - GSLB_GEODB_FILE_FORMAT_AVI, GSLB_GEODB_FILE_FORMAT_MAXMIND_CITY,
        /// GSLB_GEODB_FILE_FORMAT_MAXMIND_CITY_V6, GSLB_GEODB_FILE_FORMAT_MAXMIND_CITY_V4_AND_V6, GSLB_GEODB_FILE_FORMAT_AVI_V6,
        /// GSLB_GEODB_FILE_FORMAT_AVI_V4_AND_V6. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string? Format { get; set; }
        /// <summary>
        /// Internal timestamp associated with the file. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
    }
}
