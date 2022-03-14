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
    public class NSXTALBJWTValidationParamsType 
    {
        /// <summary>
        /// Audience parameter used for validation using JWT token. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "audience", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Audience { get; set; }
    }
}
