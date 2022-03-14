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
    public class NSXTALBMicroServiceContainerType 
    {
        public NSXTALBMicroServiceContainerType()
        {
        }
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
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
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
