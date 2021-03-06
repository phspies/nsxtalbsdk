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
    public class NSXTALBALBServicesCaseAttachmentType 
    {
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttachmentName { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_size")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttachmentSize { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_url")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttachmentUrl { get; set; }
    }
}
