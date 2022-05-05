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
    public class NSXTALBDnsRuleActionType 
    {
        /// <summary>
        /// Allow or drop the DNS query. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow")]
        public NSXTALBDnsRuleActionAllowDropType Allow { get; set; }
        /// <summary>
        /// Rate limits the DNS requests. Field deprecated in 20.1.1. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "dns_rate_limit")]
        public NSXTALBDnsRateProfileType DnsRateLimit { get; set; }
        /// <summary>
        /// Rate limits the DNS requests. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_rate_limiter")]
        public NSXTALBDnsRateLimiterType DnsRateLimiter { get; set; }
        /// <summary>
        /// Select a specific GSLB site for the DNS query. This action should be used only when GSLB services have been configured
        /// for the DNS virtual service. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_site_selection")]
        public NSXTALBDnsRuleActionGslbSiteSelectionType GslbSiteSelection { get; set; }
        /// <summary>
        /// Select a pool or pool group for the passthrough DNS query which cannot be served locally but could be served by upstream
        /// servers. Field introduced in 18.1.3, 17.2.12.
        /// </summary>
        [JsonProperty(PropertyName = "pool_switching")]
        public NSXTALBDnsRuleActionPoolSwitchingType PoolSwitching { get; set; }
        /// <summary>
        /// Generate a response for the DNS query. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public NSXTALBDnsRuleActionResponseType Response { get; set; }
    }
}
