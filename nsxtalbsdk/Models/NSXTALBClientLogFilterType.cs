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
    public class NSXTALBClientLogFilterType 
    {
        /// <summary>
        /// Placeholder for description of property all_headers of obj type ClientLogFilter field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// Placeholder for description of property client_ip of obj type ClientLogFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Special values are 0 - infinite. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Placeholder for description of property enabled of obj type ClientLogFilter field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property uri of obj type ClientLogFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public NSXTALBStringMatchType Uri { get; set; }
    }
}
