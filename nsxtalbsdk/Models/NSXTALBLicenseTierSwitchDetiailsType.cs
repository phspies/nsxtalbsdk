using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBLicenseTierSwitchDetiailsType
    {
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
