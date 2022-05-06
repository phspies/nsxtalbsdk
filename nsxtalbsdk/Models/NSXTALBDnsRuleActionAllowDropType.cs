using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsRuleActionAllowDropType
    {
        /// <summary>
        /// Allow the DNS query. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow")]
        public bool? Allow { get; set; }
        /// <summary>
        /// Reset the TCP connection of the DNS query, if allow is set to false to drop the query. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reset_conn")]
        public bool? ResetConn { get; set; }
    }
}
