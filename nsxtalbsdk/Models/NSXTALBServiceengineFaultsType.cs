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
    public class NSXTALBServiceengineFaultsType 
    {
        /// <summary>
        /// Enable debug faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "debug_faults")]
        public bool? DebugFaults { get; set; }
    }
}
