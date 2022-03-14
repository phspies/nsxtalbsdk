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
    public class NSXTALBAPICConfigurationType 
    {
        /// <summary>
        /// Name of the Avi specific tenant created within APIC. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_admin_tenant")]
        public string? ApicAdminTenant { get; set; }
        /// <summary>
        /// vCenter's virtual machine manager domain within APIC. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_domain")]
        public string? ApicDomain { get; set; }
        /// <summary>
        /// The hostname or IP address of the APIC controller. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_name")]
        public IList<string> ApicName { get; set; }
        /// <summary>
        /// The password Avi Vantage will use when authenticating with APIC. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_password")]
        public string? ApicPassword { get; set; }
        /// <summary>
        /// Field deprecated in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "apic_product")]
        public string? ApicProduct { get; set; }
        /// <summary>
        /// The username Avi Vantage will use when authenticating with APIC. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_username")]
        public string? ApicUsername { get; set; }
        /// <summary>
        /// Field deprecated in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "apic_vendor")]
        public string? ApicVendor { get; set; }
        /// <summary>
        /// The password APIC will use when authenticating with Avi Vantage. Field deprecated in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avi_controller_password")]
        public string? AviControllerPassword { get; set; }
        /// <summary>
        /// The username APIC will use when authenticating with Avi Vantage. Field deprecated in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avi_controller_username")]
        public string? AviControllerUsername { get; set; }
        /// <summary>
        /// Context aware for supporting Service Graphs across VRFs. Enum options - SINGLE_CONTEXT, MULTI_CONTEXT. Field deprecated
        /// in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "context_aware")]
        public string? ContextAware { get; set; }
        /// <summary>
        /// Field deprecated in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "deployment")]
        public string? Deployment { get; set; }
        /// <summary>
        /// Use Managed Mode for APIC Service Insertion. Field deprecated in 17.2.10,18.1.2. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "managed_mode")]
        public bool? ManagedMode { get; set; }
        /// <summary>
        /// AVI Device Package Minor Version. Field deprecated in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "minor")]
        public string? Minor { get; set; }
        /// <summary>
        /// Determines if DSR from secondary SE is active or not  False   DSR active. Please ensure that APIC BD's Endpoint
        /// Dataplane Learning is disabled True    Disable DSR unconditionally. . Field deprecated in 21.1.1. Field introduced in
        /// 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_tunnel_mode")]
        public bool? SeTunnelMode { get; set; }
        /// <summary>
        /// AVI Device Package Version. Field deprecated in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
