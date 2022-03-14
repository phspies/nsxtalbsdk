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
    public class NSXTALBAWSASGDeleteType 
    {
        public NSXTALBAWSASGDeleteType()
        {
        }
        /// <summary>
        /// List of Autoscale groups deleted from AWS. Field introduced in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "asgs")]
        public IList<string> Asgs { get; set; }
        /// <summary>
        /// UUID of the cloud. Field introduced in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// UUID of the Pool. Field introduced in 17.2.10,18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
    }
}
