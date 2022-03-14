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
    public class NSXTALBContainerCloudSetupType 
    {
        /// <summary>
        /// cc_id of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Placeholder for description of property cloud_access of obj type ContainerCloudSetup field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "cloud_access")]
        public bool? CloudAccess { get; set; }
        /// <summary>
        /// failed_hosts of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "failed_hosts")]
        public IList<string> FailedHosts { get; set; }
        /// <summary>
        /// fleet_endpoint of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "fleet_endpoint")]
        public string? FleetEndpoint { get; set; }
        /// <summary>
        /// hosts of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// master_nodes of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "master_nodes")]
        public IList<string> MasterNodes { get; set; }
        /// <summary>
        /// missing_hosts of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "missing_hosts")]
        public IList<string> MissingHosts { get; set; }
        /// <summary>
        /// new_hosts of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "new_hosts")]
        public IList<string> NewHosts { get; set; }
        /// <summary>
        /// reason of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property se_deploy_method_access of obj type ContainerCloudSetup field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "se_deploy_method_access")]
        public bool? SeDeployMethodAccess { get; set; }
        /// <summary>
        /// se_name of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// version of ContainerCloudSetup.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
