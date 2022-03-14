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
    public class NSXTALBSipServiceApplicationProfileType 
    {
        /// <summary>
        /// SIP transaction timeout in seconds. Allowed values are 2-512. Field introduced in 17.2.8, 18.1.3, 18.2.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "transaction_timeout")]
        public int? TransactionTimeout { get; set; }
    }
}
