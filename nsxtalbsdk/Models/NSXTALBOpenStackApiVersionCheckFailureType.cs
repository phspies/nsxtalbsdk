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
    public class NSXTALBOpenStackApiVersionCheckFailureType 
    {
        public NSXTALBOpenStackApiVersionCheckFailureType()
        {
        }
        /// <summary>
        /// Cloud UUID. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Cloud name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cc_name")]
        public string? CcName { get; set; }
        /// <summary>
        /// Failure reason containing expected API version and actual version. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
    }
}
