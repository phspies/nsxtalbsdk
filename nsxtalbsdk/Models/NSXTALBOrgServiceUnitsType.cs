using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOrgServiceUnitsType
    {
        /// <summary>
        /// Available service units on pulse portal. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "available_service_units")]
        public double? AvailableServiceUnits { get; set; }
        /// <summary>
        /// Organization id. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "org_id")]
        public string? OrgId { get; set; }
        /// <summary>
        /// Used service units on pulse portal. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "used_service_units")]
        public double? UsedServiceUnits { get; set; }
    }
}
