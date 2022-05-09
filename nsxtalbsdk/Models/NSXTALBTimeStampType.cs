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
    public class NSXTALBTimeStampType 
    {
        /// <summary>
        /// Number of secs.
        /// </summary>
        [JsonProperty(PropertyName = "secs")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Secs { get; set; }
        /// <summary>
        /// Number of usecs.
        /// </summary>
        [JsonProperty(PropertyName = "usecs")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Usecs { get; set; }
    }
}
