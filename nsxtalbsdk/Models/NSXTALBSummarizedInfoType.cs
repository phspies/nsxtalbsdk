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
    public class NSXTALBSummarizedInfoType 
    {
        /// <summary>
        /// Placeholder for description of property subnet_info of obj type SummarizedInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "subnet_info")]
        public IList<NSXTALBSummarizedSubnetInfoType> SubnetInfo { get; set; }
    }
}
