using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHdrPersistenceProfileType
    {
        /// <summary>
        /// Header name for custom header persistence.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_name")]
        public string? PrstHdrName { get; set; }
    }
}
