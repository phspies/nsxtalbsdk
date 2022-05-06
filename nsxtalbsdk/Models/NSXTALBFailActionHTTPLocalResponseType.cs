using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBFailActionHTTPLocalResponseType
    {
        /// <summary>
        /// Placeholder for description of property file of obj type FailActionHTTPLocalResponse field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public NSXTALBHTTPLocalFileType File { get; set; }
        /// <summary>
        /// Enum options - FAIL_HTTP_STATUS_CODE_200, FAIL_HTTP_STATUS_CODE_503.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public string? StatusCode { get; set; }
    }
}
