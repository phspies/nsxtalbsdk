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
    public class NSXTALBAlertTestEmailParamsType 
    {
        /// <summary>
        /// The Subject line of the originating email from  Avi Controller.
        /// </summary>
        [JsonProperty(PropertyName = "subject", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Subject { get; set; }
        /// <summary>
        /// The email context.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Text { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
