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
    public class NSXTALBDebugVrfType 
    {
        /// <summary>
        /// Enum options - DEBUG_VRF_BGP, DEBUG_VRF_QUAGGA, DEBUG_VRF_ALL, DEBUG_VRF_NONE. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "flag", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Flag { get; set; }
    }
}
