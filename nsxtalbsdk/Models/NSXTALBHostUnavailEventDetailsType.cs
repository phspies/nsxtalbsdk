using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHostUnavailEventDetailsType
    {
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// reasons of HostUnavailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reasons")]
        public IList<string> Reasons { get; set; }
        /// <summary>
        /// vs_name of HostUnavailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
    }
}
