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
    public class NSXTALBOCSPConfigType 
    {
        /// <summary>
        /// Describes the Time Interval after which the next OCSP job needs to be scheduled in case of the OCSP job failures.
        /// Allowed values are 60-86400. Field introduced in 20.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "failed_ocsp_jobs_retry_interval")]
        public int? FailedOcspJobsRetryInterval { get; set; }
        /// <summary>
        /// Maximum number of times the failed OCSP jobs can be scheduled. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_tries")]
        public int? MaxTries { get; set; }
        /// <summary>
        /// Interval between the OCSP queries. Allowed values are 60-31536000. Field introduced in 20.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_req_interval")]
        public int? OcspReqInterval { get; set; }
        /// <summary>
        /// Time in seconds that the system waits for a reply from the OCSP responder before dropping the connection. Field
        /// introduced in 20.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_resp_timeout")]
        public int? OcspRespTimeout { get; set; }
        /// <summary>
        /// List of Responder URLs configured by user to do failover/override the AIA extension contained in the OCSP responder's
        /// SSL/TLS certificate. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "responder_url_lists")]
        public IList<string> ResponderUrlLists { get; set; }
        /// <summary>
        /// Describes the type of action to take with the Responder URLs. Enum options - OCSP_RESPONDER_URL_FAILOVER,
        /// OCSP_RESPONDER_URL_OVERRIDE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "url_action")]
        public string? UrlAction { get; set; }
    }
}
