using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsRequestType
    {
        /// <summary>
        /// Number of additional records. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "additional_records_count")]
        public int? AdditionalRecordsCount { get; set; }
        /// <summary>
        /// Number of answer records in the client DNS request. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "answer_records_count")]
        public int? AnswerRecordsCount { get; set; }
        /// <summary>
        /// Flag indicating client understands AD bit and is interested in the value of AD bit in the response. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "authentic_data")]
        public bool? AuthenticData { get; set; }
        /// <summary>
        /// Flag indicating client does not want DNSSEC validation of the response. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "checking_disabled")]
        public bool? CheckingDisabled { get; set; }
        /// <summary>
        /// Geo Location of Client. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_location")]
        public NSXTALBGeoLocationType ClientLocation { get; set; }
        /// <summary>
        /// ID of the DNS request. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public int? Identifier { get; set; }
        /// <summary>
        /// Number of nameserver records in the client DNS request. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nameserver_records_count")]
        public int? NameserverRecordsCount { get; set; }
        /// <summary>
        /// DNS request operation code e.g. QUERY, NOTIFY, etc. Enum options - DNS_OPCODE_QUERY, DNS_OPCODE_IQUERY,
        /// DNS_OPCODE_STATUS, DNS_OPCODE_NOTIFY, DNS_OPCODE_UPDATE. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "opcode")]
        public string? Opcode { get; set; }
        /// <summary>
        /// Opt resource records in the request. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "opt_record")]
        public NSXTALBDnsOptRecordType OptRecord { get; set; }
        /// <summary>
        /// Flag indicating request is a client query (false) or server response (true). Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "query_or_response")]
        public bool? QueryOrResponse { get; set; }
        /// <summary>
        /// Number of questions in the client DNS request. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "question_count")]
        public int? QuestionCount { get; set; }
        /// <summary>
        /// Flag indicating client request for recursive resolution. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "recursion_desired")]
        public bool? RecursionDesired { get; set; }
    }
}
