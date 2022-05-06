using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBURIParamType
    {
        /// <summary>
        /// Token config either for the URI components or a constant string. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "tokens")]
        public IList<NSXTALBURIParamTokenType> Tokens { get; set; }
        /// <summary>
        /// URI param type. Enum options - URI_PARAM_TYPE_TOKENIZED.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
