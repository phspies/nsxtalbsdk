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
    public class NSXTALBGslbSubDomainPlacementRuntimeType 
    {
        /// <summary>
        /// This field describes the placement status of fqdns mapping to the above Subdomain.  If placement allowed is true, then
        /// the fqdn/GslbService will be placed on the DNS-VS. Otherwise, it shall not be placed on the DNS-VS. . Field introduced
        /// in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "placement_allowed")]
        public bool? PlacementAllowed { get; set; }
        /// <summary>
        /// This field identifies the Subdomain. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sub_domain")]
        public string? SubDomain { get; set; }
        /// <summary>
        /// This field describes the transition operation to be initiated downstream when subdomain placement rules change. For
        /// example  if a.com was not placed on dns-vs-1 and due to configuration change if it is to be placed on dns-vs-1, then all
        /// the GslbServices whose fqdn maps a.com will be pushed to dns-vs-1. In this scenario, the transition ops will be
        /// GSLB_CREATE. If there is a configuration change where a.com is not placed on dns-vs-1 then the transition ops will be
        /// GSLB_DELETE. . Enum options - GSLB_NONE, GSLB_CREATE, GSLB_UPDATE, GSLB_DELETE, GSLB_PURGE, GSLB_DECL. Field introduced
        /// in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "transition_ops")]
        public string? TransitionOps { get; set; }
    }
}
