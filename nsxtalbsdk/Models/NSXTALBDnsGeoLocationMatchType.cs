using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsGeoLocationMatchType
    {
        /// <summary>
        /// Geographical location of the client IP to be used in the match. This location is of the format Country/State/City e.g.
        /// US/CA/Santa Clara. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "geolocation_name")]
        public string? GeolocationName { get; set; }
        /// <summary>
        /// Geolocation tag for the client IP. This could be any string value for the client IP, e.g. client IPs from US East Coast
        /// geolocation would be tagged as 'East Coast'. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "geolocation_tag")]
        public string? GeolocationTag { get; set; }
        /// <summary>
        /// Criterion to use for matching the client IP's geographical location. Enum options - IS_IN, IS_NOT_IN. Field introduced
        /// in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Use the IP address from the EDNS client subnet option, if available, to derive geo location of the DNS query. Field
        /// introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "use_edns_client_subnet_ip")]
        public bool? UseEdnsClientSubnetIp { get; set; }
    }
}
