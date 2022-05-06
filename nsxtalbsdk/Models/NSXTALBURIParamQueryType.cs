using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBURIParamQueryType
    {
        /// <summary>
        /// Concatenate a string to the query of the incoming request URI and then use it in the request URI going to the backend
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "add_string")]
        public string? AddString { get; set; }
        /// <summary>
        /// Use or drop the query of the incoming request URI in the request URI to the backend server.
        /// </summary>
        [JsonProperty(PropertyName = "keep_query")]
        public bool? KeepQuery { get; set; }
    }
}
