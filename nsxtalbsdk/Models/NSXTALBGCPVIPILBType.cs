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
    public class NSXTALBGCPVIPILBType 
    {
        public NSXTALBGCPVIPILBType()
        {
        }
        /// <summary>
        /// Google Cloud Router Names to advertise BYOIP. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_router_names")]
        public IList<string> CloudRouterNames { get; set; }
    }
}
