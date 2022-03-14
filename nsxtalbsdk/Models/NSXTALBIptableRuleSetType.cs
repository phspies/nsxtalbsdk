using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIptableRuleSetType 
    {
        public NSXTALBIptableRuleSetType()
        {
        }
        /// <summary>
        /// chain of IptableRuleSet.
        /// </summary>
        [JsonProperty(PropertyName = "chain", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Chain { get; set; }
        /// <summary>
        /// Placeholder for description of property rules of obj type IptableRuleSet field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBIptableRuleType> Rules { get; set; }
        /// <summary>
        /// table of IptableRuleSet.
        /// </summary>
        [JsonProperty(PropertyName = "table", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Table { get; set; }
    }
}
