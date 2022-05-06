using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNsxtSetupType
    {
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
