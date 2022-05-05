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
    public class NSXTALBSysTestEmailParamsType 
    {
        /// <summary>
        /// Alerts are copied to the comma separated list of  email recipients.
        /// </summary>
        [JsonProperty(PropertyName = "cc_emails")]
        public string? CcEmails { get; set; }
        /// <summary>
        /// The Subject line of the originating email from  Avi Controller.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Subject { get; set; }
        /// <summary>
        /// The email context.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Text { get; set; }
        /// <summary>
        /// Alerts are sent to the comma separated list of  email recipients.
        /// </summary>
        [JsonProperty(PropertyName = "to_emails")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ToEmails { get; set; }
    }
}
