using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRediscoverVcenterParamType
    {
        /// <summary>
        /// cloud of RediscoverVcenterParam.
        /// </summary>
        [JsonProperty(PropertyName = "cloud")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cloud { get; set; }
    }
}
