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
    public class NSXTALBPrimaryPoolType 
    {
        /// <summary>
        /// Pool's ID. Field introduced in 20.1.7, 21.1.2, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolUuid { get; set; }
    }
}
