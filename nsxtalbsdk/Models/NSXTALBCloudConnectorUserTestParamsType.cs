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
    public class NSXTALBCloudConnectorUserTestParamsType 
    {
        /// <summary>
        /// host of CloudConnectorUserTestParams.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
    }
}
