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
    public class NSXTALBCRSDetailsType 
    {
        public NSXTALBCRSDetailsType()
        {
        }
        /// <summary>
        /// Name of the CRS release. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// CRS release date. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "release_date")]
        public string? ReleaseDate { get; set; }
        /// <summary>
        /// Download link of the CRS release. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Version of the CRS release. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
