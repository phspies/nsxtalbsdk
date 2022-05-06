using Newtonsoft.Json;
using System.Linq;
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
