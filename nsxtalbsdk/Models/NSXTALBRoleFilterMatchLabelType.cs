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
    public class NSXTALBRoleFilterMatchLabelType 
    {
        public NSXTALBRoleFilterMatchLabelType()
        {
        }
        /// <summary>
        /// Key for filter match. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// Values for filter match. Multiple values will be evaluated as OR. Example  key = value1 OR key = value2. Behavior for
        /// match is key = * if this field is empty. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }
    }
}
