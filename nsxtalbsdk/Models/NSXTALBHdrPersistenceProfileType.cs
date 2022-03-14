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
    public class NSXTALBHdrPersistenceProfileType 
    {
        public NSXTALBHdrPersistenceProfileType()
        {
        }
        /// <summary>
        /// Header name for custom header persistence.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_name")]
        public string? PrstHdrName { get; set; }
    }
}
