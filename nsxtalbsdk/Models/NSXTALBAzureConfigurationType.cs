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
    public class NSXTALBAzureConfigurationType 
    {
        public NSXTALBAzureConfigurationType()
        {
        }
        /// <summary>
        /// Availability zones to be used in Azure. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zones")]
        public IList<string> AvailabilityZones { get; set; }
        /// <summary>
        /// Credentials to access azure cloud. It is a reference to an object of type CloudConnectorUser. Field introduced in
        /// 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_credentials_ref")]
        public string? CloudCredentialsRef { get; set; }
        /// <summary>
        /// Disks Encryption Set resource-id (des_id) to encrypt se image and managed disk using customer-managed-keys. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "des_id")]
        public string? DesId { get; set; }
        /// <summary>
        /// Azure location where this cloud will be located. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string? Location { get; set; }
        /// <summary>
        /// Azure virtual network and subnet information. Field introduced in 17.2.1. Minimum of 1 items required. Maximum of 1
        /// items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "network_info")]
        public IList<NSXTALBAzureNetworkInfoType> NetworkInfo { get; set; }
        /// <summary>
        /// Azure resource group dedicated for Avi Controller. Avi Controller will create all its resources in this resource group.
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "resource_group")]
        public string? ResourceGroup { get; set; }
        /// <summary>
        /// Subscription Id for the Azure subscription. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "subscription_id")]
        public string? SubscriptionId { get; set; }
        /// <summary>
        /// Azure is the DNS provider. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_azure_dns")]
        public bool? UseAzureDns { get; set; }
        /// <summary>
        /// Use Azure's enhanced HA features. This needs a public IP to be associated with the VIP. . Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_enhanced_ha")]
        public bool? UseEnhancedHa { get; set; }
        /// <summary>
        /// Use Azure managed disks for SE storage. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "use_managed_disks")]
        public bool? UseManagedDisks { get; set; }
        /// <summary>
        /// Use Standard SKU Azure Load Balancer. By default Basic SKU Load Balancer is used. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "use_standard_alb")]
        public bool? UseStandardAlb { get; set; }
    }
}
