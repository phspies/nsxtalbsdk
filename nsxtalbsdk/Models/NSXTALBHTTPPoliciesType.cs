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
    public class NSXTALBHTTPPoliciesType 
    {
        public NSXTALBHTTPPoliciesType()
        {
        }
        /// <summary>
        /// UUID of the virtual service HTTP policy collection. It is a reference to an object of type HTTPPolicySet.
        /// </summary>
        [JsonProperty(PropertyName = "http_policy_set_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string HttpPolicySetRef { get; set; }
        /// <summary>
        /// Index of the virtual service HTTP policy collection.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
    }
}
