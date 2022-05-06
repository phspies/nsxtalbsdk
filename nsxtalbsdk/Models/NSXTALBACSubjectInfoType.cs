using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBACSubjectInfoType
    {
        /// <summary>
        /// Subject type for the audit event (e.g. DNS Hostname, IP address, URI). Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// Subject value for the audit event (e.g. www.example.com, 10.10.10.10, www.foo.com/index.html). Field introduced in
        /// 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    }
}
