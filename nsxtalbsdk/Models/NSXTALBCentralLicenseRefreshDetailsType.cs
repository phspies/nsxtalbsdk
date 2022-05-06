using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCentralLicenseRefreshDetailsType
    {
        /// <summary>
        /// Message. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Service units. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "service_units")]
        public double? ServiceUnits { get; set; }
    }
}
