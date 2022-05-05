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
    public class NSXTALBIcapNsxDefenderConfigType 
    {
        /// <summary>
        /// URL to get details from NSXDefender using task_uuid for a particular request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "status_url")]
        public string? StatusUrl { get; set; }
    }
}
