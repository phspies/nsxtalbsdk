using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeLicensedBandwdithExceededEventDetailsType
    {
        /// <summary>
        /// Number of packets dropped since the last event.
        /// </summary>
        [JsonProperty(PropertyName = "num_pkts_dropped")]
        public int? NumPktsDropped { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
    }
}
