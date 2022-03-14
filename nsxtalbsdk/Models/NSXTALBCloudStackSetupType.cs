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
    public class NSXTALBCloudStackSetupType 
    {
        public NSXTALBCloudStackSetupType()
        {
        }
        /// <summary>
        /// access_key_id of CloudStackSetup.
        /// </summary>
        [JsonProperty(PropertyName = "access_key_id")]
        public string? AccessKeyId { get; set; }
        /// <summary>
        /// api_url of CloudStackSetup.
        /// </summary>
        [JsonProperty(PropertyName = "api_url")]
        public string? ApiUrl { get; set; }
        /// <summary>
        /// cc_id of CloudStackSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of CloudStackSetup.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        public string? Privilege { get; set; }
    }
}
