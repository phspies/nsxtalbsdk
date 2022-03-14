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
    public class NSXTALBControllerSizeType 
    {
        /// <summary>
        /// Controller flavor (E/S/M/L) for this controller size. Enum options - CONTROLLER_ESSENTIALS, CONTROLLER_SMALL,
        /// CONTROLLER_MEDIUM, CONTROLLER_LARGE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "flavor")]
        public string? Flavor { get; set; }
        /// <summary>
        /// Minimum number of cpu cores required. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "min_cpus")]
        public int? MinCpus { get; set; }
        /// <summary>
        /// Minimum memory required. Field introduced in 20.1.1. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "min_memory")]
        public int? MinMemory { get; set; }
    }
}
