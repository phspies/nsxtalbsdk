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
    public class NSXTALBGcpInfoType 
    {
        /// <summary>
        /// Hostname of this SE.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// Network this SE is assigned.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Network { get; set; }
        /// <summary>
        /// Project this SE belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Project { get; set; }
        /// <summary>
        /// Subnet assigned to this SE.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string? Subnet { get; set; }
        /// <summary>
        /// Zone this SE is part of.
        /// </summary>
        [JsonProperty(PropertyName = "zone")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Zone { get; set; }
    }
}
