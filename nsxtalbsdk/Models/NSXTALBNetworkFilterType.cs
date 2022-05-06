using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNetworkFilterType
    {
        /// <summary>
        /// It is a reference to an object of type VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NetworkRef { get; set; }
        /// <summary>
        /// server_filter of NetworkFilter.
        /// </summary>
        [JsonProperty(PropertyName = "server_filter")]
        public string? ServerFilter { get; set; }
    }
}
