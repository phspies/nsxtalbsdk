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
    public class NSXTALBServerResourcesScoreDataType 
    {
        /// <summary>
        /// Placeholder for description of property avg_cpu_usage of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_cpu_usage")]
        public double? AvgCpuUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_cpu_wait of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_cpu_wait")]
        public double? AvgCpuWait { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_disk1_usage of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_disk1_usage")]
        public double? AvgDisk1Usage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_disk2_usage of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_disk2_usage")]
        public double? AvgDisk2Usage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_disk3_usage of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_disk3_usage")]
        public double? AvgDisk3Usage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_disk4_usage of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_disk4_usage")]
        public double? AvgDisk4Usage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_mem_usage of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_mem_usage")]
        public double? AvgMemUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_uptime of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_uptime")]
        public double? AvgUptime { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_open_conns of obj type ServerResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_open_conns")]
        public double? PctOpenConns { get; set; }
        /// <summary>
        /// Unique object identifier of pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolUuid { get; set; }
        /// <summary>
        /// Reason for the Health Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the health score.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// server of ServerResourcesScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Server { get; set; }
    }
}
