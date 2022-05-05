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
    public class NSXTALBAzureMarketplaceType 
    {
        /// <summary>
        /// Azure Cloud id. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Avi azure marketplace offer name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string? Offer { get; set; }
        /// <summary>
        /// Avi azure marketplace publisher name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string? Publisher { get; set; }
        /// <summary>
        /// Azure marketplace license term failure status. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Azure resource group name. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "resource_group")]
        public string? ResourceGroup { get; set; }
        /// <summary>
        /// Avi azure marketplace skus list. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "skus")]
        public IList<string> Skus { get; set; }
        /// <summary>
        /// Azure marketplace license term acceptance status. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// Azure Subscription id. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "subscription_id")]
        public string? SubscriptionId { get; set; }
        /// <summary>
        /// Azure Vnet id. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "vnet_id")]
        public string? VnetId { get; set; }
    }
}
