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
    public class NSXTALBSamlServiceProviderSettingsType 
    {
        /// <summary>
        /// FQDN if entity type is DNS_FQDN . Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Service Provider Organization Display Name. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "org_display_name")]
        public string? OrgDisplayName { get; set; }
        /// <summary>
        /// Service Provider Organization Name. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "org_name")]
        public string? OrgName { get; set; }
        /// <summary>
        /// Service Provider Organization URL. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "org_url")]
        public string? OrgUrl { get; set; }
        /// <summary>
        /// Type of SAML endpoint. Enum options - AUTH_SAML_CLUSTER_VIP, AUTH_SAML_DNS_FQDN, AUTH_SAML_APP_VS. Field introduced in
        /// 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "saml_entity_type")]
        public string? SamlEntityType { get; set; }
        /// <summary>
        /// Service Provider node information. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sp_nodes")]
        public IList<NSXTALBSamlServiceProviderNodeType> SpNodes { get; set; }
        /// <summary>
        /// Service Provider technical contact email. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "tech_contact_email")]
        public string? TechContactEmail { get; set; }
        /// <summary>
        /// Service Provider technical contact name. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "tech_contact_name")]
        public string? TechContactName { get; set; }
    }
}
