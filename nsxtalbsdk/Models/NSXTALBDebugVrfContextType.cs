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
    public class NSXTALBDebugVrfContextType 
    {
        /// <summary>
        /// Vrf config command buffer process interval. Allowed values are 1-4. Field introduced in 17.2.13,18.1.5,18.2.1. Unit is
        /// SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "command_buffer_interval")]
        public int? CommandBufferInterval { get; set; }
        /// <summary>
        /// Vrf config command buffer size. Allowed values are 1-32768. Field introduced in 17.2.13,18.1.5,18.2.1. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "command_buffer_size")]
        public int? CommandBufferSize { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public IList<NSXTALBDebugVrfType> Flags { get; set; }
    }
}
