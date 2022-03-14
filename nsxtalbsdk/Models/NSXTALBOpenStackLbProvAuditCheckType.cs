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
    public class NSXTALBOpenStackLbProvAuditCheckType 
    {
        public NSXTALBOpenStackLbProvAuditCheckType()
        {
        }
        /// <summary>
        /// cc_id of OpenStackLbProvAuditCheck.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// detail of OpenStackLbProvAuditCheck.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string? Detail { get; set; }
        /// <summary>
        /// Number of elapsed.
        /// </summary>
        [JsonProperty(PropertyName = "elapsed")]
        public int? Elapsed { get; set; }
        /// <summary>
        /// id of OpenStackLbProvAuditCheck.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Id { get; set; }
        /// <summary>
        /// result of OpenStackLbProvAuditCheck.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string? Result { get; set; }
        /// <summary>
        /// tenant of OpenStackLbProvAuditCheck.
        /// </summary>
        [JsonProperty(PropertyName = "tenant", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Tenant { get; set; }
        /// <summary>
        /// user of OpenStackLbProvAuditCheck.
        /// </summary>
        [JsonProperty(PropertyName = "user", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string User { get; set; }
    }
}
