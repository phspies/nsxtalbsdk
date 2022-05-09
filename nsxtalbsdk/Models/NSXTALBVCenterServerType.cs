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
    public class NSXTALBVCenterServerType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// VCenter belongs to cloud. It is a reference to an object of type Cloud. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// VCenter template to create Service Engine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "content_lib")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBContentLibConfigType ContentLib { get; set; }
        /// <summary>
        /// Availabilty zone where VCenter list belongs to. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// VCenter belongs to tenant. It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// VCenter config UUID. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Credentials to access VCenter. It is a reference to an object of type CloudConnectorUser. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_credentials_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcenterCredentialsRef { get; set; }
        /// <summary>
        /// VCenter hostname or IP address. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcenterUrl { get; set; }
    }
}
