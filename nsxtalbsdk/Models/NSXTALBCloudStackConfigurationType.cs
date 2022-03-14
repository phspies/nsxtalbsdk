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
    public class NSXTALBCloudStackConfigurationType 
    {
        /// <summary>
        /// CloudStack API Key.
        /// </summary>
        [JsonProperty(PropertyName = "access_key_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AccessKeyId { get; set; }
        /// <summary>
        /// CloudStack API URL.
        /// </summary>
        [JsonProperty(PropertyName = "api_url", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ApiUrl { get; set; }
        /// <summary>
        /// If controller's management IP is in a private network, a publicly accessible IP to reach the controller.
        /// </summary>
        [JsonProperty(PropertyName = "cntr_public_ip")]
        public string? CntrPublicIp { get; set; }
        /// <summary>
        /// Default hypervisor type. Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor")]
        public string? Hypervisor { get; set; }
        /// <summary>
        /// Avi Management network name.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_network_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MgmtNetworkName { get; set; }
        /// <summary>
        /// Avi Management network name.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_network_uuid")]
        public string? MgmtNetworkUuid { get; set; }
        /// <summary>
        /// CloudStack Secret Key.
        /// </summary>
        [JsonProperty(PropertyName = "secret_access_key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SecretAccessKey { get; set; }
    }
}
