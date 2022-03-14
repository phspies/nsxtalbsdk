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
    public class NSXTALBMemberInterfaceType 
    {
        /// <summary>
        /// Placeholder for description of property active of obj type MemberInterface field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }
        /// <summary>
        /// if_name of MemberInterface.
        /// </summary>
        [JsonProperty(PropertyName = "if_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string IfName { get; set; }
        /// <summary>
        /// Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
    }
}
