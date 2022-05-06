using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMarathonSeDeploymentType
    {
        /// <summary>
        /// Docker image to be used for Avi SE installation e.g. fedora, ubuntu.
        /// </summary>
        [JsonProperty(PropertyName = "docker_image")]
        public string? DockerImage { get; set; }
        /// <summary>
        /// Host OS distribution e.g. COREOS, UBUNTU, REDHAT.
        /// </summary>
        [JsonProperty(PropertyName = "host_os")]
        public string? HostOs { get; set; }
        /// <summary>
        /// Accepted resource roles for SEs.
        /// </summary>
        [JsonProperty(PropertyName = "resource_roles")]
        public IList<string> ResourceRoles { get; set; }
        /// <summary>
        /// URIs to be resolved for starting the application.
        /// </summary>
        [JsonProperty(PropertyName = "uris")]
        public IList<string> Uris { get; set; }
    }
}
