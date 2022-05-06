using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCRSDeploymentSuccessType
    {
        /// <summary>
        /// List of all installed CRS updates. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "crs_info")]
        public IList<NSXTALBCRSDetailsType> CrsInfo { get; set; }
    }
}
