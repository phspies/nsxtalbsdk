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
    public class NSXTALBLinuxServerConfigurationType 
    {
        /// <summary>
        /// Private docker registry for SE image storage. Field deprecated in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "docker_registry_se")]
        public NSXTALBDockerRegistryType DockerRegistrySe { get; set; }
        /// <summary>
        /// Placeholder for description of property hosts of obj type LinuxServerConfiguration field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<NSXTALBLinuxServerHostType> Hosts { get; set; }
        /// <summary>
        /// Flag to notify the SE's in this cloud have an inband management interface, this can be overridden at SE host level by
        /// setting host_attr attr_key as SE_INBAND_MGMT with value of true or false.
        /// </summary>
        [JsonProperty(PropertyName = "se_inband_mgmt")]
        public bool? SeInbandMgmt { get; set; }
        /// <summary>
        /// SE Client Logs disk path for cloud.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_disk_path")]
        public string? SeLogDiskPath { get; set; }
        /// <summary>
        /// SE Client Log disk size for cloud.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_disk_size_GB")]
        public int? SeLogDiskSizeGB { get; set; }
        /// <summary>
        /// SE System Logs disk path for cloud.
        /// </summary>
        [JsonProperty(PropertyName = "se_sys_disk_path")]
        public string? SeSysDiskPath { get; set; }
        /// <summary>
        /// SE System Logs disk size for cloud.
        /// </summary>
        [JsonProperty(PropertyName = "se_sys_disk_size_GB")]
        public int? SeSysDiskSizeGB { get; set; }
        /// <summary>
        /// Parameters for SSH to hosts. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_attr")]
        public NSXTALBSSHSeDeploymentType SshAttr { get; set; }
        /// <summary>
        /// Cloud connector user uuid for SSH to hosts. It is a reference to an object of type CloudConnectorUser. Field introduced
        /// in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssh_user_ref")]
        public string? SshUserRef { get; set; }
    }
}
