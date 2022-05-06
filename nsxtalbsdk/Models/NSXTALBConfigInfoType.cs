using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBConfigInfoType
    {
        /// <summary>
        /// Placeholder for description of property queue of obj type ConfigInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public IList<NSXTALBVersionInfoType> Queue { get; set; }
        /// <summary>
        /// Number of reader_count.
        /// </summary>
        [JsonProperty(PropertyName = "reader_count")]
        public int? ReaderCount { get; set; }
        /// <summary>
        /// Enum options - REPL_NONE, REPL_ENABLED, REPL_DISABLED.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
        /// <summary>
        /// Number of writer_count.
        /// </summary>
        [JsonProperty(PropertyName = "writer_count")]
        public int? WriterCount { get; set; }
    }
}
