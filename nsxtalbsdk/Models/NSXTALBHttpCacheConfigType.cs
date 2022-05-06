using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHttpCacheConfigType
    {
        /// <summary>
        /// Add an Age header to content served from cache, which indicates to the client the number of seconds the object has been
        /// in the cache.
        /// </summary>
        [JsonProperty(PropertyName = "age_header")]
        public bool? AgeHeader { get; set; }
        /// <summary>
        /// Enable/disable caching objects without Cache-Control headers.
        /// </summary>
        [JsonProperty(PropertyName = "aggressive")]
        public bool? Aggressive { get; set; }
        /// <summary>
        /// If a Date header was not added by the server, add a Date header to the object served from cache.  This indicates to the
        /// client when the object was originally sent by the server to the cache.
        /// </summary>
        [JsonProperty(PropertyName = "date_header")]
        public bool? DateHeader { get; set; }
        /// <summary>
        /// Default expiration time of cache objects received from the server without a Cache-Control expiration header.  This value
        /// may be overwritten by the Heuristic Expire setting.
        /// </summary>
        [JsonProperty(PropertyName = "default_expire")]
        public int? DefaultExpire { get; set; }
        /// <summary>
        /// Enable/disable HTTP object caching.When enabling caching for the first time, SE Group app_cache_percent must be set to
        /// allocate shared memory required for caching (A service engine restart is needed after setting/resetting the SE group
        /// value).
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// If a response object from the server does not include the Cache-Control header, but does include a Last-Modified header,
        /// the system will use this time to calculate the Cache-Control expiration.  If unable to solicit an Last-Modified header,
        /// then the system will fall back to the Cache Expire Time value.
        /// </summary>
        [JsonProperty(PropertyName = "heuristic_expire")]
        public bool? HeuristicExpire { get; set; }
        /// <summary>
        /// Ignore client's cache control headers when fetching or storing from and to the cache. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_request_cache_control")]
        public bool? IgnoreRequestCacheControl { get; set; }
        /// <summary>
        /// Max size, in bytes, of the cache.  The default, zero, indicates auto configuration.
        /// </summary>
        [JsonProperty(PropertyName = "max_cache_size")]
        public long? MaxCacheSize { get; set; }
        /// <summary>
        /// Maximum size of an object to store in the cache.
        /// </summary>
        [JsonProperty(PropertyName = "max_object_size")]
        public int? MaxObjectSize { get; set; }
        /// <summary>
        /// Blacklist string group of non-cacheable mime types. It is a reference to an object of type StringGroup. Field deprecated
        /// in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_black_group_refs")]
        public IList<string> MimeTypesBlackGroupRefs { get; set; }
        /// <summary>
        /// Blacklist of non-cacheable mime types. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_black_list")]
        public IList<string> MimeTypesBlackList { get; set; }
        /// <summary>
        /// Blocklist string group of non-cacheable mime types. It is a reference to an object of type StringGroup. Field introduced
        /// in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_block_group_refs")]
        public IList<string> MimeTypesBlockGroupRefs { get; set; }
        /// <summary>
        /// Blocklist of non-cacheable mime types. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_block_lists")]
        public IList<string> MimeTypesBlockLists { get; set; }
        /// <summary>
        /// Allowlist string group of cacheable mime types. If both Cacheable Mime Types string list and string group are empty,
        /// this defaults to */*. It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_group_refs")]
        public IList<string> MimeTypesGroupRefs { get; set; }
        /// <summary>
        /// Allowlist of cacheable mime types. If both Cacheable Mime Types string list and string group are empty, this defaults to
        /// */*.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_list")]
        public IList<string> MimeTypesList { get; set; }
        /// <summary>
        /// Minimum size of an object to store in the cache.
        /// </summary>
        [JsonProperty(PropertyName = "min_object_size")]
        public int? MinObjectSize { get; set; }
        /// <summary>
        /// Allow caching of objects whose URI included a query argument.  When disabled, these objects are not cached.  When
        /// enabled, the request must match the URI query to be considered a hit.
        /// </summary>
        [JsonProperty(PropertyName = "query_cacheable")]
        public bool? QueryCacheable { get; set; }
        /// <summary>
        /// Non-cacheable URI configuration with match criteria. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "uri_non_cacheable")]
        public NSXTALBPathMatchType UriNonCacheable { get; set; }
        /// <summary>
        /// Add an X-Cache header to content served from cache, which indicates to the client that the object was served from an
        /// intermediate cache.
        /// </summary>
        [JsonProperty(PropertyName = "xcache_header")]
        public bool? XcacheHeader { get; set; }
    }
}
