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
    public class NSXTALBLicenseTierSwitchDetiailsType 
    {
        public NSXTALBLicenseTierSwitchDetiailsType()
        {
        }
        /// <summary>
        /// destination_tier of LicenseTierSwitchDetiails.
        /// </summary>
        [JsonProperty(PropertyName = "destination_tier")]
        public string? DestinationTier { get; set; }
        /// <summary>
        /// reason of LicenseTierSwitchDetiails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// source_tier of LicenseTierSwitchDetiails.
        /// </summary>
        [JsonProperty(PropertyName = "source_tier")]
        public string? SourceTier { get; set; }
        /// <summary>
        /// status of LicenseTierSwitchDetiails.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
    }
}
