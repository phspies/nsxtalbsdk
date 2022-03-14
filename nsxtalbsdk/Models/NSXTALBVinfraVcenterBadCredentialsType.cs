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
    public class NSXTALBVinfraVcenterBadCredentialsType 
    {
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Number of previous_count.
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }
        /// <summary>
        /// user of VinfraVcenterBadCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
        /// <summary>
        /// vcenter of VinfraVcenterBadCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
        /// <summary>
        /// vcenter_name of VinfraVcenterBadCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_name")]
        public string? VcenterName { get; set; }
        /// <summary>
        /// vcenter_object of VinfraVcenterBadCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_object")]
        public string? VcenterObject { get; set; }
    }
}
