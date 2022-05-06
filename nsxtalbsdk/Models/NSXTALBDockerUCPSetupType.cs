using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDockerUCPSetupType
    {
        /// <summary>
        /// cc_id of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Placeholder for description of property docker_ucp_access of obj type DockerUCPSetup field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "docker_ucp_access")]
        public bool? DockerUcpAccess { get; set; }
        /// <summary>
        /// failed_hosts of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "failed_hosts")]
        public IList<string> FailedHosts { get; set; }
        /// <summary>
        /// fleet_endpoint of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "fleet_endpoint")]
        public string? FleetEndpoint { get; set; }
        /// <summary>
        /// hosts of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// missing_hosts of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "missing_hosts")]
        public IList<string> MissingHosts { get; set; }
        /// <summary>
        /// new_hosts of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "new_hosts")]
        public IList<string> NewHosts { get; set; }
        /// <summary>
        /// reason of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property se_deploy_method_access of obj type DockerUCPSetup field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "se_deploy_method_access")]
        public bool? SeDeployMethodAccess { get; set; }
        /// <summary>
        /// se_name of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// ucp_nodes of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "ucp_nodes")]
        public IList<string> UcpNodes { get; set; }
        /// <summary>
        /// version of DockerUCPSetup.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
