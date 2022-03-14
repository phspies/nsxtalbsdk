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
    public class NSXTALBVsApicExtensionType 
    {
        public NSXTALBVsApicExtensionType()
        {
        }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "txn_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string TxnUuid { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vnic")]
        public IList<NSXTALBVsSeVnicType> Vnic { get; set; }
    }
}
