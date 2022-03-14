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
    public class NSXTALBCRSUpdateDetailsType 
    {
        /// <summary>
        /// List of all available CRS updates. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "crs_info")]
        public IList<NSXTALBCRSDetailsType> CrsInfo { get; set; }
    }
}
