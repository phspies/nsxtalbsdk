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
    public class NSXTALBHealthMonitorSmtpType 
    {
        /// <summary>
        /// Sender domain name. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "domainname")]
        public string? Domainname { get; set; }
        /// <summary>
        /// Mail data. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mail_data")]
        public string? MailData { get; set; }
        /// <summary>
        /// Mail recipients. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "recipients_ids")]
        public IList<string> RecipientsIds { get; set; }
        /// <summary>
        /// Mail sender. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sender_id")]
        public string? SenderId { get; set; }
        /// <summary>
        /// SSL attributes for SMTPS monitor. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}
