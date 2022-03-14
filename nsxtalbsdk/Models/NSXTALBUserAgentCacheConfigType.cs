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
    public class NSXTALBUserAgentCacheConfigType 
    {
        public NSXTALBUserAgentCacheConfigType()
        {
        }
        /// <summary>
        /// How many unknown User-Agents to batch up before querying Controller - unless max_wait_time is reached first. Allowed
        /// values are 1-500. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "batch_size")]
        public int? BatchSize { get; set; }
        /// <summary>
        /// The number of User-Agent entries to cache on the Controller. Allowed values are 500-10000000. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_cache_size")]
        public int? ControllerCacheSize { get; set; }
        /// <summary>
        /// How often at most to query controller for a given User-Agent. Allowed values are 2-100. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_upstream_queries")]
        public int? MaxUpstreamQueries { get; set; }
        /// <summary>
        /// The time interval in seconds after which to make a request to the Controller, even if the 'batch_size' hasn't been
        /// reached yet. Allowed values are 20-100000. Field introduced in 21.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "max_wait_time")]
        public int? MaxWaitTime { get; set; }
        /// <summary>
        /// How many BotUACacheResult elements to include in an upstream update message. Allowed values are 1-10000. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_entries_upstream_update")]
        public int? NumEntriesUpstreamUpdate { get; set; }
        /// <summary>
        /// How much space to reserve in percent for known bad bots. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "percent_reserved_for_bad_bots")]
        public int? PercentReservedForBadBots { get; set; }
        /// <summary>
        /// How much space to reserve in percent for browsers. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "percent_reserved_for_browsers")]
        public int? PercentReservedForBrowsers { get; set; }
        /// <summary>
        /// How much space to reserve in percent for known good bots. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "percent_reserved_for_good_bots")]
        public int? PercentReservedForGoodBots { get; set; }
        /// <summary>
        /// How much space to reserve in percent for outstanding upstream requests. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "percent_reserved_for_outstanding")]
        public int? PercentReservedForOutstanding { get; set; }
        /// <summary>
        /// The number of User-Agent entries to cache on each Service Engine. Allowed values are 500-10000000. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_cache_size")]
        public int? SeCacheSize { get; set; }
        /// <summary>
        /// How often in seconds to send updates about User-Agent cache entries to the next upstream cache. Field introduced in
        /// 21.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_update_interval")]
        public int? UpstreamUpdateInterval { get; set; }
    }
}
