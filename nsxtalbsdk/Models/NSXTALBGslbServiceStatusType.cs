using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbServiceStatusType
    {
        /// <summary>
        /// details of GslbServiceStatus.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<string> Details { get; set; }
        /// <summary>
        /// Placeholder for description of property gs_runtime of obj type GslbServiceStatus field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "gs_runtime")]
        public NSXTALBGslbServiceRuntimeType GsRuntime { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
