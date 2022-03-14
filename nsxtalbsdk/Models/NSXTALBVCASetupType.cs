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
    public class NSXTALBVCASetupType 
    {
        public NSXTALBVCASetupType()
        {
        }
        /// <summary>
        /// cc_id of VCASetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of VCASetup.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// instance of VCASetup.
        /// </summary>
        [JsonProperty(PropertyName = "instance", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Instance { get; set; }
        /// <summary>
        /// Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        public string? Privilege { get; set; }
        /// <summary>
        /// username of VCASetup.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
