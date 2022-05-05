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
    public class NSXTALBControllerSizingLimitsType 
    {
        /// <summary>
        /// Controller system limits specific to cloud type for this controller sizing. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_sizing_cloud_limits")]
        public IList<NSXTALBControllerSizingCloudLimitsType> ControllerSizingCloudLimits { get; set; }
        /// <summary>
        /// Controller flavor (S/M/L) for this sizing limit. Enum options - CONTROLLER_ESSENTIALS, CONTROLLER_SMALL,
        /// CONTROLLER_MEDIUM, CONTROLLER_LARGE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "flavor")]
        public string? Flavor { get; set; }
        /// <summary>
        /// Maximum number of clouds. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_clouds")]
        public int? NumClouds { get; set; }
        /// <summary>
        /// Maximum number of east-west virtualservices. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_east_west_virtualservices")]
        public int? NumEastWestVirtualservices { get; set; }
        /// <summary>
        /// Maximum number of servers. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_servers")]
        public int? NumServers { get; set; }
        /// <summary>
        /// Maximum number of serviceengines. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_serviceengines")]
        public int? NumServiceengines { get; set; }
        /// <summary>
        /// Maximum number of tenants. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_tenants")]
        public int? NumTenants { get; set; }
        /// <summary>
        /// Maximum number of virtualservices. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_virtualservices")]
        public int? NumVirtualservices { get; set; }
        /// <summary>
        /// Maximum number of virtualservices with realtime metrics enabled. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_virtualservices_rt_metrics")]
        public int? NumVirtualservicesRtMetrics { get; set; }
        /// <summary>
        /// Maximum number of vrfcontexts. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_vrfs")]
        public int? NumVrfs { get; set; }
    }
}
