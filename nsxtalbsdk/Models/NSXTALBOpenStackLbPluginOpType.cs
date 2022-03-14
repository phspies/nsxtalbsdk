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
    public class NSXTALBOpenStackLbPluginOpType 
    {
        /// <summary>
        /// cc_id of OpenStackLbPluginOp.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// command of OpenStackLbPluginOp.
        /// </summary>
        [JsonProperty(PropertyName = "command", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Command { get; set; }
        /// <summary>
        /// detail of OpenStackLbPluginOp.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string? Detail { get; set; }
        /// <summary>
        /// Number of elapsed.
        /// </summary>
        [JsonProperty(PropertyName = "elapsed")]
        public int? Elapsed { get; set; }
        /// <summary>
        /// id of OpenStackLbPluginOp.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Id { get; set; }
        /// <summary>
        /// prov of OpenStackLbPluginOp.
        /// </summary>
        [JsonProperty(PropertyName = "prov", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Prov { get; set; }
        /// <summary>
        /// result of OpenStackLbPluginOp.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string? Result { get; set; }
    }
}
