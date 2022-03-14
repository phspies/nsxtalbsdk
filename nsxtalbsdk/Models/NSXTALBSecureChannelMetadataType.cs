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
    public class NSXTALBSecureChannelMetadataType 
    {
        /// <summary>
        /// key of SecureChannelMetadata.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// val of SecureChannelMetadata.
        /// </summary>
        [JsonProperty(PropertyName = "val")]
        public string? Val { get; set; }
    }
}
