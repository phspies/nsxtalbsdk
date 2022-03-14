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
    public class NSXTALBSupportedMigrationsType 
    {
        /// <summary>
        /// Minimum accepted API version. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "api_version")]
        public string? ApiVersion { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on controller host for this image installation. Field introduced in 18.2.6. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "controller_host_min_free_disk_size")]
        public int? ControllerHostMinFreeDiskSize { get; set; }
        /// <summary>
        /// Minimum number of cores required for Controller. Field introduced in 18.2.10, 20.1.2. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "controller_min_cores")]
        public int? ControllerMinCores { get; set; }
        /// <summary>
        /// Minimum supported Docker version required for Controller. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_min_docker_version")]
        public string? ControllerMinDockerVersion { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on controller for this image installation. Field introduced in 18.2.6. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "controller_min_free_disk_size")]
        public int? ControllerMinFreeDiskSize { get; set; }
        /// <summary>
        /// Minimum memory required(in GB) for Controller. Field introduced in 18.2.10, 20.1.2. Unit is GB. Allowed in Basic
        /// edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "controller_min_memory")]
        public int? ControllerMinMemory { get; set; }
        /// <summary>
        /// Minimum space required(in GB) for Controller. Field introduced in 18.2.10, 20.1.2. Unit is GB. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "controller_min_total_disk")]
        public int? ControllerMinTotalDisk { get; set; }
        /// <summary>
        /// Supported active versions for this image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "max_active_versions")]
        public int? MaxActiveVersions { get; set; }
        /// <summary>
        /// Minimum supported API version. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "min_supported_api_version")]
        public string? MinSupportedApiVersion { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on podman controller host for this image installation. Field introduced in 21.1.4. Unit is
        /// GB.
        /// </summary>
        [JsonProperty(PropertyName = "podman_controller_host_min_free_disk_size")]
        public int? PodmanControllerHostMinFreeDiskSize { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on podman se host for this image installation. Field introduced in 21.1.4. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "podman_se_host_min_free_disk_size")]
        public int? PodmanSeHostMinFreeDiskSize { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on controller for rollback. Field introduced in 18.2.6. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "rollback_controller_disk_space")]
        public int? RollbackControllerDiskSpace { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on se for rollback. Field introduced in 18.2.6. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "rollback_se_disk_space")]
        public int? RollbackSeDiskSpace { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on se host for this image installation. Field introduced in 18.2.6. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "se_host_min_free_disk_size")]
        public int? SeHostMinFreeDiskSize { get; set; }
        /// <summary>
        /// Minimum  number of cores required for se. Field introduced in 18.2.10, 20.1.2. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_min_cores")]
        public int? SeMinCores { get; set; }
        /// <summary>
        /// Minimum space required(in GB) on se for this image installation for non-fips mode(+1 GB for fips mode). Field introduced
        /// in 18.2.6. Unit is GB.
        /// </summary>
        [JsonProperty(PropertyName = "se_min_free_disk_size")]
        public int? SeMinFreeDiskSize { get; set; }
        /// <summary>
        /// Minimum  memory required(in GB) for se. Field introduced in 18.2.10, 20.1.2. Unit is GB. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_min_memory")]
        public int? SeMinMemory { get; set; }
        /// <summary>
        /// Minimum space required(in GB) for se. Field introduced in 18.2.10, 20.1.2. Unit is GB. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_min_total_disk")]
        public int? SeMinTotalDisk { get; set; }
        /// <summary>
        /// Supported compatible versions for this image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<string> Versions { get; set; }
    }
}
