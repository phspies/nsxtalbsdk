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
    public class NSXTALBTenantLabelType 
    {
        /// <summary>
        /// Label key string. Field introduced in 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// Label value string. Field introduced in 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
