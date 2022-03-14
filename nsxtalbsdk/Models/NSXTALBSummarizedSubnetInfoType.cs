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
    public class NSXTALBSummarizedSubnetInfoType 
    {
        /// <summary>
        /// cidr_prefix of SummarizedSubnetInfo.
        /// </summary>
        [JsonProperty(PropertyName = "cidr_prefix", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string CidrPrefix { get; set; }
        /// <summary>
        /// network of SummarizedSubnetInfo.
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Network { get; set; }
    }
}
