using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVHMatchType
    {
        /// <summary>
        /// Host/domain name match configuration. Must be configured along with at least one path match criteria. Field introduced
        /// in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Host { get; set; }
        /// <summary>
        /// Resource/uri path match configuration. Must be configured along with Host match criteria. Field introduced in 20.1.3.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public IList<NSXTALBPathMatchType> Path { get; set; }
    }
}
