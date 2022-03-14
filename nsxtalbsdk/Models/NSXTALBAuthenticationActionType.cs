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
    public class NSXTALBAuthenticationActionType 
    {
        public NSXTALBAuthenticationActionType()
        {
        }
        /// <summary>
        /// Authentication Action to be taken for a matched Rule. Enum options - SKIP_AUTHENTICATION, USE_DEFAULT_AUTHENTICATION.
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
