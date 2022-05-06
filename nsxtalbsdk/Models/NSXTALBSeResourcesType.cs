using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeResourcesType
    {
        /// <summary>
        /// Number of cores_per_socket.
        /// </summary>
        [JsonProperty(PropertyName = "cores_per_socket")]
        public int? CoresPerSocket { get; set; }
        /// <summary>
        /// Number of disk.
        /// </summary>
        [JsonProperty(PropertyName = "disk")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Disk { get; set; }
        /// <summary>
        /// Placeholder for description of property hyper_threading of obj type SeResources field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "hyper_threading")]
        public bool? HyperThreading { get; set; }
        /// <summary>
        /// Indicates that the SE is running on a Virtual Machine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor_mode")]
        public bool? HypervisorMode { get; set; }
        /// <summary>
        /// Number of memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Memory { get; set; }
        /// <summary>
        /// Indicates the number of active datapath processes. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_datapath_processes")]
        public int? NumDatapathProcesses { get; set; }
        /// <summary>
        /// Number of num_vcpus.
        /// </summary>
        [JsonProperty(PropertyName = "num_vcpus")]
        [System.ComponentModel.DataAnnotations.Required]
        public int NumVcpus { get; set; }
        /// <summary>
        /// Number of sockets.
        /// </summary>
        [JsonProperty(PropertyName = "sockets")]
        public int? Sockets { get; set; }
    }
}
