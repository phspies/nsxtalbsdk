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
    public class NSXTALBAWSSetupType 
    {
        /// <summary>
        /// access_key_id of AWSSetup.
        /// </summary>
        [JsonProperty(PropertyName = "access_key_id")]
        public string? AccessKeyId { get; set; }
        /// <summary>
        /// cc_id of AWSSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of AWSSetup.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        public string? Privilege { get; set; }
        /// <summary>
        /// region of AWSSetup.
        /// </summary>
        [JsonProperty(PropertyName = "region", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Region { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vpc_id")]
        public string? VpcId { get; set; }
    }
}
