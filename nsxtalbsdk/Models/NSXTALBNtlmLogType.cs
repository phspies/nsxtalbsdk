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
    public class NSXTALBNtlmLogType 
    {
        public NSXTALBNtlmLogType()
        {
        }
        /// <summary>
        /// Set to true, if request is detected to be NTLM. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ntlm_detected")]
        public bool? NtlmDetected { get; set; }
        /// <summary>
        /// Set the NTLM Status. Enum options - NTLM_AUTHENTICATION_SUCCESS, NTLM_UNAUTHORIZED, NTLM_NEGOTIATION,
        /// NTLM_AUTHENTICATION_FAILURE, NTLM_AUTHENTICATED_REQUESTS. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ntlm_status")]
        public string? NtlmStatus { get; set; }
    }
}
