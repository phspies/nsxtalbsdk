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
    public class NSXTALBAzureClusterInfoType 
    {
        /// <summary>
        /// It is a reference to an object of type CloudConnectorUser. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_credential_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CloudCredentialRef { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "subscription_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SubscriptionId { get; set; }
    }
}
