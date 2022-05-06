using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOpenStackSeVmChangeType
    {
        /// <summary>
        /// error_string of OpenStackSeVmChange.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Unique object identifier of se_vm.
        /// </summary>
        [JsonProperty(PropertyName = "se_vm_uuid")]
        public string? SeVmUuid { get; set; }
    }
}
