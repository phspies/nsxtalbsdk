using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBConfigPbAttributesType
    {
        /// <summary>
        /// Protobuf version number. Gets incremented if there is se Diff of federated diff in config pbs.This field will be a
        /// monotonically increasing number indicating the number of Config Update operations. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }
    }
}
