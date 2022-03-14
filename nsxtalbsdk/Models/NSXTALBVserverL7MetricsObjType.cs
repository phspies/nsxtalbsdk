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
    public class NSXTALBVserverL7MetricsObjType 
    {
        /// <summary>
        /// Client Apdex measures quality of server response based on latency.
        /// </summary>
        [JsonProperty(PropertyName = "apdexr")]
        public double? Apdexr { get; set; }
        /// <summary>
        /// Average server/application response latency.
        /// </summary>
        [JsonProperty(PropertyName = "avg_application_response_time")]
        public double? AvgApplicationResponseTime { get; set; }
        /// <summary>
        /// Average time client was blocked as reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "avg_blocking_time")]
        public double? AvgBlockingTime { get; set; }
        /// <summary>
        /// Average browser rendering latency.
        /// </summary>
        [JsonProperty(PropertyName = "avg_browser_rendering_time")]
        public double? AvgBrowserRenderingTime { get; set; }
        /// <summary>
        /// Average cache bytes.
        /// </summary>
        [JsonProperty(PropertyName = "avg_cache_bytes")]
        public double? AvgCacheBytes { get; set; }
        /// <summary>
        /// Average cache hit of requests.
        /// </summary>
        [JsonProperty(PropertyName = "avg_cache_hits")]
        public double? AvgCacheHits { get; set; }
        /// <summary>
        /// Average cacheable bytes.
        /// </summary>
        [JsonProperty(PropertyName = "avg_cacheable_bytes")]
        public double? AvgCacheableBytes { get; set; }
        /// <summary>
        /// Average cacheable hit of requests.
        /// </summary>
        [JsonProperty(PropertyName = "avg_cacheable_hits")]
        public double? AvgCacheableHits { get; set; }
        /// <summary>
        /// Average client data transfer time that represents latency of sending response to the client excluding the RTT time .
        /// Higher client data transfer time signifies lower bandwidth  between client and Avi Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "avg_client_data_transfer_time")]
        public double? AvgClientDataTransferTime { get; set; }
        /// <summary>
        /// Average client Round Trip Time.
        /// </summary>
        [JsonProperty(PropertyName = "avg_client_rtt")]
        public double? AvgClientRtt { get; set; }
        /// <summary>
        /// Average client transaction latency computed by adding response latencies across all HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "avg_client_txn_latency")]
        public double? AvgClientTxnLatency { get; set; }
        /// <summary>
        /// Rate of HTTP responses sent per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_complete_responses")]
        public double? AvgCompleteResponses { get; set; }
        /// <summary>
        /// Average client connection latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "avg_connection_time")]
        public double? AvgConnectionTime { get; set; }
        /// <summary>
        /// Average domain lookup latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dns_lookup_time")]
        public double? AvgDnsLookupTime { get; set; }
        /// <summary>
        /// Average Dom content Load Time reported by clients.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dom_content_load_time")]
        public double? AvgDomContentLoadTime { get; set; }
        /// <summary>
        /// Rate of HTTP error responses sent per second. It does not include errors excluded in analytics profile.
        /// </summary>
        [JsonProperty(PropertyName = "avg_error_responses")]
        public double? AvgErrorResponses { get; set; }
        /// <summary>
        /// Rate of HTTP responses excluded as errors based on analytics profile.
        /// </summary>
        [JsonProperty(PropertyName = "avg_errors_excluded")]
        public double? AvgErrorsExcluded { get; set; }
        /// <summary>
        /// Avg number of HTTP requests that completed within frustrated latency.
        /// </summary>
        [JsonProperty(PropertyName = "avg_frustrated_responses")]
        public double? AvgFrustratedResponses { get; set; }
        /// <summary>
        /// Average size of HTTP headers per request. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_http_headers_bytes")]
        public double? AvgHttpHeadersBytes { get; set; }
        /// <summary>
        /// Average number of HTTP headers per request. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_http_headers_count")]
        public double? AvgHttpHeadersCount { get; set; }
        /// <summary>
        /// Average number of HTTP request parameters per request. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_http_params_count")]
        public double? AvgHttpParamsCount { get; set; }
        /// <summary>
        /// Average Page Load time reported by clients.
        /// </summary>
        [JsonProperty(PropertyName = "avg_page_download_time")]
        public double? AvgPageDownloadTime { get; set; }
        /// <summary>
        /// Average Page Load Time reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "avg_page_load_time")]
        public double? AvgPageLoadTime { get; set; }
        /// <summary>
        /// Average number of HTTP request parameters per request, taking into account only requests with parameters. Field
        /// introduced in 17.2.12, 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "avg_params_per_req")]
        public double? AvgParamsPerReq { get; set; }
        /// <summary>
        /// Average size of HTTP POST request. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_post_bytes")]
        public double? AvgPostBytes { get; set; }
        /// <summary>
        /// Average post compression bytes.
        /// </summary>
        [JsonProperty(PropertyName = "avg_post_compression_bytes")]
        public double? AvgPostCompressionBytes { get; set; }
        /// <summary>
        /// Average pre compression bytes.
        /// </summary>
        [JsonProperty(PropertyName = "avg_pre_compression_bytes")]
        public double? AvgPreCompressionBytes { get; set; }
        /// <summary>
        /// Average redirect latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "avg_redirection_time")]
        public double? AvgRedirectionTime { get; set; }
        /// <summary>
        /// Average requests per session measured for closed sessions.
        /// </summary>
        [JsonProperty(PropertyName = "avg_reqs_per_session")]
        public double? AvgReqsPerSession { get; set; }
        /// <summary>
        /// Rate of 1xx HTTP responses sent per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_resp_1xx")]
        public double? AvgResp1xx { get; set; }
        /// <summary>
        /// Rate of 2xx HTTP responses sent per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_resp_2xx")]
        public double? AvgResp2xx { get; set; }
        /// <summary>
        /// Rate of 3xx HTTP responses sent per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_resp_3xx")]
        public double? AvgResp3xx { get; set; }
        /// <summary>
        /// Rate of 4xx HTTP responses sent per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_resp_4xx")]
        public double? AvgResp4xx { get; set; }
        /// <summary>
        /// Rate of 4xx HTTP responses as errors sent by avi. It does not include any error codes excluded in the analytics profile
        /// and pool server errors.
        /// </summary>
        [JsonProperty(PropertyName = "avg_resp_4xx_avi_errors")]
        public double? AvgResp4xxAviErrors { get; set; }
        /// <summary>
        /// Rate of 5xx HTTP responses sent per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_resp_5xx")]
        public double? AvgResp5xx { get; set; }
        /// <summary>
        /// Rate of 5xx HTTP responses as errors sent by avi. It does not include any error codes excluded in the analytics profile
        /// and pool server errors.
        /// </summary>
        [JsonProperty(PropertyName = "avg_resp_5xx_avi_errors")]
        public double? AvgResp5xxAviErrors { get; set; }
        /// <summary>
        /// Total client data transfer time by client.
        /// </summary>
        [JsonProperty(PropertyName = "avg_rum_client_data_transfer_time")]
        public double? AvgRumClientDataTransferTime { get; set; }
        /// <summary>
        /// Avg number of HTTP requests that completed within satisfactory latency.
        /// </summary>
        [JsonProperty(PropertyName = "avg_satisfactory_responses")]
        public double? AvgSatisfactoryResponses { get; set; }
        /// <summary>
        /// Average server Round Trip Time.
        /// </summary>
        [JsonProperty(PropertyName = "avg_server_rtt")]
        public double? AvgServerRtt { get; set; }
        /// <summary>
        /// Average latency from receipt of request to start of response.
        /// </summary>
        [JsonProperty(PropertyName = "avg_service_time")]
        public double? AvgServiceTime { get; set; }
        /// <summary>
        /// Average SSL Sessions using DSA certificate.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_auth_dsa")]
        public double? AvgSslAuthDsa { get; set; }
        /// <summary>
        /// Average SSL Sessions using Elliptic Curve DSA (ECDSA) certificates.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_auth_ecdsa")]
        public double? AvgSslAuthEcdsa { get; set; }
        /// <summary>
        /// Average SSL Sessions using RSA certificate.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_auth_rsa")]
        public double? AvgSslAuthRsa { get; set; }
        /// <summary>
        /// Average SSL Sessions.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_connections")]
        public double? AvgSslConnections { get; set; }
        /// <summary>
        /// Average SSL Exchanges using EC Cerificates without PFS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_ecdsa_non_pfs")]
        public double? AvgSslEcdsaNonPfs { get; set; }
        /// <summary>
        /// Average SSL Exchanges using EC Cerificates and PFS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_ecdsa_pfs")]
        public double? AvgSslEcdsaPfs { get; set; }
        /// <summary>
        /// Average SSL errors due to clients, protocol errors,network errors and handshake timeouts.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_errors")]
        public double? AvgSslErrors { get; set; }
        /// <summary>
        /// Average SSL connections failed due to protocol , network or timeout reasons.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_failed_connections")]
        public double? AvgSslFailedConnections { get; set; }
        /// <summary>
        /// Average SSL handshakes failed due to network errors.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_handshake_network_errors")]
        public double? AvgSslHandshakeNetworkErrors { get; set; }
        /// <summary>
        /// Average SSL handshake failed due to clients or protocol errors.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_handshake_protocol_errors")]
        public double? AvgSslHandshakeProtocolErrors { get; set; }
        /// <summary>
        /// Average new successful SSL sessions.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_handshakes_new")]
        public double? AvgSslHandshakesNew { get; set; }
        /// <summary>
        /// Average SSL Exchanges using Non-PFS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_handshakes_non_pfs")]
        public double? AvgSslHandshakesNonPfs { get; set; }
        /// <summary>
        /// Average SSL Exchanges using PFS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_handshakes_pfs")]
        public double? AvgSslHandshakesPfs { get; set; }
        /// <summary>
        /// Average new successful resumed SSL sessions.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_handshakes_reused")]
        public double? AvgSslHandshakesReused { get; set; }
        /// <summary>
        /// Average SSL handshakes timed out.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_handshakes_timedout")]
        public double? AvgSslHandshakesTimedout { get; set; }
        /// <summary>
        /// Average SSL Exchanges using Diffie-Hellman.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_kx_dh")]
        public double? AvgSslKxDh { get; set; }
        /// <summary>
        /// Average SSL Exchanges using RSA.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_kx_ecdh")]
        public double? AvgSslKxEcdh { get; set; }
        /// <summary>
        /// Average SSL Exchanges using RSA.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_kx_rsa")]
        public double? AvgSslKxRsa { get; set; }
        /// <summary>
        /// Average SSL Exchanges using RSA Cerificates without PFS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_rsa_non_pfs")]
        public double? AvgSslRsaNonPfs { get; set; }
        /// <summary>
        /// Average SSL Exchanges using RSA Cerificates and PFS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_rsa_pfs")]
        public double? AvgSslRsaPfs { get; set; }
        /// <summary>
        /// Average SSL Sessions with version 3.0.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_ver_ssl30")]
        public double? AvgSslVerSsl30 { get; set; }
        /// <summary>
        /// Average SSL Sessions with TLS version 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_ver_tls10")]
        public double? AvgSslVerTls10 { get; set; }
        /// <summary>
        /// Average SSL Sessions with TLS version 1.1.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_ver_tls11")]
        public double? AvgSslVerTls11 { get; set; }
        /// <summary>
        /// Average SSL Sessions with TLS version 1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_ver_tls12")]
        public double? AvgSslVerTls12 { get; set; }
        /// <summary>
        /// Average SSL Sessions with TLS version 1.3. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_ver_tls13")]
        public double? AvgSslVerTls13 { get; set; }
        /// <summary>
        /// Avg number of HTTP requests that completed within tolerated latency.
        /// </summary>
        [JsonProperty(PropertyName = "avg_tolerated_responses")]
        public double? AvgToleratedResponses { get; set; }
        /// <summary>
        /// Average number of client HTTP2 requests received by the Virtual Service per second. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "avg_total_http2_requests")]
        public double? AvgTotalHttp2Requests { get; set; }
        /// <summary>
        /// Average rate of client HTTP requests received by the virtual service per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_total_requests")]
        public double? AvgTotalRequests { get; set; }
        /// <summary>
        /// Average length of HTTP URI per request. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_uri_length")]
        public double? AvgUriLength { get; set; }
        /// <summary>
        /// Average number of transactions per second identified by WAF as attacks. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_attacks")]
        public double? AvgWafAttacks { get; set; }
        /// <summary>
        /// Average number of transactions per second bypassing WAF. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_disabled")]
        public double? AvgWafDisabled { get; set; }
        /// <summary>
        /// Average number of transactions per second evaluated by WAF. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_evaluated")]
        public double? AvgWafEvaluated { get; set; }
        /// <summary>
        /// Average number of requests per second evaluated by WAF in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_evaluated_request_body_phase")]
        public double? AvgWafEvaluatedRequestBodyPhase { get; set; }
        /// <summary>
        /// Average number of requests per second evaluated by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_evaluated_request_header_phase")]
        public double? AvgWafEvaluatedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Average number of responses per second evaluated by WAF in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_evaluated_response_body_phase")]
        public double? AvgWafEvaluatedResponseBodyPhase { get; set; }
        /// <summary>
        /// Average number of responsess per second evaluated by WAF in Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_evaluated_response_header_phase")]
        public double? AvgWafEvaluatedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Average number of transactions per second flagged by WAF. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_flagged")]
        public double? AvgWafFlagged { get; set; }
        /// <summary>
        /// Average number of requests per second flagged (but not rejected) by WAF in Request Body Phase. Field introduced in
        /// 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_flagged_request_body_phase")]
        public double? AvgWafFlaggedRequestBodyPhase { get; set; }
        /// <summary>
        /// Average number of requests per second flagged (but not rejected) by WAF in Request Header Phase. Field introduced in
        /// 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_flagged_request_header_phase")]
        public double? AvgWafFlaggedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Average number of responses per second flagged (but not rejected) by WAF in Response Body Phase. Field introduced in
        /// 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_flagged_response_body_phase")]
        public double? AvgWafFlaggedResponseBodyPhase { get; set; }
        /// <summary>
        /// Average number of responses per second flagged (but not rejected) by WAF in Response Header Phase. Field introduced in
        /// 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_flagged_response_header_phase")]
        public double? AvgWafFlaggedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Average waf latency seen due to WAF Request Body processing. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_latency_request_body_phase")]
        public double? AvgWafLatencyRequestBodyPhase { get; set; }
        /// <summary>
        /// Average waf latency seen due to WAF Request Header processing. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_latency_request_header_phase")]
        public double? AvgWafLatencyRequestHeaderPhase { get; set; }
        /// <summary>
        /// Average waf latency seen due to WAF Response Body processing. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_latency_response_body_phase")]
        public double? AvgWafLatencyResponseBodyPhase { get; set; }
        /// <summary>
        /// Average waf latency seen due to WAF Response Header processing. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_latency_response_header_phase")]
        public double? AvgWafLatencyResponseHeaderPhase { get; set; }
        /// <summary>
        /// Average number of transactions per second matched by WAF rule/rules. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_matched")]
        public double? AvgWafMatched { get; set; }
        /// <summary>
        /// Average number of requests per second matched by WAF in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_matched_request_body_phase")]
        public double? AvgWafMatchedRequestBodyPhase { get; set; }
        /// <summary>
        /// Average number of requests per second matched by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_matched_request_header_phase")]
        public double? AvgWafMatchedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Average number of responses per second matched by WAF in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_matched_response_body_phase")]
        public double? AvgWafMatchedResponseBodyPhase { get; set; }
        /// <summary>
        /// Average number of responses per second matched by WAF in Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_matched_response_header_phase")]
        public double? AvgWafMatchedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Average number of transactions per second rejected by WAF. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_rejected")]
        public double? AvgWafRejected { get; set; }
        /// <summary>
        /// Average number of requests per second rejected by WAF in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_rejected_request_body_phase")]
        public double? AvgWafRejectedRequestBodyPhase { get; set; }
        /// <summary>
        /// Average number of requests per second rejected by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_rejected_request_header_phase")]
        public double? AvgWafRejectedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Average number of responses per second rejected by WAF in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_rejected_response_body_phase")]
        public double? AvgWafRejectedResponseBodyPhase { get; set; }
        /// <summary>
        /// Average number of responses per second rejected by WAF in Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waf_rejected_response_header_phase")]
        public double? AvgWafRejectedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Average Waiting Time reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "avg_waiting_time")]
        public double? AvgWaitingTime { get; set; }
        /// <summary>
        /// Maximum number of concurrent HTTP sessions.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_sessions")]
        public double? MaxConcurrentSessions { get; set; }
        /// <summary>
        /// Maximum number of open SSL sessions.
        /// </summary>
        [JsonProperty(PropertyName = "max_ssl_open_sessions")]
        public double? MaxSslOpenSessions { get; set; }
        /// <summary>
        /// node_obj_id of VserverL7MetricsObj.
        /// </summary>
        [JsonProperty(PropertyName = "node_obj_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NodeObjId { get; set; }
        /// <summary>
        /// Percentage cache hit of requests.
        /// </summary>
        [JsonProperty(PropertyName = "pct_cache_hits")]
        public double? PctCacheHits { get; set; }
        /// <summary>
        /// Percentage cacheable hit of requests.
        /// </summary>
        [JsonProperty(PropertyName = "pct_cacheable_hits")]
        public double? PctCacheableHits { get; set; }
        /// <summary>
        /// Number of HTTP GET requests as a percentage of total requests received. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "pct_get_reqs")]
        public double? PctGetReqs { get; set; }
        /// <summary>
        /// Number of HTTP POST requests as a percentage of total requests received. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "pct_post_reqs")]
        public double? PctPostReqs { get; set; }
        /// <summary>
        /// Percent of 4xx and 5xx responses.
        /// </summary>
        [JsonProperty(PropertyName = "pct_response_errors")]
        public double? PctResponseErrors { get; set; }
        /// <summary>
        /// Percent of SSL connections failured due to protocol , network or timeout reasons.
        /// </summary>
        [JsonProperty(PropertyName = "pct_ssl_failed_connections")]
        public double? PctSslFailedConnections { get; set; }
        /// <summary>
        /// Malicious transactions (Attacks) identified by WAF as the pecentage  of total requests received. Field introduced in
        /// 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "pct_waf_attacks")]
        public double? PctWafAttacks { get; set; }
        /// <summary>
        /// Transactions bypassing WAF as the percentage of total requests received. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "pct_waf_disabled")]
        public double? PctWafDisabled { get; set; }
        /// <summary>
        /// WAF evaluated transactions as the pecentage of total requests received. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "pct_waf_evaluated")]
        public double? PctWafEvaluated { get; set; }
        /// <summary>
        /// WAF flagged transactions as the percentage of total WAF evaluated transactions. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "pct_waf_flagged")]
        public double? PctWafFlagged { get; set; }
        /// <summary>
        /// WAF matched requests as the percentage of total WAF evaluated requests. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "pct_waf_matched")]
        public double? PctWafMatched { get; set; }
        /// <summary>
        /// WAF rejected transactions as the percentage of total WAF evaluated transactions. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "pct_waf_rejected")]
        public double? PctWafRejected { get; set; }
        /// <summary>
        /// Apdex measures quality of server response based on Real User Metric.
        /// </summary>
        [JsonProperty(PropertyName = "rum_apdexr")]
        public double? RumApdexr { get; set; }
        /// <summary>
        /// Protocol strength of SSL ciphers used.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_protocol_strength")]
        public double? SslProtocolStrength { get; set; }
        /// <summary>
        /// Total time taken by server to respond to requesti.
        /// </summary>
        [JsonProperty(PropertyName = "sum_application_response_time")]
        public double? SumApplicationResponseTime { get; set; }
        /// <summary>
        /// Total time client was blocked.
        /// </summary>
        [JsonProperty(PropertyName = "sum_blocking_time")]
        public double? SumBlockingTime { get; set; }
        /// <summary>
        /// Total browser rendering latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_browser_rendering_time")]
        public double? SumBrowserRenderingTime { get; set; }
        /// <summary>
        /// Average client data transfer time computed by adding response latencies across all HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "sum_client_data_transfer_time")]
        public double? SumClientDataTransferTime { get; set; }
        /// <summary>
        /// Sum of all client Round Trip Times for all samples.
        /// </summary>
        [JsonProperty(PropertyName = "sum_client_rtt")]
        public double? SumClientRtt { get; set; }
        /// <summary>
        /// Total client connection latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_connection_time")]
        public double? SumConnectionTime { get; set; }
        /// <summary>
        /// Total domain lookup latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_dns_lookup_time")]
        public double? SumDnsLookupTime { get; set; }
        /// <summary>
        /// Total dom content latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_dom_content_load_time")]
        public double? SumDomContentLoadTime { get; set; }
        /// <summary>
        /// Count of HTTP 400 and 500 errors for a virtual service in a time interval.
        /// </summary>
        [JsonProperty(PropertyName = "sum_errors")]
        public double? SumErrors { get; set; }
        /// <summary>
        /// Number of server sessions closed in this interval.
        /// </summary>
        [JsonProperty(PropertyName = "sum_finished_sessions")]
        public double? SumFinishedSessions { get; set; }
        /// <summary>
        /// Total latency from responses to all the GET requests.
        /// </summary>
        [JsonProperty(PropertyName = "sum_get_client_txn_latency")]
        public double? SumGetClientTxnLatency { get; set; }
        /// <summary>
        /// Total number of HTTP GET requests that were responded satisfactorily within latency threshold.
        /// </summary>
        [JsonProperty(PropertyName = "sum_get_client_txn_latency_bucket1")]
        public double? SumGetClientTxnLatencyBucket1 { get; set; }
        /// <summary>
        /// Total number of HTTP GET requests that were responded beyond latency threshold but within tolerated limits.
        /// </summary>
        [JsonProperty(PropertyName = "sum_get_client_txn_latency_bucket2")]
        public double? SumGetClientTxnLatencyBucket2 { get; set; }
        /// <summary>
        /// Total number of HTTP GET requests.
        /// </summary>
        [JsonProperty(PropertyName = "sum_get_reqs")]
        public double? SumGetReqs { get; set; }
        /// <summary>
        /// Total size of HTTP request headers. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_http_headers_bytes")]
        public double? SumHttpHeadersBytes { get; set; }
        /// <summary>
        /// Total number of HTTP headers across all requests in a given metrics interval. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_http_headers_count")]
        public double? SumHttpHeadersCount { get; set; }
        /// <summary>
        /// Total number of HTTP request parameters. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_http_params_count")]
        public double? SumHttpParamsCount { get; set; }
        /// <summary>
        /// Total samples that had satisfactory page load time.
        /// </summary>
        [JsonProperty(PropertyName = "sum_num_page_load_time_bucket1")]
        public double? SumNumPageLoadTimeBucket1 { get; set; }
        /// <summary>
        /// Total samples that had tolerated page load time.
        /// </summary>
        [JsonProperty(PropertyName = "sum_num_page_load_time_bucket2")]
        public double? SumNumPageLoadTimeBucket2 { get; set; }
        /// <summary>
        /// Total samples used for rum metrics.
        /// </summary>
        [JsonProperty(PropertyName = "sum_num_rum_samples")]
        public double? SumNumRumSamples { get; set; }
        /// <summary>
        /// Total latency from responses to all the requests other than GET or POST.
        /// </summary>
        [JsonProperty(PropertyName = "sum_other_client_txn_latency")]
        public double? SumOtherClientTxnLatency { get; set; }
        /// <summary>
        /// Total number of HTTP requests other than GET or POST that were responded satisfactorily within latency threshold.
        /// </summary>
        [JsonProperty(PropertyName = "sum_other_client_txn_latency_bucket1")]
        public double? SumOtherClientTxnLatencyBucket1 { get; set; }
        /// <summary>
        /// Total number of HTTP requests other than GET or POST that were responded beyond latency threshold but within tolerated
        /// limits.
        /// </summary>
        [JsonProperty(PropertyName = "sum_other_client_txn_latency_bucket2")]
        public double? SumOtherClientTxnLatencyBucket2 { get; set; }
        /// <summary>
        /// Total number of HTTP requests that are not GET or POST requests.
        /// </summary>
        [JsonProperty(PropertyName = "sum_other_reqs")]
        public double? SumOtherReqs { get; set; }
        /// <summary>
        /// Total time to transfer response to client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_page_download_time")]
        public double? SumPageDownloadTime { get; set; }
        /// <summary>
        /// Total Page Load Time reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_page_load_time")]
        public double? SumPageLoadTime { get; set; }
        /// <summary>
        /// Total size of HTTP POST requests. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_post_bytes")]
        public double? SumPostBytes { get; set; }
        /// <summary>
        /// Total latency from responses to all the POST requests.
        /// </summary>
        [JsonProperty(PropertyName = "sum_post_client_txn_latency")]
        public double? SumPostClientTxnLatency { get; set; }
        /// <summary>
        /// Total number of HTTP POST requests that were responded satisfactorily within latency threshold.
        /// </summary>
        [JsonProperty(PropertyName = "sum_post_client_txn_latency_bucket1")]
        public double? SumPostClientTxnLatencyBucket1 { get; set; }
        /// <summary>
        /// Total number of HTTP POST requests that were responded beyond latency threshold but within tolerated limits.
        /// </summary>
        [JsonProperty(PropertyName = "sum_post_client_txn_latency_bucket2")]
        public double? SumPostClientTxnLatencyBucket2 { get; set; }
        /// <summary>
        /// Total number of HTTP POST requests.
        /// </summary>
        [JsonProperty(PropertyName = "sum_post_reqs")]
        public double? SumPostReqs { get; set; }
        /// <summary>
        /// Total redirect latency reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_redirection_time")]
        public double? SumRedirectionTime { get; set; }
        /// <summary>
        /// Total number of requests served across server sessions closed in the interval.
        /// </summary>
        [JsonProperty(PropertyName = "sum_reqs_finished_sessions")]
        public double? SumReqsFinishedSessions { get; set; }
        /// <summary>
        /// Total number of HTTP requests containing at least one parameter. Field introduced in 17.2.12, 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "sum_reqs_with_params")]
        public double? SumReqsWithParams { get; set; }
        /// <summary>
        /// Total number of HTTP 1XX responses.
        /// </summary>
        [JsonProperty(PropertyName = "sum_resp_1xx")]
        public double? SumResp1xx { get; set; }
        /// <summary>
        /// Total number of HTTP 2XX responses.
        /// </summary>
        [JsonProperty(PropertyName = "sum_resp_2xx")]
        public double? SumResp2xx { get; set; }
        /// <summary>
        /// Total number of HTTP 3XX responses.
        /// </summary>
        [JsonProperty(PropertyName = "sum_resp_3xx")]
        public double? SumResp3xx { get; set; }
        /// <summary>
        /// Total number of HTTP 4XX error responses.
        /// </summary>
        [JsonProperty(PropertyName = "sum_resp_4xx")]
        public double? SumResp4xx { get; set; }
        /// <summary>
        /// Total number of HTTP 5XX error responses.
        /// </summary>
        [JsonProperty(PropertyName = "sum_resp_5xx")]
        public double? SumResp5xx { get; set; }
        /// <summary>
        /// Total client data transfer time by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_rum_client_data_transfer_time")]
        public double? SumRumClientDataTransferTime { get; set; }
        /// <summary>
        /// Sum of all server Round Trip Times for all samples.
        /// </summary>
        [JsonProperty(PropertyName = "sum_server_rtt")]
        public double? SumServerRtt { get; set; }
        /// <summary>
        /// Total time from receipt of request to start of response.
        /// </summary>
        [JsonProperty(PropertyName = "sum_service_time")]
        public double? SumServiceTime { get; set; }
        /// <summary>
        /// Total number of HTTP responses sent.
        /// </summary>
        [JsonProperty(PropertyName = "sum_total_responses")]
        public double? SumTotalResponses { get; set; }
        /// <summary>
        /// Total length of HTTP request URIs. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_uri_length")]
        public double? SumUriLength { get; set; }
        /// <summary>
        /// Total number of transactions identified by WAF as attacks. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_attacks")]
        public double? SumWafAttacks { get; set; }
        /// <summary>
        /// Total number of requests bypassing WAF. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_disabled")]
        public double? SumWafDisabled { get; set; }
        /// <summary>
        /// Total number of requests evaluated by WAF in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_evaluated_request_body_phase")]
        public double? SumWafEvaluatedRequestBodyPhase { get; set; }
        /// <summary>
        /// Total number of requests evaluated by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_evaluated_request_header_phase")]
        public double? SumWafEvaluatedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Total number of responses evaluated by WAF in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_evaluated_response_body_phase")]
        public double? SumWafEvaluatedResponseBodyPhase { get; set; }
        /// <summary>
        /// Total number of responses evaluated by WAF in Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_evaluated_response_header_phase")]
        public double? SumWafEvaluatedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Total number of transactions (requests or responses) flagged as attack by WAF. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_flagged")]
        public double? SumWafFlagged { get; set; }
        /// <summary>
        /// Total number of requests flagged (but not rejected) by WAF in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_flagged_request_body_phase")]
        public double? SumWafFlaggedRequestBodyPhase { get; set; }
        /// <summary>
        /// Total number of requests flagged (but not rejected) by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_flagged_request_header_phase")]
        public double? SumWafFlaggedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Total number of responses flagged (but not rejected) by WAF in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_flagged_response_body_phase")]
        public double? SumWafFlaggedResponseBodyPhase { get; set; }
        /// <summary>
        /// Total number of responses flagged (but not rejected) by WAF in Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_flagged_response_header_phase")]
        public double? SumWafFlaggedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Total latency seen by all evaluated requests in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_latency_request_body_phase")]
        public double? SumWafLatencyRequestBodyPhase { get; set; }
        /// <summary>
        /// Total latency seen by all transactions evaluated by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_latency_request_header_phase")]
        public double? SumWafLatencyRequestHeaderPhase { get; set; }
        /// <summary>
        /// Total latency seen by all evaluated responses in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_latency_response_body_phase")]
        public double? SumWafLatencyResponseBodyPhase { get; set; }
        /// <summary>
        /// Total latency seen by all evaluated responsess in WAF Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_latency_response_header_phase")]
        public double? SumWafLatencyResponseHeaderPhase { get; set; }
        /// <summary>
        /// Total number of requests matched by WAF in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_matched_request_body_phase")]
        public double? SumWafMatchedRequestBodyPhase { get; set; }
        /// <summary>
        /// Total number of requests matched by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_matched_request_header_phase")]
        public double? SumWafMatchedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Total number of responses matched by WAF in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_matched_response_body_phase")]
        public double? SumWafMatchedResponseBodyPhase { get; set; }
        /// <summary>
        /// Total number of responses matched by WAF in Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_matched_response_header_phase")]
        public double? SumWafMatchedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Total number of transactions (requests or responses) rejected by WAF. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_rejected")]
        public double? SumWafRejected { get; set; }
        /// <summary>
        /// Total number of requests rejected by WAF in Request Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_rejected_request_body_phase")]
        public double? SumWafRejectedRequestBodyPhase { get; set; }
        /// <summary>
        /// Total number of requests rejected by WAF in Request Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_rejected_request_header_phase")]
        public double? SumWafRejectedRequestHeaderPhase { get; set; }
        /// <summary>
        /// Total number of responses rejected by WAF in Response Body Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_rejected_response_body_phase")]
        public double? SumWafRejectedResponseBodyPhase { get; set; }
        /// <summary>
        /// Total number of responses rejected by WAF in Response Header Phase. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waf_rejected_response_header_phase")]
        public double? SumWafRejectedResponseHeaderPhase { get; set; }
        /// <summary>
        /// Total waiting reported by client.
        /// </summary>
        [JsonProperty(PropertyName = "sum_waiting_time")]
        public double? SumWaitingTime { get; set; }
    }
}
