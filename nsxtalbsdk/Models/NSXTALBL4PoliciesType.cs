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
    public class NSXTALBL4PoliciesType 
    {
        /// <summary>
        /// Index of the virtual service L4 policy set. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// ID of the virtual service L4 policy set. It is a reference to an object of type L4PolicySet. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "l4_policy_set_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string L4PolicySetRef { get; set; }
    }
}
