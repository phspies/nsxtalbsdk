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
    public class NSXTALBMarathonServicePortConflictType 
    {
        public NSXTALBMarathonServicePortConflictType()
        {
        }
        /// <summary>
        /// app_name of MarathonServicePortConflict.
        /// </summary>
        [JsonProperty(PropertyName = "app_name")]
        public string? AppName { get; set; }
        /// <summary>
        /// cc_id of MarathonServicePortConflict.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// marathon_url of MarathonServicePortConflict.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_url", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MarathonUrl { get; set; }
        /// <summary>
        /// Number of port.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Port { get; set; }
    }
}
