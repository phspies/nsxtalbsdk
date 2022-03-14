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
    public class NSXTALBVirtualServiceResourceType 
    {
        /// <summary>
        /// This field is not being used. Field deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_exclusive")]
        public bool? IsExclusive { get; set; }
        /// <summary>
        /// Number of memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public int? Memory { get; set; }
        /// <summary>
        /// Number of num_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_se")]
        public int? NumSe { get; set; }
        /// <summary>
        /// Number of num_standby_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_standby_se")]
        public int? NumStandbySe { get; set; }
        /// <summary>
        /// Number of num_vcpus.
        /// </summary>
        [JsonProperty(PropertyName = "num_vcpus")]
        public int? NumVcpus { get; set; }
        /// <summary>
        /// Indicates if the primary SE is being scaled in. This state is now derived from the Virtual Service runtime. Field
        /// deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "scalein_primary")]
        public bool? ScaleinPrimary { get; set; }
        /// <summary>
        /// Indicates which SE is being scaled in. This information is now derived from the Virtual Service runtime. Field
        /// deprecated in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "scalein_se_uuid")]
        public string? ScaleinSeUuid { get; set; }
    }
}
