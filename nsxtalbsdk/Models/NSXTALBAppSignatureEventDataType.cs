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
    public class NSXTALBAppSignatureEventDataType 
    {
        public NSXTALBAppSignatureEventDataType()
        {
        }
        /// <summary>
        /// Last Successful updated time of the AppSignature. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "last_successful_updated_time")]
        public string? LastSuccessfulUpdatedTime { get; set; }
        /// <summary>
        /// Reason for AppSignature transaction failure. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Status of AppSignature transaction. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
    }
}
