using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBLicenseServiceUpdateType
    {
        /// <summary>
        /// Name. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Organization id. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "service_units")]
        public NSXTALBOrgServiceUnitsType ServiceUnits { get; set; }
    }
}
