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
    public class NSXTALBAzureSetupType 
    {
        public NSXTALBAzureSetupType()
        {
        }
        /// <summary>
        /// alb_id of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "alb_id")]
        public string? AlbId { get; set; }
        /// <summary>
        /// cc_id of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// nic_id of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "nic_id")]
        public string? NicId { get; set; }
        /// <summary>
        /// reason of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// resource_group of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "resource_group")]
        public string? ResourceGroup { get; set; }
        /// <summary>
        /// status of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// subscription_id of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "subscription_id")]
        public string? SubscriptionId { get; set; }
        /// <summary>
        /// Placeholder for description of property vips of obj type AzureSetup field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vips")]
        public IList<NSXTALBIpAddrType> Vips { get; set; }
        /// <summary>
        /// vnet_id of AzureSetup.
        /// </summary>
        [JsonProperty(PropertyName = "vnet_id")]
        public string? VnetId { get; set; }
        /// <summary>
        /// Unique object identifiers of vss.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuids")]
        public IList<string> VsUuids { get; set; }
    }
}
