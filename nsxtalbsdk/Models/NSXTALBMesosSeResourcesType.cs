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
    public class NSXTALBMesosSeResourcesType 
    {
        /// <summary>
        /// Attribute (Fleet or Mesos) key of Hosts.
        /// </summary>
        [JsonProperty(PropertyName = "attribute_key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttributeKey { get; set; }
        /// <summary>
        /// Attribute (Fleet or Mesos) value of Hosts.
        /// </summary>
        [JsonProperty(PropertyName = "attribute_value")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttributeValue { get; set; }
        /// <summary>
        /// Obsolete - ignored.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public double? Cpu { get; set; }
        /// <summary>
        /// Obsolete - ignored.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public int? Memory { get; set; }
    }
}
