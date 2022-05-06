using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDatabaseEventInfoType
    {
        /// <summary>
        /// Component of the database(e.g. metrics). Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string? Component { get; set; }
        /// <summary>
        /// Reported message of the event. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
    }
}
