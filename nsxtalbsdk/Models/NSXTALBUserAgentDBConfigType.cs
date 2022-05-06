using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBUserAgentDBConfigType
    {
        /// <summary>
        /// Batch query limit. Allowed values are 1-500. Field introduced in 21.1.1. Allowed in Basic(Allowed values- 500) edition,
        /// Essentials(Allowed values- 500) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_batch_size")]
        public int? AllowedBatchSize { get; set; }
    }
}
