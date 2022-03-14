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
    public class NSXTALBNsxtSetupType 
    {
        public NSXTALBNsxtSetupType()
        {
        }
        /// <summary>
        /// cc_id of NsxtSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// reason of NsxtSetup.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// status of NsxtSetup.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// transportzone_id of NsxtSetup.
        /// </summary>
        [JsonProperty(PropertyName = "transportzone_id")]
        public string? TransportzoneId { get; set; }
    }
}
