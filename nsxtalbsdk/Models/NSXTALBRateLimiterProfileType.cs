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
    public class NSXTALBRateLimiterProfileType 
    {
        /// <summary>
        /// Rate Limit all connections made from any single client IP address to the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_connections_rate_limit")]
        public NSXTALBRateProfileType ClientIpConnectionsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all requests from a client for a specified period of time once the count of failed requests from that client
        /// crosses a threshold for that period. Clients are tracked based on their IP address. Count and time period are specified
        /// through the RateProfile. Requests are deemed failed based on client or server side error status codes, consistent with
        /// how Avi Logs and Metrics subsystems mark failed requests. .
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_failed_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpFailedRequestsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all HTTP requests from any single client IP address to all URLs of the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpRequestsRateLimit { get; set; }
        /// <summary>
        /// Automatically track clients and classify them into 3 groups - Good, Bad, Unknown. Clients are tracked based on their IP
        /// Address. Clients are added to the Good group when the Avi Scan Detection system builds history of requests from them
        /// that complete successfully. Clients are added to Unknown group when there is insufficient history about them. Requests
        /// from such clients are rate limited to the rate specified in the RateProfile. Finally, Clients with history of failed
        /// requests are added to Bad group and their requests are rate limited with stricter thresholds than the Unknown Clients
        /// group. The Avi Scan Detection system automatically tunes itself so that the Good, Bad, and Unknown client IPs group
        /// membership changes dynamically with the changes in traffic patterns through the ADC.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_scanners_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpScannersRequestsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all requests from a client to a URI for a specified period of time once the count of failed requests from
        /// that client to the URI crosses a threshold for that period. Clients are tracked based on their IP address. Count and
        /// time period are specified through the RateProfile. Requests are deemed failed based on client or server side error
        /// status codes, consistent with how Avi Logs and Metrics subsystems mark failed requests. .
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_to_uri_failed_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpToUriFailedRequestsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all HTTP requests from any single client IP address to any single URL.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_to_uri_requests_rate_limit")]
        public NSXTALBRateProfileType ClientIpToUriRequestsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all HTTP requests that map to any custom string. Field introduced in 17.2.13,18.1.3,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "custom_requests_rate_limit")]
        public NSXTALBRateProfileType CustomRequestsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all HTTP requests from all client IP addresses that contain any single HTTP header value. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_header_rate_limits")]
        public IList<NSXTALBRateProfileType> HttpHeaderRateLimits { get; set; }
        /// <summary>
        /// Rate Limit all requests to a URI for a specified period of time once the count of failed requests to that URI crosses a
        /// threshold for that period. Count and time period are specified through the RateProfile. Requests are deemed failed based
        /// on client or server side error status codes, consistent with how Avi Logs and Metrics subsystems mark failed requests. .
        /// </summary>
        [JsonProperty(PropertyName = "uri_failed_requests_rate_limit")]
        public NSXTALBRateProfileType UriFailedRequestsRateLimit { get; set; }
        /// <summary>
        /// Rate Limit all HTTP requests from all client IP addresses to any single URL.
        /// </summary>
        [JsonProperty(PropertyName = "uri_requests_rate_limit")]
        public NSXTALBRateProfileType UriRequestsRateLimit { get; set; }
        /// <summary>
        /// Automatically track URIs and classify them into 3 groups - Good, Bad, Unknown. URIs are added to the Good group when the
        /// Avi Scan Detection system builds history of requests to URIs that complete successfully. URIs are added to Unknown group
        /// when there is insufficient history about them. Requests for such URIs are rate limited to the rate specified in the
        /// RateProfile. Finally, URIs with history of failed requests are added to Bad group and requests to them are rate limited
        /// with stricter thresholds than the Unknown URIs group. The Avi Scan Detection system automatically tunes itself so that
        /// the Good, Bad, and Unknown URIs group membership changes dynamically with the changes in traffic patterns through the
        /// ADC.
        /// </summary>
        [JsonProperty(PropertyName = "uri_scanners_requests_rate_limit")]
        public NSXTALBRateProfileType UriScannersRequestsRateLimit { get; set; }
    }
}
