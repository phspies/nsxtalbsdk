using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsPoliciesType
    {
        /// <summary>
        /// UUID of the dns policy. It is a reference to an object of type DnsPolicy. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_policy_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DnsPolicyRef { get; set; }
        /// <summary>
        /// Index of the dns policy. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
    }
}
