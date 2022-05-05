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
    public class NSXTALBDnsResponseType 
    {
        /// <summary>
        /// Number of additional records.
        /// </summary>
        [JsonProperty(PropertyName = "additional_records_count")]
        public int? AdditionalRecordsCount { get; set; }
        /// <summary>
        /// Number of answer records.
        /// </summary>
        [JsonProperty(PropertyName = "answer_records_count")]
        public int? AnswerRecordsCount { get; set; }
        /// <summary>
        /// Flag to indicate the responding DNS is an authority for the requested FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "authoritative_answer")]
        public bool? AuthoritativeAnswer { get; set; }
        /// <summary>
        /// Flag to indicate whether fallback algorithm was used to serve this request. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "fallback_algorithm_used")]
        public bool? FallbackAlgorithmUsed { get; set; }
        /// <summary>
        /// Resource records in the response are generated based on wildcard match. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_wildcard")]
        public bool? IsWildcard { get; set; }
        /// <summary>
        /// Number of nameserver records.
        /// </summary>
        [JsonProperty(PropertyName = "nameserver_records_count")]
        public int? NameserverRecordsCount { get; set; }
        /// <summary>
        /// DNS response operation code e.g. QUERY, NOTIFY, etc. Enum options - DNS_OPCODE_QUERY, DNS_OPCODE_IQUERY,
        /// DNS_OPCODE_STATUS, DNS_OPCODE_NOTIFY, DNS_OPCODE_UPDATE. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "opcode")]
        public string? Opcode { get; set; }
        /// <summary>
        /// Opt resource records in the response. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "opt_record")]
        public NSXTALBDnsOptRecordType OptRecord { get; set; }
        /// <summary>
        /// Flag indicating response is a client query (false) or server response (true). Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "query_or_response")]
        public bool? QueryOrResponse { get; set; }
        /// <summary>
        /// Number of questions in the client DNS request eliciting this DNS response. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "question_count")]
        public int? QuestionCount { get; set; }
        /// <summary>
        /// Resource records in the response.
        /// </summary>
        [JsonProperty(PropertyName = "records")]
        public IList<NSXTALBDnsResourceRecordType> Records { get; set; }
        /// <summary>
        /// Flag indicating the DNS query is fully answered.
        /// </summary>
        [JsonProperty(PropertyName = "recursion_available")]
        public bool? RecursionAvailable { get; set; }
        /// <summary>
        /// Flag copied from the DNS query's recursion desired field by the responding DNS. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "recursion_desired")]
        public bool? RecursionDesired { get; set; }
        /// <summary>
        /// Response code in the response. Enum options - DNS_RCODE_NOERROR, DNS_RCODE_FORMERR, DNS_RCODE_SERVFAIL,
        /// DNS_RCODE_NXDOMAIN, DNS_RCODE_NOTIMP, DNS_RCODE_REFUSED, DNS_RCODE_YXDOMAIN, DNS_RCODE_YXRRSET, DNS_RCODE_NXRRSET,
        /// DNS_RCODE_NOTAUTH, DNS_RCODE_NOTZONE.
        /// </summary>
        [JsonProperty(PropertyName = "response_code")]
        public string? ResponseCode { get; set; }
        /// <summary>
        /// Flag to indicate if the answer received from DNS is truncated (original answer exceeds 512 bytes UDP limit).
        /// </summary>
        [JsonProperty(PropertyName = "truncation")]
        public bool? Truncation { get; set; }
    }
}
