using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBUDPProxyProfileType
    {
        /// <summary>
        /// The amount of time (in sec) for which a flow needs to be idle before it is deleted. Allowed values are 2-3600. Field
        /// introduced in 17.2.8, 18.1.3, 18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "session_idle_timeout")]
        public int? SessionIdleTimeout { get; set; }
    }
}
