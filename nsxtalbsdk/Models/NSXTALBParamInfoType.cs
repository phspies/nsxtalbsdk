using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBParamInfoType
    {
        /// <summary>
        /// Number of hits for a param. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_hits")]
        public long? ParamHits { get; set; }
        /// <summary>
        /// Param name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_key")]
        public string? ParamKey { get; set; }
        /// <summary>
        /// Various param size and its respective hit count. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_size_classes")]
        public IList<NSXTALBParamSizeClassType> ParamSizeClasses { get; set; }
        /// <summary>
        /// Various param type and its respective hit count. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_type_classes")]
        public IList<NSXTALBParamTypeClassType> ParamTypeClasses { get; set; }
    }
}
