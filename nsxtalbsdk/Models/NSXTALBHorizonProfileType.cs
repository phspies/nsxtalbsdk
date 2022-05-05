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
    public class NSXTALBHorizonProfileType 
    {
        /// <summary>
        /// Horizon blast port of the UAG server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "blast_port")]
        public int? BlastPort { get; set; }
        /// <summary>
        /// Horizon pcoip port of the UAG server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pcoip_port")]
        public int? PcoipPort { get; set; }
    }
}
