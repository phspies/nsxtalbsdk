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
    public class NSXTALBALBServicesAccountType 
    {
        public NSXTALBALBServicesAccountType()
        {
        }
        /// <summary>
        /// ID of an Account in the customer portal. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Account to which the customer portal user belongs. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Information about users within the account in the customer portal. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<NSXTALBALBServicesAccountUserType> Users { get; set; }
    }
}
