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
    public class NSXTALBSaasLicensingInfoType 
    {
        /// <summary>
        /// Maximum service units limit for controller. Allowed values are 0-1000. Special values are 0 - infinite. Field introduced
        /// in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "max_service_units")]
        public double? MaxServiceUnits { get; set; }
        /// <summary>
        /// Minimum service units that always remain reserved on controller. Allowed values are 0-1000. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reserve_service_units")]
        public double? ReserveServiceUnits { get; set; }
    }
}
