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
    public class NSXTALBTLSTicketType 
    {
        public NSXTALBTLSTicketType()
        {
        }
        /// <summary>
        /// aes_key of TLSTicket.
        /// </summary>
        [JsonProperty(PropertyName = "aes_key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AesKey { get; set; }
        /// <summary>
        /// hmac_key of TLSTicket.
        /// </summary>
        [JsonProperty(PropertyName = "hmac_key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string HmacKey { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
