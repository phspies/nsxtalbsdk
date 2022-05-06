using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBConnectionLogType
    {
        /// <summary>
        /// Placeholder for description of property adf of obj type ConnectionLog field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "adf")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Adf { get; set; }
        /// <summary>
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "average_turntime")]
        public int? AverageTurntime { get; set; }
        /// <summary>
        /// Average packet processing latency for the backend flow. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ingress_latency_be")]
        public int? AvgIngressLatencyBe { get; set; }
        /// <summary>
        /// Average packet processing latency for the frontend flow. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ingress_latency_fe")]
        public int? AvgIngressLatencyFe { get; set; }
        /// <summary>
        /// Number of client_dest_port.
        /// </summary>
        [JsonProperty(PropertyName = "client_dest_port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ClientDestPort { get; set; }
        /// <summary>
        /// Number of client_ip.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ClientIp { get; set; }
        /// <summary>
        /// IPv6 address of the client. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip6")]
        public string? ClientIp6 { get; set; }
        /// <summary>
        /// client_location of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "client_location")]
        public string? ClientLocation { get; set; }
        /// <summary>
        /// Name of the Client Log Filter applied. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_log_filter_name")]
        public string? ClientLogFilterName { get; set; }
        /// <summary>
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "client_rtt")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ClientRtt { get; set; }
        /// <summary>
        /// Number of client_src_port.
        /// </summary>
        [JsonProperty(PropertyName = "client_src_port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ClientSrcPort { get; set; }
        /// <summary>
        /// TCP connection establishment time for the backend flow. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "conn_est_time_be")]
        public int? ConnEstTimeBe { get; set; }
        /// <summary>
        /// TCP connection establishment time for the frontend flow. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "conn_est_time_fe")]
        public int? ConnEstTimeFe { get; set; }
        /// <summary>
        /// Placeholder for description of property connection_ended of obj type ConnectionLog field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "connection_ended")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool ConnectionEnded { get; set; }
        /// <summary>
        /// Enum options - DNS_ENTRY_PASS_THROUGH, DNS_ENTRY_GSLB, DNS_ENTRY_VIRTUALSERVICE, DNS_ENTRY_STATIC, DNS_ENTRY_POLICY,
        /// DNS_ENTRY_LOCAL.
        /// </summary>
        [JsonProperty(PropertyName = "dns_etype")]
        public string? DnsEtype { get; set; }
        /// <summary>
        /// dns_fqdn of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "dns_fqdn")]
        public string? DnsFqdn { get; set; }
        /// <summary>
        /// Number of dns_ips.
        /// </summary>
        [JsonProperty(PropertyName = "dns_ips")]
        public int? DnsIps { get; set; }
        /// <summary>
        /// Enum options - DNS_RECORD_OTHER, DNS_RECORD_A, DNS_RECORD_NS, DNS_RECORD_CNAME, DNS_RECORD_SOA, DNS_RECORD_PTR,
        /// DNS_RECORD_HINFO, DNS_RECORD_MX, DNS_RECORD_TXT, DNS_RECORD_RP, DNS_RECORD_DNSKEY, DNS_RECORD_AAAA, DNS_RECORD_SRV,
        /// DNS_RECORD_OPT, DNS_RECORD_RRSIG, DNS_RECORD_AXFR, DNS_RECORD_ANY.
        /// </summary>
        [JsonProperty(PropertyName = "dns_qtype")]
        public string? DnsQtype { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_request")]
        public NSXTALBDnsRequestType DnsRequest { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_response of obj type ConnectionLog field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dns_response")]
        public NSXTALBDnsResponseType DnsResponse { get; set; }
        /// <summary>
        /// Datascript Log. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "ds_log")]
        public string? DsLog { get; set; }
        /// <summary>
        /// gslbpool_name of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "gslbpool_name")]
        public string? GslbpoolName { get; set; }
        /// <summary>
        /// gslbservice of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "gslbservice")]
        public string? Gslbservice { get; set; }
        /// <summary>
        /// gslbservice_name of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "gslbservice_name")]
        public string? GslbserviceName { get; set; }
        /// <summary>
        /// Number of log_id.
        /// </summary>
        [JsonProperty(PropertyName = "log_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public int LogId { get; set; }
        /// <summary>
        /// Maximum packet processing latency for the backend flow. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_ingress_latency_be")]
        public int? MaxIngressLatencyBe { get; set; }
        /// <summary>
        /// Maximum packet processing latency for the frontend flow. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_ingress_latency_fe")]
        public int? MaxIngressLatencyFe { get; set; }
        /// <summary>
        /// microservice of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "microservice")]
        public string? Microservice { get; set; }
        /// <summary>
        /// microservice_name of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "microservice_name")]
        public string? MicroserviceName { get; set; }
        /// <summary>
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "mss")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Mss { get; set; }
        /// <summary>
        /// network_security_policy_rule_name of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "network_security_policy_rule_name")]
        public string? NetworkSecurityPolicyRuleName { get; set; }
        /// <summary>
        /// Number of num_syn_retransmit.
        /// </summary>
        [JsonProperty(PropertyName = "num_syn_retransmit")]
        public int? NumSynRetransmit { get; set; }
        /// <summary>
        /// Number of num_transaction.
        /// </summary>
        [JsonProperty(PropertyName = "num_transaction")]
        public int? NumTransaction { get; set; }
        /// <summary>
        /// Number of num_window_shrink.
        /// </summary>
        [JsonProperty(PropertyName = "num_window_shrink")]
        public int? NumWindowShrink { get; set; }
        /// <summary>
        /// OCSP Response sent in the SSL/TLS connection Handshake. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_status_resp_sent")]
        public bool? OcspStatusRespSent { get; set; }
        /// <summary>
        /// Number of out_of_orders.
        /// </summary>
        [JsonProperty(PropertyName = "out_of_orders")]
        [System.ComponentModel.DataAnnotations.Required]
        public int OutOfOrders { get; set; }
        /// <summary>
        /// Persistence applied during server selection. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_used")]
        public bool? PersistenceUsed { get; set; }
        /// <summary>
        /// pool of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public string? Pool { get; set; }
        /// <summary>
        /// pool_name of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// Enum options - PROTOCOL_ICMP, PROTOCOL_TCP, PROTOCOL_UDP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string? Protocol { get; set; }
        /// <summary>
        /// Version of proxy protocol used to convey client connection information to the back-end servers.  A value of 0 indicates
        /// that proxy protocol is not used.  A value of 1 or 2 indicates the version of proxy protocol used. Enum options -
        /// PROXY_PROTOCOL_VERSION_1, PROXY_PROTOCOL_VERSION_2.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_protocol")]
        public string? ProxyProtocol { get; set; }
        /// <summary>
        /// Number of report_timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "report_timestamp")]
        [System.ComponentModel.DataAnnotations.Required]
        public long ReportTimestamp { get; set; }
        /// <summary>
        /// Number of retransmits.
        /// </summary>
        [JsonProperty(PropertyName = "retransmits")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Retransmits { get; set; }
        /// <summary>
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "rx_bytes")]
        [System.ComponentModel.DataAnnotations.Required]
        public long RxBytes { get; set; }
        /// <summary>
        /// Number of rx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "rx_pkts")]
        [System.ComponentModel.DataAnnotations.Required]
        public long RxPkts { get; set; }
        /// <summary>
        /// Number of server_conn_src_ip.
        /// </summary>
        [JsonProperty(PropertyName = "server_conn_src_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerConnSrcIp { get; set; }
        /// <summary>
        /// IPv6 address used to connect to Backend Server. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_conn_src_ip6")]
        public string? ServerConnSrcIp6 { get; set; }
        /// <summary>
        /// Number of server_dest_port.
        /// </summary>
        [JsonProperty(PropertyName = "server_dest_port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerDestPort { get; set; }
        /// <summary>
        /// Number of server_ip.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerIp { get; set; }
        /// <summary>
        /// IPv6 address of the Backend Server. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip6")]
        public string? ServerIp6 { get; set; }
        /// <summary>
        /// server_name of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        public string? ServerName { get; set; }
        /// <summary>
        /// Number of server_num_window_shrink.
        /// </summary>
        [JsonProperty(PropertyName = "server_num_window_shrink")]
        public int? ServerNumWindowShrink { get; set; }
        /// <summary>
        /// Number of server_out_of_orders.
        /// </summary>
        [JsonProperty(PropertyName = "server_out_of_orders")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerOutOfOrders { get; set; }
        /// <summary>
        /// Number of server_retransmits.
        /// </summary>
        [JsonProperty(PropertyName = "server_retransmits")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerRetransmits { get; set; }
        /// <summary>
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "server_rtt")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerRtt { get; set; }
        /// <summary>
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "server_rx_bytes")]
        [System.ComponentModel.DataAnnotations.Required]
        public long ServerRxBytes { get; set; }
        /// <summary>
        /// Number of server_rx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "server_rx_pkts")]
        [System.ComponentModel.DataAnnotations.Required]
        public long ServerRxPkts { get; set; }
        /// <summary>
        /// Number of server_src_port.
        /// </summary>
        [JsonProperty(PropertyName = "server_src_port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerSrcPort { get; set; }
        /// <summary>
        /// Number of server_timeouts.
        /// </summary>
        [JsonProperty(PropertyName = "server_timeouts")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerTimeouts { get; set; }
        /// <summary>
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "server_total_bytes")]
        [System.ComponentModel.DataAnnotations.Required]
        public long ServerTotalBytes { get; set; }
        /// <summary>
        /// Number of server_total_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "server_total_pkts")]
        [System.ComponentModel.DataAnnotations.Required]
        public long ServerTotalPkts { get; set; }
        /// <summary>
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "server_tx_bytes")]
        [System.ComponentModel.DataAnnotations.Required]
        public long ServerTxBytes { get; set; }
        /// <summary>
        /// Number of server_tx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "server_tx_pkts")]
        [System.ComponentModel.DataAnnotations.Required]
        public long ServerTxPkts { get; set; }
        /// <summary>
        /// Number of server_zero_window_size_events.
        /// </summary>
        [JsonProperty(PropertyName = "server_zero_window_size_events")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServerZeroWindowSizeEvents { get; set; }
        /// <summary>
        /// service_engine of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "service_engine")]
        public string? ServiceEngine { get; set; }
        /// <summary>
        /// significance of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "significance")]
        public string? Significance { get; set; }
        /// <summary>
        /// Number of significant.
        /// </summary>
        [JsonProperty(PropertyName = "significant")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Significant { get; set; }
        /// <summary>
        /// List of enums which indicate why a log is significant. Enum options - ADF_CLIENT_CONN_SETUP_REFUSED,
        /// ADF_SERVER_CONN_SETUP_REFUSED, ADF_CLIENT_CONN_SETUP_TIMEDOUT, ADF_SERVER_CONN_SETUP_TIMEDOUT,
        /// ADF_CLIENT_CONN_SETUP_FAILED_INTERNAL, ADF_SERVER_CONN_SETUP_FAILED_INTERNAL, ADF_CLIENT_CONN_SETUP_FAILED_BAD_PACKET,
        /// ADF_UDP_CONN_SETUP_FAILED_INTERNAL, ADF_UDP_SERVER_CONN_SETUP_FAILED_INTERNAL, ADF_CLIENT_SENT_RESET,
        /// ADF_SERVER_SENT_RESET, ADF_CLIENT_CONN_TIMEDOUT, ADF_SERVER_CONN_TIMEDOUT, ADF_USER_DELETE_OPERATION,
        /// ADF_CLIENT_REQUEST_TIMEOUT, ADF_CLIENT_CONN_ABORTED, ADF_CLIENT_SSL_HANDSHAKE_FAILURE, ADF_CLIENT_CONN_FAILED,
        /// ADF_SERVER_CERTIFICATE_VERIFICATION_FAILED, ADF_SERVER_SIDE_SSL_HANDSHAKE_FAILED, ADF_IDLE_TIMEDOUT,
        /// ADF_CLIENT_CONNECTION_CLOSED_BEFORE_REQUEST, ADF_CLIENT_INCOMPLETE_DATA, ADF_CLIENT_CONN_STOPPED,
        /// ADF_CLIENT_HIGH_TIMEOUT_RETRANSMITS, ADF_SERVER_HIGH_TIMEOUT_RETRANSMITS, ADF_CLIENT_HIGH_RX_ZERO_WINDOW_SIZE_EVENTS,
        /// ADF_SERVER_HIGH_RX_ZERO_WINDOW_SIZE_EVENTS, ADF_CLIENT_RTT_ABOVE_SEC, ADF_SERVER_RTT_ABOVE_500MS,
        /// ADF_CLIENT_HIGH_TOTAL_RETRANSMITS, ADF_SERVER_HIGH_TOTAL_RETRANSMITS, ADF_CLIENT_HIGH_OUT_OF_ORDERS,
        /// ADF_SERVER_HIGH_OUT_OF_ORDERS, ADF_CLIENT_HIGH_TX_ZERO_WINDOW_SIZE_EVENTS, ADF_SERVER_HIGH_TX_ZERO_WINDOW_SIZE_EVENTS,
        /// ADF_CLIENT_POSSIBLE_WINDOW_STUCK, ADF_SERVER_POSSIBLE_WINDOW_STUCK, ADF_SERVER_UNANSWERED_SYNS,
        /// ADF_CLIENT_CLOSE_CONNECTION_ON_VS_UPDATE, ADF_CLIENT_POSSIBLE_SLOW_DRAIN, ADF_SERVER_POSSIBLE_SLOW_DRAIN,
        /// ADF_SERVER_INGRESS_LATENCY_EXCEEDED, ADF_SERVER_CONN_EST_TIME_EXCEEDED, ADF_CLIENT_INGRESS_LATENCY_EXCEEDED,
        /// ADF_CLIENT_CONN_EST_TIME_EXCEEDED, ADF_RESPONSE_CODE_4XX, ADF_RESPONSE_CODE_5XX, ADF_LOAD_BALANCING_FAILED,
        /// ADF_DATASCRIPT_EXECUTION_FAILED, ADF_REQUEST_NO_POOL, ADF_RATE_LIMIT_DROP_CLIENT_IP, ADF_RATE_LIMIT_DROP_URI,
        /// ADF_RATE_LIMIT_DROP_CLIENT_IP_URI, ADF_RATE_LIMIT_DROP_UNKNOWN_URI, ADF_RATE_LIMIT_DROP_BAD_URI,
        /// ADF_REQUEST_VIRTUAL_HOSTING_APP_SELECT_FAILED, ADF_RATE_LIMIT_DROP_UNKNOWN_CIP, ADF_RATE_LIMIT_DROP_BAD_CIP,
        /// ADF_RATE_LIMIT_DROP_CLIENT_IP_BAD, ADF_RATE_LIMIT_DROP_URI_BAD, ADF_RATE_LIMIT_DROP_CLIENT_IP_URI_BAD,
        /// ADF_RATE_LIMIT_DROP_REQ, ADF_RATE_LIMIT_DROP_CLIENT_IP_CONN, ADF_RATE_LIMIT_DROP_CONN, ADF_RATE_LIMIT_DROP_HEADER,
        /// ADF_RATE_LIMIT_DROP_CUSTOM, ADF_RATE_LIMIT_DROP_URI_SCAN_BAD, ADF_RATE_LIMIT_DROP_URI_SCAN_UNKNOWN,
        /// ADF_RATE_LIMIT_DROP_CIP_SCAN_BAD, ADF_RATE_LIMIT_DROP_CIP_SCAN_UNKNOWN, ADF_HTTP_VERSION_LT_1_0,
        /// ADF_CLIENT_HIGH_RESPONSE_TIME, ADF_SERVER_HIGH_RESPONSE_TIME, ADF_PERSISTENT_SERVER_CHANGE, ADF_DOS_SERVER_BAD_GATEWAY,
        /// ADF_DOS_SERVER_GATEWAY_TIMEOUT, ADF_DOS_CLIENT_SENT_RESET, ADF_DOS_CLIENT_CONN_TIMEOUT, ADF_DOS_CLIENT_REQUEST_TIMEOUT,
        /// ADF_DOS_CLIENT_CONN_ABORTED, ADF_DOS_CLIENT_BAD_REQUEST, ADF_DOS_CLIENT_REQUEST_ENTITY_TOO_LARGE,
        /// ADF_DOS_CLIENT_REQUEST_URI_TOO_LARGE, ADF_DOS_CLIENT_REQUEST_HEADER_TOO_LARGE, ADF_DOS_CLIENT_CLOSED_REQUEST,
        /// ADF_DOS_SSL_ERROR, ADF_REQUEST_MEMORY_LIMIT_EXCEEDED, ADF_DOS_CLIENT_CONN_STOPPED,
        /// ADF_X509_CLIENT_CERTIFICATE_VERIFICATION_FAILED, ADF_X509_CLIENT_CERTIFICATE_NOT_YET_VALID,
        /// ADF_X509_CLIENT_CERTIFICATE_EXPIRED, ADF_X509_CLIENT_CERTIFICATE_REVOKED, ADF_X509_CLIENT_CERTIFICATE_INVALID_CA,
        /// ADF_X509_CLIENT_CERTIFICATE_CRL_NOT_PRESENT, ADF_X509_CLIENT_CERTIFICATE_CRL_NOT_YET_VALID,
        /// ADF_X509_CLIENT_CERTIFICATE_CRL_EXPIRED, ADF_X509_CLIENT_CERTIFICATE_CRL_ERROR,
        /// ADF_X509_CLIENT_CERTIFICATE_CHAINING_ERROR, ADF_X509_CLIENT_CERTIFICATE_INTERNAL_ERROR,
        /// ADF_X509_CLIENT_CERTIFICATE_FORMAT_ERROR, ADF_UDP_PORT_NOT_REACHABLE, ADF_UDP_CONN_TIMEOUT,
        /// ADF_X509_SERVER_CERTIFICATE_VERIFICATION_FAILED, ADF_X509_SERVER_CERTIFICATE_NOT_YET_VALID,
        /// ADF_X509_SERVER_CERTIFICATE_EXPIRED, ADF_X509_SERVER_CERTIFICATE_REVOKED, ADF_X509_SERVER_CERTIFICATE_INVALID_CA,
        /// ADF_X509_SERVER_CERTIFICATE_CRL_NOT_PRESENT, ADF_X509_SERVER_CERTIFICATE_CRL_NOT_YET_VALID,
        /// ADF_X509_SERVER_CERTIFICATE_CRL_EXPIRED, ADF_X509_SERVER_CERTIFICATE_CRL_ERROR,
        /// ADF_X509_SERVER_CERTIFICATE_CHAINING_ERROR, ADF_X509_SERVER_CERTIFICATE_INTERNAL_ERROR,
        /// ADF_X509_SERVER_CERTIFICATE_FORMAT_ERROR, ADF_X509_SERVER_CERTIFICATE_HOSTNAME_ERROR, ADF_SSL_R_BAD_CHANGE_CIPHER_SPEC,
        /// ADF_SSL_R_BLOCK_CIPHER_PAD_IS_WRONG, ADF_SSL_R_DIGEST_CHECK_FAILED, ADF_SSL_R_ERROR_IN_RECEIVED_CIPHER_LIST,
        /// ADF_SSL_R_EXCESSIVE_MESSAGE_SIZE, ADF_SSL_R_LENGTH_MISMATCH, ADF_SSL_R_NO_CIPHERS_PASSED,
        /// ADF_SSL_R_NO_CIPHERS_SPECIFIED, ADF_SSL_R_NO_COMPRESSION_SPECIFIED, ADF_SSL_R_NO_SHARED_CIPHER,
        /// ADF_SSL_R_RECORD_LENGTH_MISMATCH, ADF_SSL_R_PARSE_TLSEXT, ADF_SSL_R_UNEXPECTED_MESSAGE, ADF_SSL_R_UNEXPECTED_RECORD,
        /// ADF_SSL_R_UNKNOWN_ALERT_TYPE, ADF_SSL_R_UNKNOWN_PROTOCOL, ADF_SSL_R_WRONG_VERSION_NUMBER,
        /// ADF_SSL_R_DECRYPTION_FAILED_OR_BAD_RECORD_MAC, ADF_SSL_R_RENEGOTIATE_EXT_TOO_LONG, ADF_SSL_R_RENEGOTIATION_ENCODING_ERR,
        /// ADF_SSL_R_RENEGOTIATION_MISMATCH, ADF_SSL_R_UNSAFE_LEGACY_RENEGOTIATION_DISABLED,
        /// ADF_SSL_R_SCSV_RECEIVED_WHEN_RENEGOTIATING, ADF_SSL_R_INAPPROPRIATE_FALLBACK, ADF_SSL_R_SSLV3_ALERT_UNEXPECTED_MESSAGE,
        /// ADF_SSL_R_SSLV3_ALERT_BAD_RECORD_MAC, ADF_SSL_R_TLSV1_ALERT_DECRYPTION_FAILED, ADF_SSL_R_TLSV1_ALERT_RECORD_OVERFLOW,
        /// ADF_SSL_R_SSLV3_ALERT_DECOMPRESSION_FAILURE, ADF_SSL_R_SSLV3_ALERT_HANDSHAKE_FAILURE,
        /// ADF_SSL_R_SSLV3_ALERT_NO_CERTIFICATE, ADF_SSL_R_SSLV3_ALERT_BAD_CERTIFICATE,
        /// ADF_SSL_R_SSLV3_ALERT_UNSUPPORTED_CERTIFICATE, ADF_SSL_R_SSLV3_ALERT_CERTIFICATE_REVOKED,
        /// ADF_SSL_R_SSLV3_ALERT_CERTIFICATE_EXPIRED, ADF_SSL_R_SSLV3_ALERT_CERTIFICATE_UNKNOWN,
        /// ADF_SSL_R_SSLV3_ALERT_ILLEGAL_PARAMETER, ADF_SSL_R_TLSV1_ALERT_UNKNOWN_CA, ADF_SSL_R_TLSV1_ALERT_ACCESS_DENIED,
        /// ADF_SSL_R_TLSV1_ALERT_DECODE_ERROR, ADF_SSL_R_TLSV1_ALERT_DECRYPT_ERROR, ADF_SSL_R_TLSV1_ALERT_EXPORT_RESTRICTION,
        /// ADF_SSL_R_TLSV1_ALERT_PROTOCOL_VERSION, ADF_SSL_R_TLSV1_ALERT_INSUFFICIENT_SECURITY,
        /// ADF_SSL_R_TLSV1_ALERT_INTERNAL_ERROR, ADF_SSL_R_TLSV1_ALERT_USER_CANCELLED, ADF_SSL_R_TLSV1_ALERT_NO_RENEGOTIATION,
        /// ADF_SSL_OCSP_CERT_STATUS_REVOKED, ADF_SSL_OCSP_RESPONSE_STALE, ADF_SSL_OCSP_RESPONSE_UNAVAILABLE,
        /// ADF_SSL_OCSP_CERT_STATUS_ISSUER_REVOKED, ADF_SSL_R_NO_CIPHERS_AVAILABLE, ADF_CLIENT_AUTH_UNKNOWN_USER,
        /// ADF_CLIENT_AUTH_LOGIN_FAILED, ADF_CLIENT_AUTH_MISSING_CREDENTIALS, ADF_CLIENT_AUTH_SERVER_CONN_ERROR,
        /// ADF_CLIENT_AUTH_USER_NOT_AUTHORIZED, ADF_CLIENT_AUTH_TIMED_OUT, ADF_CLIENT_AUTH_UNKNOWN_ERROR,
        /// ADF_CLIENT_DNS_FAILED_INVALID_QUERY, ADF_CLIENT_DNS_FAILED_INVALID_DOMAIN, ADF_CLIENT_DNS_FAILED_NO_SERVICE,
        /// ADF_CLIENT_DNS_FAILED_GS_DOWN, ADF_CLIENT_DNS_FAILED_NO_VALID_GS_MEMBER, ADF_SERVER_DNS_ERROR_RESPONSE,
        /// ADF_CLIENT_DNS_FAILED_UNSUPPORTED_QUERY, ADF_MEMORY_EXHAUSTED, ADF_CLIENT_DNS_POLICY_DROP, ADF_CLIENT_DNS_RL_POLICY_HIT,
        /// ADF_WAF_MATCH, ADF_CLIENT_BAD_BOT_CLASSIFICATION, ADF_CLIENT_DANGEROUS_BOT_CLASSIFICATION, ADF_HTTP2_CLIENT_TIMEDOUT,
        /// ADF_HTTP2_PROXY_PROTOCOL_ERROR, ADF_HTTP2_INVALID_CONNECTION_PREFACE,
        /// ADF_HTTP2_CLIENT_INVALID_DATA_FRAME_INCORRECT_LENGTH, ADF_HTTP2_CLIENT_PADDED_DATA_FRAME_WITH_INCORRECT_LENGTH,
        /// ADF_HTTP2_CLIENT_VIOLATED_CONN_FLOW_CONTROL, ADF_HTTP2_CLIENT_VIOLATED_STREAM_FLOW_CONTROL,
        /// ADF_HTTP2_CLIENT_DATA_FRAME_HALF_CLOSED_STREAM, ADF_HTTP2_CLIENT_HEADERS_FRAME_WITH_INCORRECT_LENGTH,
        /// ADF_HTTP2_CLIENT_HEADERS_FRAME_WITH_EMPTY_HEADER_BLOCK, ADF_HTTP2_CLIENT_PADDED_HEADERS_FRAME_WITH_INCORRECT_LENGTH,
        /// ADF_HTTP2_CLIENT_HEADERS_FRAME_INCORRECT_IDENTIFIER, ADF_HTTP2_CLIENT_HEADERS_FRAME_STREAM_INCORRECT_DEPENDENCY,
        /// ADF_HTTP2_CONCURRENT_STREAMS_EXCEEDED, ADF_HTTP2_CLIENT_STREAM_DATA_BEFORE_ACK_SETTINGS,
        /// ADF_HTTP2_CLIENT_HEADER_BLOCK_TOO_LONG_SIZE_UPDATE, ADF_HTTP2_CLIENT_HEADER_BLOCK_TOO_LONG_HEADER_INDEX,
        /// ADF_HTTP2_CLIENT_HEADER_BLOCK_INCORRECT_LENGTH, ADF_HTTP2_CLIENT_INVALID_HPACK_TABLE_INDEX,
        /// ADF_HTTP2_CLIENT_OUT_OF_BOUND_HPACK_TABLE_INDEX, ADF_HTTP2_CLIENT_INVALID_TABLE_SIZE_UPDATE,
        /// ADF_HTTP2_CLIENT_HEADER_FIELD_TOO_LONG_LENGTH_VALUE, ADF_HTTP2_CLIENT_EXCEEDED_HTTP2_MAX_FIELD_SIZE_LIMIT,
        /// ADF_HTTP2_CLIENT_INVALID_ENCODED_HEADER_FIELD, ADF_HTTP2_CLIENT_EXCEEDED_HTTP2_MAX_HEADER_SIZE_LIMIT,
        /// ADF_HTTP2_CLIENT_INVALID_HEADER_NAME, ADF_HTTP2_CLIENT_HEADER_WITH_INVALID_VALUE,
        /// ADF_HTTP2_CLIENT_UNKNOWN_PSEUDO_HEADER, ADF_HTTP2_CLIENT_DUPLICATE_PATH_HEADER, ADF_HTTP2_CLIENT_EMPTY_PATH_HEADER,
        /// ADF_HTTP2_CLIENT_INVALID_PATH_HEADER, ADF_HTTP2_CLIENT_DUPLICATE_METHOD_HEADER, ADF_HTTP2_CLIENT_EMPTY_METHOD_HEADER,
        /// ADF_HTTP2_CLIENT_INVALID_METHOD_HEADER, ADF_HTTP2_CLIENT_DUPLICATE_SCHEME_HEADER, ADF_HTTP2_CLIENT_EMPTY_SCHEME_HEADER,
        /// ADF_HTTP2_CLIENT_NO_METHOD_HEADER, ADF_HTTP2_CLIENT_NO_SCHEME_HEADER, ADF_HTTP2_CLIENT_NO_PATH_HEADER,
        /// ADF_HTTP2_CLIENT_PREMATURELY_CLOSED_STREAM, ADF_HTTP2_CLIENT_PREMATURELY_CLOSED_CONNECTION,
        /// ADF_HTTP2_CLIENT_LARGER_DATA_BODY_THAN_DECLARED, ADF_HTTP2_CLIENT_LARGE_CHUNKED_BODY, ADF_HTTP2_NEGATIVE_WINDOW_UPDATE,
        /// ADF_HTTP2_SEND_WINDOW_FLOW_CONTROL_ERROR, ADF_HTTP2_CLIENT_UNEXPECTED_CONTINUATION_FRAME,
        /// ADF_HTTP2_CLIENT_WINDOW_UPDATE_INCORRECT_LENGTH, ADF_HTTP2_CLIENT_WINDOW_UPDATE_FRAME_INCORRECT_INCREMENT,
        /// ADF_HTTP2_CLIENT_WINDOW_UPDATE_FRAME_INCREMENT_NOT_ALLOWED_FOR_WINDOW, ADF_HTTP2_CLIENT_GOAWAY_FRAME_INCORRECT_LENGTH,
        /// ADF_HTTP2_CLIENT_PING_FRAME_INCORRECT_LENGTH, ADF_HTTP2_CLIENT_PUSH_PROMISE,
        /// ADF_HTTP2_CLIENT_SETTINGS_FRAME_INCORRECT_MAX_FRAME_SIZE, ADF_HTTP2_CLIENT_SETTINGS_FRAME_INCORRECT_INIIAL_WINDOW_SIZE,
        /// ADF_HTTP2_CLIENT_SETTINGS_FRAME_INCORRECT_LENGTH, ADF_HTTP2_CLIENT_SETTINGS_FRAME_ACK_FLAG_NONZERO_LENGTH,
        /// ADF_HTTP2_CLIENT_RST_STREAM_FRAME_INCORRECT_LENGTH, ADF_HTTP2_CLIENT_RST_STREAM_FRAME_INCORRECT_IDENTIFIER,
        /// ADF_HTTP2_CLIENT_PRIORITY_FRAME_INCORRECT_DEPENDENCY, ADF_HTTP2_CLIENT_PRIORITY_FRAME_INCORRECT_IDENTIFIER,
        /// ADF_HTTP2_CLIENT_PRIORITY_FRAME_INCORRECT_LENGTH, ADF_HTTP2_CLIENT_CONTINUATION_FRAME_INCORRECT_IDENTIFIER,
        /// ADF_HTTP2_CLIENT_CONTINUATION_FRAME_EXPECTED_INAPPROPRIATE_FRAME, ADF_HTTP2_CLIENT_INVALID_HEADER,
        /// ADF_HTTP2_CLIENT_UNEXPECTED_DATA_FRAME, ADF_HTTP2_CLIENT_UNEXPECTED_RST_FRAME,
        /// ADF_HTTP2_CLIENT_UNEXPECTED_WINDOW_UPDATE_FRAME, ADF_HTTP2_CLIENT_SENT_PING_NONZERO_ID,
        /// ADF_HTTP2_CLIENT_SENT_SETTINGS_NONZERO_ID, ADF_HTTP2_CLIENT_SENT_GOAWAY_NONZERO_ID,
        /// ADF_HTTP2_CLIENT_HEADER_FRAME_UNEXPECTED_PSEUDO_HEADER, ADF_HTTP2_CLIENT_DATA_FRAME_INCORRECT_IDENTIFIER,
        /// ADF_HTTP2_CLIENT_HEADER_FRAME_CONNECTION_SPECIFIC_HDR, ADF_HTTP2_CLIENT_HEADER_FRAME_INCORRECT_TE_HDR,
        /// ADF_HTTP2_CLIENT_CONTROL_FRAME_FLOOD_DETECTED, ADF_HTTP2_FRAME_TO_CLIENT_FLOOD_DETECTED,
        /// ADF_HTTP2_CLIENT_EMPTY_DATA_FRAME_FLOOD_DETECTED, ADF_HTTP2_CLIENT_ZERO_HEAD_NAME,
        /// ADF_HTTP2_CLIENT_EXCEEDED_HTTP2_MAX_SINGLE_HEADER_SIZE_LIMIT, ADF_USER_DELETE_OPERATION_DATASCRIPT_RESET_CONN,
        /// ADF_USER_DELETE_OPERATION_HTTP_RULE_SECURITY_ACTION_CLOSE_CONN,
        /// ADF_USER_DELETE_OPERATION_HTTP_RULE_SECURITY_RATE_LIMIT_ACTION_CLOSE_CONN,
        /// ADF_USER_DELETE_OPERATION_HTTP_RULE_MISSING_TOKEN_ACTION_CLOSE_CONN, ADF_HTTP_BAD_REQUEST_INVALID_HOST_IN_REQUEST_LINE,
        /// ADF_HTTP_BAD_REQUEST_RECEIVED_VERSION_LESS_THAN_10, ADF_HTTP_NOT_ALLOWED_DATASCRIPT_RESPONSE_RETURNED_4XX,
        /// ADF_HTTP_NOT_ALLOWED_RUM_FLAGGED_INVALID_METHOD, ADF_HTTP_CONTENT_LENGTH_HDR_WITH_UNSUPPORTED_METHOD,
        /// ADF_HTTP_NOT_ALLOWED_UNSUPPORTED_TRACE_METHOD, ADF_HTTP_REQUEST_TIMEOUT_WAITING_FOR_CLIENT,
        /// ADF_HTTP_BAD_REQUEST_CLIENT_SENT_INVALID_CONTENT_LENGTH, ADF_HTTP_BAD_REQUEST_CLIENT_SENT_HTTP11_WITHOUT_HOST_HDR,
        /// ADF_HTTP_BAD_REQUEST_FAILED_TO_PARSE_URI, ADF_HTTP_BAD_REQUEST_INVALID_HEADER_LINE,
        /// ADF_HTTP_BAD_REQUEST_ERROR_WHILE_READING_CLIENT_HEADERS, ADF_HTTP_BAD_REQUEST_CLIENT_SENT_DUPLICATE_HEADER,
        /// ADF_HTTP_BAD_REQUEST_CLIENT_SENT_INVALID_HOST_HEADER, ADF_HTTP_NOT_IMPLEMENTED_CLIENT_SENT_UNKNOWN_TRANSFER_ENCODING,
        /// ADF_HTTP_BAD_REQUEST_REQUESTED_SERVER_NAME_DIFFERS, ADF_HTTP_BAD_REQUEST_CLIENT_SENT_INVALID_CHUNKED_BODY,
        /// ADF_HTTP_BAD_REQUEST_INVALID_HEADER_IN_SPDY, ADF_HTTP_BAD_REQUEST_INVALID_HEADER_BLOCK_IN_SPDY,
        /// ADF_HTTP_BAD_REQUEST_DATA_ERROR_IN_SPDY, ADF_HTTP_BAD_REQUEST_NO_METHOD_URI_OR_PROT_IN_REQ_CREATE_SPDY,
        /// ADF_HTTP_BAD_REQUEST_CLIENT_PREMATURELY_CLOSED_SPDY_STREAM, ADF_HTTP_BAD_REQUEST_DATA_ERROR_IN_SPDY_READ_REQ_BODY,
        /// ADF_HTTP_BAD_REQUEST_CERT_ERROR, ADF_HTTP_BAD_REQUEST_PLAIN_HTTP_REQUEST_SENT_ON_HTTPS_PORT,
        /// ADF_HTTP_BAD_REQUEST_PLAIN_HTTP_REQUEST_SENT_ON_HTTPS_PORT_RESET_CONN, ADF_HTTP_BAD_REQUEST_NO_CERT_ERROR,
        /// ADF_HTTP_BAD_REQUEST_HEADER_TOO_LARGE, ADF_SERVER_HIGH_RESPONSE_TIME_L7, ADF_SERVER_HIGH_RESPONSE_TIME_L4,
        /// ADF_COOKIE_SIZE_GREATER_THAN_MAX, ADF_COOKIE_SIZE_LESS_THAN_MIN_COOKIE_LEN, ADF_PERSISTENCE_PROFILE_KEYS_NOT_CONFIGURED,
        /// ADF_PERSISTENCE_COOKIE_VERSION_MISMATCH, ADF_COOKIE_ABSENT_FROM_KEYS_IN_PERSISTENCE_PROFILE,
        /// ADF_GSLB_SITE_PERSISTENCE_REMOTE_SITE_DOWN, ADF_HTTP_NOT_ALLOWED_DATASCRIPT_RESPONSE_RETURNED_5XX,
        /// ADF_SERVER_UPSTREAM_TIMEOUT, ADF_SERVER_UPSTREAM_READ_ERROR, ADF_SERVER_UPSTREAM_RESOLVER_ERROR,
        /// ADF_SIP_INVALID_MESSAGE_FROM_CLIENT, ADF_SIP_MESSAGE_UPDATE_FAILED, ADF_SIP_SERVER_UNKNOWN_CALLID,
        /// ADF_SIP_REQUEST_FAILED, ADF_SIP_REQUEST_TIMEDOUT, ADF_SIP_CONN_IDLE_TIMEDOUT, ADF_SIP_TRANSACTION_TIMEDOUT,
        /// ADF_SIP_SVR_UDP_PORT_NOT_REACHABLE, ADF_SIP_CLT_UDP_PORT_NOT_REACHABLE, ADF_SIP_INVALID_MESSAGE_FROM_SERVER,
        /// ADF_L4_DATASCRIPT_DROP, ADF_DATASCRIPT_SIGNIFICANCE, ADF_SAML_COOKIE_VERSION_MISMATCH,
        /// ADF_SAML_COOKIE_KEYS_NOT_CONFIGURED, ADF_SAML_COOKIE_ABSENT_FROM_KEYS_IN_SAML_AUTH_POLICY, ADF_SAML_COOKIE_INVALID,
        /// ADF_SAML_COOKIE_DECRYPTION_ERROR, ADF_SAML_COOKIE_ENCRYPTION_ERROR, ADF_SAML_COOKIE_DECODE_ERROR,
        /// ADF_SAML_COOKIE_SESSION_COOKIE_GREATER_THAN_MAX, ADF_SAML_COOKIE_HANDSHAKE_COOKIE_GREATER_THAN_MAX,
        /// ADF_SAML_ASSERTION_DOES_NOT_MATCH_REQUEST_ID, ADF_SAML_AUTHENTICATION_UNSUPPORTED_METHOD,
        /// ADF_SAML_COOKIE_SESSION_COOKIE_TIMEOUT, ADF_SAML_ACS_URL_MISMATCH, ADF_SAML_ASSERTION_NO_BODY,
        /// ADF_SAML_ASSERTION_INVALID, ADF_SAML_ASSERTION_ATTRIBUTE_ERROR, ADF_SAML_LOGIN_ERROR,
        /// ADF_SAML_DECRYPT_ASSERTION_FAILURE, ADF_SAML_LASSO_PROFILE_ERROR_INVALID_MSG,
        /// ADF_SAML_LASSO_PROFILE_ERROR_MISSING_STATUS_CODE, ADF_SAML_LASSO_LOGIN_ERROR_REQUEST_DENIED,
        /// ADF_SAML_LASSO_LOGIN_ERROR_STATUS_NOT_SUCCESS, ADF_SAML_LASSO_PROFILE_ERROR_UNSUPPORTED_PROFILE,
        /// ADF_SAML_LASSO_PROFILE_ERROR_MISSING_RESPONSE, ADF_SAML_LASSO_LOGIN_ERROR_ASSERTION_REPLAY,
        /// ADF_SAML_LASSO_PROFILE_ERROR_MISSING_NAME_IDENTIFIER, ADF_SAML_LASSO_PROFILE_ERROR_MISSING_SERVER,
        /// ADF_SAML_LASSO_PROFILE_ERROR_INVALID_REQUEST, ADF_SAML_AUTHENTICATION_ERROR, ADF_SAML_AUTHENTICATION_RULE_NOMATCH,
        /// ADF_SAML_AUTHORIZATION_RULE_NOMATCH, ADF_SAML_AUTHENTICATION_SKIPPED_RULE_MATCH,
        /// ADF_SAML_AUTHORIZATION_FAILED_RULE_MATCH, ADF_SAML_AUTHENTICATION_DISABLED_BY_DS, ADF_SSO_AUTHENTICATION_RULE_NOMATCH,
        /// ADF_SSO_AUTHORIZATION_RULE_NOMATCH, ADF_SSO_AUTHENTICATION_SKIPPED_RULE_MATCH, ADF_SSO_AUTHORIZATION_FAILED_RULE_MATCH,
        /// ADF_SAML_AUTH_INVALID_POST_REQUEST, ADF_HTTP_SERVER_RESELECT_OCCURRENCE,
        /// ADF_HTTP_SERVER_RESELECT_SKIP_V1_SERVER_AFTER_SENT_V2_REQ, ADF_HTTP_SERVER_RESELECT_SKIP_V2_SERVER_AFTER_SENT_V1_REQ,
        /// ADF_HTTP_RULE_SECURITY_RATE_LIMIT_ACTION_REPORT, ADF_HTTP_RULE_SECURITY_RATE_LIMIT_ACTION_REDIRECT,
        /// ADF_HTTP_RULE_SECURITY_RATE_LIMIT_ACTION_RESPONSE, ADF_HTTP_RULE_REDIRECT_ACTION_FAILED,
        /// ADF_HTTP_RULE_REDIRECT_ACTION_FAILED_WITH_IP_ADDRESS, ADF_HTTP2_SERVER_SENT_UNEXPECTED_FRAME,
        /// ADF_HTTP2_SERVER_SENT_FRAME_UNKNOWN_STREAM, ADF_HTTP2_SERVER_REJECTED_REQUEST_WITH_ERROR,
        /// ADF_HTTP2_SERVER_SENT_GOAWAY_WITH_ERROR, ADF_HTTP2_SERVER_SENT_UNEXPECTED_PUSH_PROMISE,
        /// ADF_HTTP2_SERVER_SENT_INVALID_HEADER, ADF_HTTP2_SERVER_SENT_DUP_STATUS_HEADER,
        /// ADF_HTTP2_SERVER_SENT_INVALID_STATUS_HEADER, ADF_HTTP2_SERVER_SENT_LARGE_HEADER_NAME_LEN,
        /// ADF_HTTP2_SERVER_NO_STATUS_HEADER, ADF_HTTP2_SERVER_SENT_DATA_FOR_UNKNOWN_STREAM,
        /// ADF_HTTP2_SERVER_STREAM_FLOW_CONTROL_VIOLATION, ADF_HTTP2_SERVER_CONN_FLOW_CONTROL_VIOLATION,
        /// ADF_HTTP2_SERVER_SENT_INVALID_TRAILER, ADF_HTTP2_SERVER_SENT_TRAILER_NO_ENDSTREAM_FLAG,
        /// ADF_HTTP2_SERVER_SENT_SHORT_FRAME, ADF_HTTP2_SERVER_SENT_FRAME_LONG_PADDING, ADF_HTTP2_SERVER_SENT_LARGE_FRAME,
        /// ADF_HTTP2_SERVER_SENT_FRAME_INVALID_LENGTH, ADF_HTTP2_SERVER_SENT_TRUNCATED_HEADER,
        /// ADF_HTTP2_SERVER_SENT_INVALID_TABLE_INDEX, ADF_HTTP2_SERVER_SENT_INVALID_TABLE_SIZE_UPDATE,
        /// ADF_HTTP2_SERVER_SENT_TABLE_INDEX_CONT_FLAG, ADF_HTTP2_SERVER_SENT_ZERO_HEADER_NAME_LEN,
        /// ADF_HTTP2_SERVER_SENT_INVALID_ENCODED_HEADER, ADF_HTTP2_SERVER_SENT_RST_INVALID_LENGTH,
        /// ADF_HTTP2_SERVER_SENT_GOAWAY_NONZERO_ID, ADF_HTTP2_SERVER_SENT_GOAWAY_INVALID_LEN,
        /// ADF_HTTP2_SERVER_SENT_WIN_UPDATE_INVALID_LEN, ADF_HTTP2_SERVER_SENT_WIN_UPDATE_LARGE_LEN,
        /// ADF_HTTP2_SERVER_SENT_SETTINGS_NONZERO_ID, ADF_HTTP2_SERVER_SENT_SETTINGS_ACK_NONZERO_ID,
        /// ADF_HTTP2_SERVER_SENT_SETTINGS_INVALID_LEN, ADF_HTTP2_SERVER_SENT_SETTING_LARGE_INI_WIN_SIZE,
        /// ADF_HTTP2_SERVER_SENT_PING_NONZERO_ID, ADF_HTTP2_SERVER_SENT_PING_INVALID_LEN, ADF_HTTP2_SERVER_SENT_PING_ACK,
        /// ADF_HTTP2_SERVER_NO_UPSTREAM_KEEPALIVE, ADF_HTTP2_CLIENT_SENT_TRAILER, ADF_HTTP2_CLIENT_SENT_UNSUPPORTED_PROTOCOL_HDR,
        /// ADF_HTTP2_WEBSOCKET_IS_NOT_ENABLED, ADF_HTTP2_WEBSOCKET_DETECTED, ADF_HTTP2_CLIENT_SENT_PROTOCOL_HDR_WITH_WRONG_METHOD,
        /// ADF_HTTP2_WEBSOCKET_VERSION_MISMATCH, ADF_HTTP2_BAD_REQUEST_CLIENT_SENT_NO_HOST_HEADER,
        /// ADF_HTTP_CONTENT_REWRITE_EMPTY_STRING, ADF_HTTP2_SERVER_SIDE_SSL_ALPN_FAILURE, ADF_HTTP2_SERVER_DOES_NOT_SUPPORT_V2,
        /// ADF_HTTP2_MAX_REQUESTS_EXCEEDED, ADF_HTTP2_SERVER_CONTROL_FRAME_FLOOD_DETECTED,
        /// ADF_HTTP2_SERVER_EXCEEDED_HTTP2_MAX_FIELD_SIZE_LIMIT, ADF_HTTP2_SERVER_OUT_OF_BOUND_HPACK_TABLE_INDEX,
        /// ADF_HTTP2_CLIENT_HPACK_LARGE_HEADER, ADF_HTTP2_SERVER_HPACK_LARGE_HEADER,
        /// ADF_HTTP2_SERVER_HEADER_BLOCK_TOO_LONG_HEADER_INDEX, ADF_HTTP2_UPSTREAM_NO_SUPPORT_DYNAMIC_TABLE,
        /// ADF_HTTP2_UPSTREAM_NO_SUPPORT_DYNAMIC_TABLE_ON_CACHE, ADF_PERSISTENCE_APP_COOKIE_INVALID_EXPIRY_TIMESTAMP,
        /// ADF_PERSISTENCE_COOKIE_EXPIRED, ADF_SITE_PERSISTENCE_COOKIE_EXPIRED, ADF_ICAP_SERVER_HIGH_RESPONSE_TIME,
        /// ADF_ICAP_BLOCKED, ADF_ICAP_MODIFIED, ADF_ICAP_OUT_OF_MEMORY, ADF_ICAP_TIMEDOUT,
        /// ADF_ICAP_BODY_SIZE_BIGGER_THAN_CONFIGURED, ADF_ICAP_CONNECTION_ERROR, ADF_ICAP_SERVER_ERROR, ADF_ICAP_FAILED,
        /// ADF_HTTP_BAD_REQUEST_INVALID_REQUEST_LINE, ADF_HTTP_BAD_RESPONSE_INVALID_REQUEST_LINE,
        /// ADF_LDAP_AUTHENTICATION_DISABLED_BY_DS, ADF_PAA_AUTHENTICATION_DISABLED_BY_DS, ADF_JWT_MISSING_BEARER_TOKEN,
        /// ADF_JWT_MISSING_AUTHORIZATION_HEADER, ADF_JWT_MISSING_QUERY_PARAMS, ADF_JWT_EMPTY_TOKEN_IN_QUERY_PARAM,
        /// ADF_JWT_QUERY_PARAMS_MISSING_TOKEN_NAME, ADF_JWT_EMPTY_TOKEN_HEADERS, ADF_JWT_EMPTY_TOKEN_PAYLOAD,
        /// ADF_JWT_AUD_CLAIM_NULL, ADF_JWT_AUD_MISMATCH, ADF_JWT_ISSUER_CLAIM_NULL, ADF_JWT_UNKNOWN_ISSUER, ADF_JWT_KID_NULL,
        /// ADF_JWT_INVALID_KID, ADF_JWT_ALG_NULL, ADF_JWT_ALG_MISMATCH, ADF_JWT_NOT_YET_VALID, ADF_JWT_EXPIRED,
        /// ADF_JWT_SIGNATURE_VERIFICATION_FAILURE, ADF_JWT_VALIDATION_DISABLED_BY_DS, ADF_JWT_INVALID_JWKS,
        /// ADF_HTTP_CONNECTION_STRATEGY_CONVERTED, ADF_HTTP_NTLM_AUTHENTICATION_FAILED,
        /// ADF_HTTP_NTLM_NEGOTIATION_RESPONSE_DECODE_FAIL, ADF_HTTP_NTLM_NEGOTIATION_RESPONSE_WRONG_SIG,
        /// ADF_HTTP_NTLM_NEGOTIATION_RESPONSE_WRONG_MESSAGE, ADF_HTTP_NTLM_NEGOTIATION_REQUEST_DECODE_FAIL,
        /// ADF_HTTP_NTLM_NEGOTIATION_REQUEST_WRONG_SIG, ADF_HTTP_NTLM_NEGOTIATION_REQUEST_WRONG_MESSAGE,
        /// ADF_HTTP_UNEXPECTED_RUM_REQUEST, ADF_HTTP_NTLM_REQUEST_QUEUEING_DISABLED, ADF_HTTP_NTLM_SERVER_RESELECT_DISABLED,
        /// ADF_HTTP_NTLM_POOL_SWITCHED, ADF_HTTP_NTLM_CONNECTION_DETECTED, ADF_REQUEST_URI_INVALID_UTF8_FORMAT,
        /// ADF_REQUEST_ARGS_INVALID_UTF8_FORMAT, ADF_REQUEST_CHUNK_MODE_WITH_CONTENT_LENGTH,
        /// ADF_HTTP2_H2C_UPGRADE_NO_HTTP2_SETTINGS, ADF_HTTP2_H2C_UPGRADE_HTTP2_SETTINGS_ERR, ADF_HTTP2_H2C_UPGRADE_REQUEST,
        /// ADF_HTTP2_H2C_UPGRADE_TO_HTTP2, ADF_HTTP2_H2C_UPGRADE_OPTIONS_REQUEST, ADF_HTTP2_H2C_UPGRADE_OPTIONS_REQUEST_WITH_BODY,
        /// ADF_HTTP2_INVALID_VERSION, ADF_HTTP2_INVALID_CHUNKED_BODY, ADF_SERVER_RESPONSE_HEADER_TOO_LARGE,
        /// ADF_HTTP_CLIENT_EXCEEDED_MAX_HEADER_SIZE_LIMIT, ADF_HTTP_CLIENT_EXCEEDED_MAX_SINGLE_HEADER_SIZE_LIMIT,
        /// ADF_HTTP_BAD_REQUEST_REQUESTED_HOST_NAME_DOES_NOT_MATCH_SERVERNAME, ADF_OAUTH_INVALID_REQUEST, ADF_OAUTH_INVALID_CLIENT,
        /// ADF_OAUTH_INVALID_GRANT, ADF_OAUTH_UNAUTHORIZED_CLIENT, ADF_OAUTH_UNAUTHORIZED_GRANT_TYPE, ADF_OAUTH_INVALID_SCOPE,
        /// ADF_OAUTH_ACCESS_DENIED, ADF_OAUTH_UNSUPPORTED_RESPONSE_TYPE, ADF_OAUTH_HANDSHAKE_UNAUTHORIZED_CLIENT,
        /// ADF_OAUTH_SERVER_ERROR, ADF_OAUTH_TEMPORARILY_UNAVAILABLE, ADF_OAUTH_OIDC_INVALID_ALG, ADF_OAUTH_OIDC_INVALID_AT_HASH,
        /// ADF_OAUTH_AUTHORIZATION_FAILED_RULE_MATCH, ADF_OAUTH_OIDC_JWT_AZP_MISMATCH, ADF_OAUTH_OIDC_JWT_AZP_CLAIM_INVALID,
        /// ADF_OAUTH_COOKIE_VERSION_MISMATCH, ADF_OAUTH_COOKIE_KEYS_NOT_CONFIGURED, ADF_OAUTH_COOKIE_ENCRYPTION_ERROR,
        /// ADF_OAUTH_AUTHENTICATION_SKIPPED_RULE_MATCH, ADF_OAUTH_TOKEN_EXCHANGE_FAIL, ADF_OAUTH_USERINFO_FAIL,
        /// ADF_OAUTH_JWKS_URI_FAIL, ADF_OAUTH_INTROSPECT_FAIL, ADF_OAUTH_NULL_COOKIE, ADF_OAUTH_INVALID_HS_REDIRECT_URI,
        /// ADF_OAUTH_INVALID_COOKIE, ADF_OAUTH_ACCESS_TOKEN_INACTIVE.
        /// </summary>
        [JsonProperty(PropertyName = "significant_log")]
        public IList<string> SignificantLog { get; set; }
        /// <summary>
        /// SIP related logging information. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_log")]
        public NSXTALBSipLogType SipLog { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sni_hostname")]
        public string? SniHostname { get; set; }
        /// <summary>
        /// ssl_cipher of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_cipher")]
        public string? SslCipher { get; set; }
        /// <summary>
        /// ssl_session_id of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_session_id")]
        public string? SslSessionId { get; set; }
        /// <summary>
        /// ssl_version of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_version")]
        public string? SslVersion { get; set; }
        /// <summary>
        /// Number of start_timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "start_timestamp")]
        [System.ComponentModel.DataAnnotations.Required]
        public long StartTimestamp { get; set; }
        /// <summary>
        /// Number of timeouts.
        /// </summary>
        [JsonProperty(PropertyName = "timeouts")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Timeouts { get; set; }
        /// <summary>
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "total_bytes")]
        public long? TotalBytes { get; set; }
        /// <summary>
        /// Number of total_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "total_pkts")]
        public long? TotalPkts { get; set; }
        /// <summary>
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "total_time")]
        public long? TotalTime { get; set; }
        /// <summary>
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "tx_bytes")]
        [System.ComponentModel.DataAnnotations.Required]
        public long TxBytes { get; set; }
        /// <summary>
        /// Number of tx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "tx_pkts")]
        [System.ComponentModel.DataAnnotations.Required]
        public long TxPkts { get; set; }
        /// <summary>
        /// Placeholder for description of property udf of obj type ConnectionLog field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "udf")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Udf { get; set; }
        /// <summary>
        /// Number of vcpu_id.
        /// </summary>
        [JsonProperty(PropertyName = "vcpu_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public int VcpuId { get; set; }
        /// <summary>
        /// virtualservice of ConnectionLog.
        /// </summary>
        [JsonProperty(PropertyName = "virtualservice")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Virtualservice { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_ip")]
        public int? VsIp { get; set; }
        /// <summary>
        /// IPv6 address of the VIP of the VS. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_ip6")]
        public string? VsIp6 { get; set; }
        /// <summary>
        /// Number of zero_window_size_events.
        /// </summary>
        [JsonProperty(PropertyName = "zero_window_size_events")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ZeroWindowSizeEvents { get; set; }
    }
}
