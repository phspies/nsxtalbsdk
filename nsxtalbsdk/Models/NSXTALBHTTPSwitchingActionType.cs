using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPSwitchingActionType
    {
        /// <summary>
        /// Content switching action type. Enum options - HTTP_SWITCHING_SELECT_POOL, HTTP_SWITCHING_SELECT_LOCAL,
        /// HTTP_SWITCHING_SELECT_POOLGROUP. Allowed in Essentials(Allowed values-
        /// HTTP_SWITCHING_SELECT_POOL,HTTP_SWITCHING_SELECT_LOCAL) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Action { get; set; }
        /// <summary>
        /// File from which to serve local response to the request.
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public NSXTALBHTTPLocalFileType File { get; set; }
        /// <summary>
        /// UUID of the pool group to serve the request. It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_ref")]
        public string? PoolGroupRef { get; set; }
        /// <summary>
        /// UUID of the pool of servers to serve the request. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// Specific pool server to select.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public NSXTALBPoolServerType Server { get; set; }
        /// <summary>
        /// HTTP status code to use when serving local response. Enum options - HTTP_LOCAL_RESPONSE_STATUS_CODE_200,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_204, HTTP_LOCAL_RESPONSE_STATUS_CODE_403, HTTP_LOCAL_RESPONSE_STATUS_CODE_404,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_429, HTTP_LOCAL_RESPONSE_STATUS_CODE_501.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public string? StatusCode { get; set; }
    }
}
