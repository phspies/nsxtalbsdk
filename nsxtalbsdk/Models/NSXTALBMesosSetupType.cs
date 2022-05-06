using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMesosSetupType
    {
        /// <summary>
        /// cc_id of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// failed_hosts of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "failed_hosts")]
        public IList<string> FailedHosts { get; set; }
        /// <summary>
        /// fleet_endpoint of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "fleet_endpoint")]
        public string? FleetEndpoint { get; set; }
        /// <summary>
        /// hosts of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// Placeholder for description of property mesos_access of obj type MesosSetup field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "mesos_access")]
        public bool? MesosAccess { get; set; }
        /// <summary>
        /// mesos_url of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "mesos_url")]
        public string? MesosUrl { get; set; }
        /// <summary>
        /// missing_hosts of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "missing_hosts")]
        public IList<string> MissingHosts { get; set; }
        /// <summary>
        /// new_hosts of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "new_hosts")]
        public IList<string> NewHosts { get; set; }
        /// <summary>
        /// reason of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property se_deploy_method_access of obj type MesosSetup field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "se_deploy_method_access")]
        public bool? SeDeployMethodAccess { get; set; }
        /// <summary>
        /// se_name of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// version of MesosSetup.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
