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
    public class NSXTALBALBServicesUserType 
    {
        /// <summary>
        /// ID of primary account of the portal user. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "account_id")]
        public string? AccountId { get; set; }
        /// <summary>
        /// Name of primary account of the portal user. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "account_name")]
        public string? AccountName { get; set; }
        /// <summary>
        /// Email ID of the portal user. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "email", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Email { get; set; }
        /// <summary>
        /// Information about all the accounts managed by user in the customer portal. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "managed_accounts")]
        public IList<NSXTALBALBServicesAccountType> ManagedAccounts { get; set; }
        /// <summary>
        /// Name of the portal user. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Phone number of the user. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string? Phone { get; set; }
    }
}
