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
    public class NSXTALBVinfraVcenterDiscoveryFailureType 
    {
        public NSXTALBVinfraVcenterDiscoveryFailureType()
        {
        }
        /// <summary>
        /// state of VinfraVcenterDiscoveryFailure.
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string State { get; set; }
        /// <summary>
        /// vcenter of VinfraVcenterDiscoveryFailure.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
