using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMicroServiceContainerType
    {
        /// <summary>
        /// ID of the container.
        /// </summary>
        [JsonProperty(PropertyName = "container_id")]
        public string? ContainerId { get; set; }
        /// <summary>
        /// ID or name of the host where the container is.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// IP Address of the container.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Port nunber of the instance.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// Marathon Task ID of the instance.
        /// </summary>
        [JsonProperty(PropertyName = "task_id")]
        public string? TaskId { get; set; }
    }
}
