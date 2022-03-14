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
    public class NSXTALBAuthAttributeMatchType 
    {
        /// <summary>
        /// Attribute name whose values will be looked up in the access lists. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "attribute_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttributeName { get; set; }
        /// <summary>
        /// Attribute Values used to determine access when authentication applies. Field introduced in 18.2.5. Allowed in Basic
        /// edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "attribute_value_list", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBStringMatchType AttributeValueList { get; set; }
    }
}
