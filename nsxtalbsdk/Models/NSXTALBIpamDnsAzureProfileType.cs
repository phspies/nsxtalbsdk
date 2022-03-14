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
    public class NSXTALBIpamDnsAzureProfileType 
    {
        public NSXTALBIpamDnsAzureProfileType()
        {
        }
        /// <summary>
        /// Service principal based credentials for azure. Only one of azure_userpass or azure_serviceprincipal is allowed. Field
        /// introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "azure_serviceprincipal")]
        public NSXTALBAzureServicePrincipalCredentialsType AzureServiceprincipal { get; set; }
        /// <summary>
        /// User name password based credentials for azure. Only one of azure_userpass or azure_serviceprincipal is allowed. Field
        /// introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "azure_userpass")]
        public NSXTALBAzureUserPassCredentialsType AzureUserpass { get; set; }
        /// <summary>
        /// Used for allocating egress service source IPs. Field introduced in 17.2.8. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "egress_service_subnets")]
        public IList<string> EgressServiceSubnets { get; set; }
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
        /// Usable domains to pick from Azure DNS. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "usable_domains")]
        public IList<string> UsableDomains { get; set; }
        /// <summary>
        /// Usable networks for Virtual IP. If VirtualService does not specify a network and auto_allocate_ip is set, then the first
        /// available network from this list will be chosen for IP allocation. Field introduced in 17.2.1. Maximum of 128 items
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "usable_network_uuids")]
        public IList<string> UsableNetworkUuids { get; set; }
        /// <summary>
        /// Use Azure's enhanced HA features. This needs a public IP to be associated with the VIP. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_enhanced_ha")]
        public bool? UseEnhancedHa { get; set; }
        /// <summary>
        /// Use Standard SKU Azure Load Balancer. By default Basic SKU Load Balancer is used. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "use_standard_alb")]
        public bool? UseStandardAlb { get; set; }
        /// <summary>
        /// Virtual networks where Virtual IPs will belong. Field introduced in 17.2.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_network_ids")]
        public IList<string> VirtualNetworkIds { get; set; }
    }
}
