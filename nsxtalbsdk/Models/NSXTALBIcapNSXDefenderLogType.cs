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
    public class NSXTALBIcapNSXDefenderLogType 
    {
        /// <summary>
        /// Score associated with the uploaded file, if known, value is in between 0 and 100. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public int? Score { get; set; }
        /// <summary>
        /// URL to get details from NSXDefender for the request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "status_url")]
        public string? StatusUrl { get; set; }
        /// <summary>
        /// The NSX Defender task UUID associated with the analysis of the file. It is possible to use this UUID in order to access
        /// the analysis details from the NSX Defender Portal/Manager Web UI. URL to access this information is https
        /// //user.lastline.com/portal#/analyst/task/<uuid>/overview. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "task_uuid")]
        public string? TaskUuid { get; set; }
    }
}
