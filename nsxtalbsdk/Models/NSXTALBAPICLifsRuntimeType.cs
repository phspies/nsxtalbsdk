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
    public class NSXTALBAPICLifsRuntimeType 
    {
        public NSXTALBAPICLifsRuntimeType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Placeholder for description of property auto_allocated of obj type APICLifsRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocated")]
        public bool? AutoAllocated { get; set; }
        /// <summary>
        /// Placeholder for description of property cifs of obj type APICLifsRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cifs")]
        public IList<NSXTALBCifType> Cifs { get; set; }
        /// <summary>
        /// Contract Graph associated with the VirtualService. Field introduced in 17.2.14,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "contract_graphs")]
        public IList<string> ContractGraphs { get; set; }
        /// <summary>
        /// lif_label of APICLifsRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "lif_label", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string LifLabel { get; set; }
        /// <summary>
        /// Placeholder for description of property multi_vrf of obj type APICLifsRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "multi_vrf")]
        public bool? MultiVrf { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// network of APICLifsRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public IList<string> SeUuid { get; set; }
        /// <summary>
        /// subnet of APICLifsRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string? Subnet { get; set; }
        /// <summary>
        /// tenant_name of APICLifsRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string TenantName { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Unique object identifier of transaction.
        /// </summary>
        [JsonProperty(PropertyName = "transaction_uuid")]
        public IList<string> TransactionUuid { get; set; }
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
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public IList<string> VsUuid { get; set; }
    }
}
