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
    public class NSXTALBVinfraVmDetailsType 
    {
        public NSXTALBVinfraVmDetailsType()
        {
        }
        /// <summary>
        /// datacenter of VinfraVmDetails.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter")]
        public string? Datacenter { get; set; }
        /// <summary>
        /// host of VinfraVmDetails.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
