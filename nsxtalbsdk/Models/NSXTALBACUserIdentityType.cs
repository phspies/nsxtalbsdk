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
    public class NSXTALBACUserIdentityType 
    {
        /// <summary>
        /// User identity type for audit event (e.g. username, organization, component). Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// User identity value for audit event (e.g. SomeCompany, Jane Doe, Secure-shell). Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
    }
}
