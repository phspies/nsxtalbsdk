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
    public class NSXTALBDnsRuleActionGslbSiteSelectionType 
    {
        /// <summary>
        /// GSLB fallback sites to use in case the desired site is down. Field introduced in 17.2.5. Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "fallback_site_names")]
        public IList<string> FallbackSiteNames { get; set; }
        /// <summary>
        /// When set to true, GSLB site is a preferred site. This setting comes into play when the site is down, as well as no
        /// configured fallback site is available (all fallback sites are also down), then any one available site is selected based
        /// on the default algorithm for GSLB pool member selection. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "is_site_preferred")]
        public bool? IsSitePreferred { get; set; }
        /// <summary>
        /// GSLB site name. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "site_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SiteName { get; set; }
    }
}
