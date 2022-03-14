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
    public class NSXTALBCloudConnectorUserType 
    {
        public NSXTALBCloudConnectorUserType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "azure_serviceprincipal")]
        public NSXTALBAzureServicePrincipalCredentialsType AzureServiceprincipal { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "azure_userpass")]
        public NSXTALBAzureUserPassCredentialsType AzureUserpass { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Credentials for Google Cloud Platform. Field introduced in 18.2.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "gcp_credentials")]
        public NSXTALBGCPCredentialsType GcpCredentials { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Credentials to talk to NSX-T manager. Field introduced in 20.1.1. Allowed in Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_credentials")]
        public NSXTALBNsxtCredentialsType NsxtCredentials { get; set; }
        /// <summary>
        /// Credentials for Oracle Cloud Infrastructure. Field introduced in 18.2.1,18.1.3. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "oci_credentials")]
        public NSXTALBOCICredentialsType OciCredentials { get; set; }
        /// <summary>
        /// password of CloudConnectorUser.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// private_key of CloudConnectorUser.
        /// </summary>
        [JsonProperty(PropertyName = "private_key")]
        public string? PrivateKey { get; set; }
        /// <summary>
        /// public_key of CloudConnectorUser.
        /// </summary>
        [JsonProperty(PropertyName = "public_key")]
        public string? PublicKey { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Credentials for Tencent Cloud. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "tencent_credentials")]
        public NSXTALBTencentCredentialsType TencentCredentials { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Credentials to talk to VCenter. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_credentials")]
        public NSXTALBVCenterCredentialsType VcenterCredentials { get; set; }
    }
}
