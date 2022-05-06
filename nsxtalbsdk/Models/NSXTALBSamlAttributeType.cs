using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSamlAttributeType
    {
        /// <summary>
        /// SAML Attribute name. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "attr_name")]
        public string? AttrName { get; set; }
        /// <summary>
        /// SAML Attribute values. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "attr_values")]
        public IList<string> AttrValues { get; set; }
    }
}
