using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIpCommunityType 
    {
        /// <summary>
        /// Community string either in aa nn format where aa, nn is within [1,65535] or local-AS|no-advertise|no-export|internet.
        /// Field introduced in 17.1.3. Minimum of 1 items required. Maximum of 16 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "community")]
        public IList<string> Community { get; set; }
        /// <summary>
        /// Beginning of IP address range. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_begin")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpBegin { get; set; }
        /// <summary>
        /// End of IP address range. Optional if ip_begin is the only IP address in specified IP range. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_end")]
        public NSXTALBIpAddrType IpEnd { get; set; }
    }
}
