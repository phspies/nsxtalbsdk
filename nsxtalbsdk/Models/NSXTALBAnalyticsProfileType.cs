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
    public class NSXTALBAnalyticsProfileType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// If a client receives an HTTP response in less than the Satisfactory Latency Threshold, the request is considered
        /// Satisfied. It is considered Tolerated if it is not Satisfied and less than Tolerated Latency Factor multiplied by the
        /// Satisfactory Latency Threshold. Greater than this number and the client's request is considered Frustrated. Allowed
        /// values are 1-30000. Unit is MILLISECONDS. Allowed in Basic(Allowed values- 500) edition, Essentials(Allowed values- 500)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_response_threshold")]
        public int? ApdexResponseThreshold { get; set; }
        /// <summary>
        /// Client tolerated response latency factor. Client must receive a response within this factor times the satisfactory
        /// threshold (apdex_response_threshold) to be considered tolerated. Allowed values are 1-1000. Allowed in Basic(Allowed
        /// values- 4) edition, Essentials(Allowed values- 4) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_response_tolerated_factor")]
        public double? ApdexResponseToleratedFactor { get; set; }
        /// <summary>
        /// Satisfactory client to Avi Round Trip Time(RTT). Allowed values are 1-2000. Unit is MILLISECONDS. Allowed in
        /// Basic(Allowed values- 250) edition, Essentials(Allowed values- 250) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_rtt_threshold")]
        public int? ApdexRttThreshold { get; set; }
        /// <summary>
        /// Tolerated client to Avi Round Trip Time(RTT) factor.  It is a multiple of apdex_rtt_tolerated_factor. Allowed values are
        /// 1-1000. Allowed in Basic(Allowed values- 4) edition, Essentials(Allowed values- 4) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_rtt_tolerated_factor")]
        public double? ApdexRttToleratedFactor { get; set; }
        /// <summary>
        /// If a client is able to load a page in less than the Satisfactory Latency Threshold, the PageLoad is considered
        /// Satisfied.  It is considered tolerated if it is greater than Satisfied but less than the Tolerated Latency multiplied by
        /// Satisifed Latency. Greater than this number and the client's request is considered Frustrated.  A PageLoad includes the
        /// time for DNS lookup, download of all HTTP objects, and page render time. Allowed values are 1-30000. Unit is
        /// MILLISECONDS. Allowed in Basic(Allowed values- 5000) edition, Essentials(Allowed values- 5000) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_rum_threshold")]
        public int? ApdexRumThreshold { get; set; }
        /// <summary>
        /// Virtual service threshold factor for tolerated Page Load Time (PLT) as multiple of apdex_rum_threshold. Allowed values
        /// are 1-1000. Allowed in Basic(Allowed values- 4) edition, Essentials(Allowed values- 4) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_rum_tolerated_factor")]
        public double? ApdexRumToleratedFactor { get; set; }
        /// <summary>
        /// A server HTTP response is considered Satisfied if latency is less than the Satisfactory Latency Threshold. The response
        /// is considered tolerated when it is greater than Satisfied but less than the Tolerated Latency Factor * S_Latency. 
        /// Greater than this number and the server response is considered Frustrated. Allowed values are 1-30000. Unit is
        /// MILLISECONDS. Allowed in Basic(Allowed values- 400) edition, Essentials(Allowed values- 400) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_server_response_threshold")]
        public int? ApdexServerResponseThreshold { get; set; }
        /// <summary>
        /// Server tolerated response latency factor. Servermust response within this factor times the satisfactory threshold
        /// (apdex_server_response_threshold) to be considered tolerated. Allowed values are 1-1000. Allowed in Basic(Allowed
        /// values- 4) edition, Essentials(Allowed values- 4) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_server_response_tolerated_factor")]
        public double? ApdexServerResponseToleratedFactor { get; set; }
        /// <summary>
        /// Satisfactory client to Avi Round Trip Time(RTT). Allowed values are 1-2000. Unit is MILLISECONDS. Allowed in
        /// Basic(Allowed values- 125) edition, Essentials(Allowed values- 125) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_server_rtt_threshold")]
        public int? ApdexServerRttThreshold { get; set; }
        /// <summary>
        /// Tolerated client to Avi Round Trip Time(RTT) factor.  It is a multiple of apdex_rtt_tolerated_factor. Allowed values are
        /// 1-1000. Allowed in Basic(Allowed values- 4) edition, Essentials(Allowed values- 4) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "apdex_server_rtt_tolerated_factor")]
        public double? ApdexServerRttToleratedFactor { get; set; }
        /// <summary>
        /// Configure which logs are sent to the Avi Controller from SEs and how they are processed.
        /// </summary>
        [JsonProperty(PropertyName = "client_log_config")]
        public NSXTALBClientLogConfigurationType ClientLogConfig { get; set; }
        /// <summary>
        /// Configure to stream logs to an external server. Field introduced in 17.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "client_log_streaming_config")]
        public NSXTALBClientLogStreamingConfigType ClientLogStreamingConfig { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// A connection between client and Avi is considered lossy when more than this percentage of out of order packets are
        /// received. Allowed values are 1-100. Unit is PERCENT. Allowed in Basic(Allowed values- 50) edition, Essentials(Allowed
        /// values- 50) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_lossy_ooo_threshold")]
        public int? ConnLossyOooThreshold { get; set; }
        /// <summary>
        /// A connection between client and Avi is considered lossy when more than this percentage of packets are retransmitted due
        /// to timeout. Allowed values are 1-100. Unit is PERCENT. Allowed in Basic(Allowed values- 20) edition, Essentials(Allowed
        /// values- 20) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_lossy_timeo_rexmt_threshold")]
        public int? ConnLossyTimeoRexmtThreshold { get; set; }
        /// <summary>
        /// A connection between client and Avi is considered lossy when more than this percentage of packets are retransmitted.
        /// Allowed values are 1-100. Unit is PERCENT. Allowed in Basic(Allowed values- 50) edition, Essentials(Allowed values- 50)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_lossy_total_rexmt_threshold")]
        public int? ConnLossyTotalRexmtThreshold { get; set; }
        /// <summary>
        /// A client connection is considered lossy when percentage of times a packet could not be trasmitted due to TCP zero window
        /// is above this threshold. Allowed values are 0-100. Unit is PERCENT. Allowed in Basic(Allowed values- 2) edition,
        /// Essentials(Allowed values- 2) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_lossy_zero_win_size_event_threshold")]
        public int? ConnLossyZeroWinSizeEventThreshold { get; set; }
        /// <summary>
        /// A connection between Avi and server is considered lossy when more than this percentage of out of order packets are
        /// received. Allowed values are 1-100. Unit is PERCENT. Allowed in Basic(Allowed values- 50) edition, Essentials(Allowed
        /// values- 50) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_server_lossy_ooo_threshold")]
        public int? ConnServerLossyOooThreshold { get; set; }
        /// <summary>
        /// A connection between Avi and server is considered lossy when more than this percentage of packets are retransmitted due
        /// to timeout. Allowed values are 1-100. Unit is PERCENT. Allowed in Basic(Allowed values- 20) edition, Essentials(Allowed
        /// values- 20) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_server_lossy_timeo_rexmt_threshold")]
        public int? ConnServerLossyTimeoRexmtThreshold { get; set; }
        /// <summary>
        /// A connection between Avi and server is considered lossy when more than this percentage of packets are retransmitted.
        /// Allowed values are 1-100. Unit is PERCENT. Allowed in Basic(Allowed values- 50) edition, Essentials(Allowed values- 50)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_server_lossy_total_rexmt_threshold")]
        public int? ConnServerLossyTotalRexmtThreshold { get; set; }
        /// <summary>
        /// A server connection is considered lossy when percentage of times a packet could not be trasmitted due to TCP zero window
        /// is above this threshold. Allowed values are 0-100. Unit is PERCENT. Allowed in Basic(Allowed values- 2) edition,
        /// Essentials(Allowed values- 2) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "conn_server_lossy_zero_win_size_event_threshold")]
        public int? ConnServerLossyZeroWinSizeEventThreshold { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Virtual Service (VS) metrics are processed only when there is live data traffic on the VS. In case, VS is idle for a
        /// period of time as specified by ondemand_metrics_idle_timeout then metrics processing is suspended for that VS. Field
        /// deprecated in 20.1.3. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_ondemand_metrics")]
        public bool? DisableOndemandMetrics { get; set; }
        /// <summary>
        /// Disable node (service engine) level analytics forvs metrics. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "disable_se_analytics")]
        public bool? DisableSeAnalytics { get; set; }
        /// <summary>
        /// Disable analytics on backend servers. This may be desired in container environment when there are large number of
        /// ephemeral servers. Additionally, no healthscore of servers is computed when server analytics is disabled. Field
        /// deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "disable_server_analytics")]
        public bool? DisableServerAnalytics { get; set; }
        /// <summary>
        /// Disable VirtualService (frontend) Analytics. This flag disables metrics and healthscore for Virtualservice. Field
        /// deprecated in 20.1.3. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_vs_analytics")]
        public bool? DisableVsAnalytics { get; set; }
        /// <summary>
        /// Enable adaptive configuration for optimizing resource usage. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_adaptive_config")]
        public bool? EnableAdaptiveConfig { get; set; }
        /// <summary>
        /// Enables Advanced Analytics features like Anomaly detection. If set to false, anomaly computation (and associated
        /// rules/events) for VS, Pool and Server metrics will be deactivated. However, setting it to false reduces cpu and memory
        /// requirements for Analytics subsystem. Field introduced in 17.2.13, 18.1.5, 18.2.1. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition. Special default for Basic edition is
        /// false, Essentials edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "enable_advanced_analytics")]
        public bool? EnableAdvancedAnalytics { get; set; }
        /// <summary>
        /// Virtual Service (VS) metrics are processed only when there is live data traffic on the VS. In case, VS is idle for a
        /// period of time as specified by ondemand_metrics_idle_timeout then metrics processing is suspended for that VS. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ondemand_metrics")]
        public bool? EnableOndemandMetrics { get; set; }
        /// <summary>
        /// Enable node (service engine) level analytics forvs metrics. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_se_analytics")]
        public bool? EnableSeAnalytics { get; set; }
        /// <summary>
        /// Enables analytics on backend servers. This may be desired in container environment when there are large number of
        /// ephemeral servers. Additionally, no healthscore of servers is computed when server analytics is enabled. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_server_analytics")]
        public bool? EnableServerAnalytics { get; set; }
        /// <summary>
        /// Enable VirtualService (frontend) Analytics. This flag enables metrics and healthscore for Virtualservice. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vs_analytics")]
        public bool? EnableVsAnalytics { get; set; }
        /// <summary>
        /// Exclude client closed connection before an HTTP request could be completed from being classified as an error. Allowed in
        /// Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_client_close_before_request_as_error")]
        public bool? ExcludeClientCloseBeforeRequestAsError { get; set; }
        /// <summary>
        /// Exclude dns policy drops from the list of errors. Field introduced in 17.2.2. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_dns_policy_drop_as_significant")]
        public bool? ExcludeDnsPolicyDropAsSignificant { get; set; }
        /// <summary>
        /// Exclude queries to GSLB services that are operationally down from the list of errors. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_gs_down_as_error")]
        public bool? ExcludeGsDownAsError { get; set; }
        /// <summary>
        /// List of HTTP status codes to be excluded from being classified as an error.  Error connections or responses impacts
        /// health score, are included as significant logs, and may be classified as part of a DoS attack.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_http_error_codes")]
        public int? ExcludeHttpErrorCodes { get; set; }
        /// <summary>
        /// Exclude dns queries to domains outside the domains configured in the DNS application profile from the list of errors.
        /// Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_invalid_dns_domain_as_error")]
        public bool? ExcludeInvalidDnsDomainAsError { get; set; }
        /// <summary>
        /// Exclude invalid dns queries from the list of errors. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed
        /// values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_invalid_dns_query_as_error")]
        public bool? ExcludeInvalidDnsQueryAsError { get; set; }
        /// <summary>
        /// Exclude the Issuer-Revoked OCSP Responses from the list of errors. Field introduced in 20.1.1. Allowed in Basic(Allowed
        /// values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_issuer_revoked_ocsp_responses_as_error")]
        public bool? ExcludeIssuerRevokedOcspResponsesAsError { get; set; }
        /// <summary>
        /// Exclude queries to domains that did not have configured services/records from the list of errors. Allowed in
        /// Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_no_dns_record_as_error")]
        public bool? ExcludeNoDnsRecordAsError { get; set; }
        /// <summary>
        /// Exclude queries to GSLB services that have no available members from the list of errors. Allowed in Basic(Allowed
        /// values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_no_valid_gs_member_as_error")]
        public bool? ExcludeNoValidGsMemberAsError { get; set; }
        /// <summary>
        /// Exclude persistence server changed while load balancing' from the list of errors. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_persistence_change_as_error")]
        public bool? ExcludePersistenceChangeAsError { get; set; }
        /// <summary>
        /// Exclude the Revoked OCSP certificate status responses from the list of errors. Field introduced in 20.1.1. Allowed in
        /// Basic(Allowed values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_revoked_ocsp_responses_as_error")]
        public bool? ExcludeRevokedOcspResponsesAsError { get; set; }
        /// <summary>
        /// Exclude server dns error response from the list of errors. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_server_dns_error_as_error")]
        public bool? ExcludeServerDnsErrorAsError { get; set; }
        /// <summary>
        /// Exclude server TCP reset from errors.  It is common for applications like MS Exchange. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_server_tcp_reset_as_error")]
        public bool? ExcludeServerTcpResetAsError { get; set; }
        /// <summary>
        /// List of SIP status codes to be excluded from being classified as an error. Field introduced in 17.2.13, 18.1.5, 18.2.1.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_sip_error_codes")]
        public int? ExcludeSipErrorCodes { get; set; }
        /// <summary>
        /// Exclude the Stale OCSP certificate status responses from the list of errors. Field introduced in 20.1.1. Allowed in
        /// Basic(Allowed values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_stale_ocsp_responses_as_error")]
        public bool? ExcludeStaleOcspResponsesAsError { get; set; }
        /// <summary>
        /// Exclude 'server unanswered syns' from the list of errors. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_syn_retransmit_as_error")]
        public bool? ExcludeSynRetransmitAsError { get; set; }
        /// <summary>
        /// Exclude TCP resets by client from the list of potential errors. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_tcp_reset_as_error")]
        public bool? ExcludeTcpResetAsError { get; set; }
        /// <summary>
        /// Exclude the unavailable OCSP Responses from the list of errors. Field introduced in 20.1.1. Allowed in Basic(Allowed
        /// values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_unavailable_ocsp_responses_as_error")]
        public bool? ExcludeUnavailableOcspResponsesAsError { get; set; }
        /// <summary>
        /// Exclude unsupported dns queries from the list of errors. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_unsupported_dns_query_as_error")]
        public bool? ExcludeUnsupportedDnsQueryAsError { get; set; }
        /// <summary>
        /// Skips health score computation of pool servers when number of servers in a pool is more than this setting. Allowed
        /// values are 0-5000. Special values are 0- server health score is deactivated. Field introduced in 17.2.13, 18.1.4.
        /// Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition. Special default
        /// for Basic edition is 0, Essentials edition is 0, Enterprise is 20.
        /// </summary>
        [JsonProperty(PropertyName = "healthscore_max_server_limit")]
        public int? HealthscoreMaxServerLimit { get; set; }
        /// <summary>
        /// Time window (in secs) within which only unique health change events should occur. Allowed in Basic(Allowed values-
        /// 1209600) edition, Essentials(Allowed values- 1209600) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_event_throttle_window")]
        public int? HsEventThrottleWindow { get; set; }
        /// <summary>
        /// Maximum penalty that may be deducted from health score for anomalies. Allowed values are 0-100. Allowed in Basic(Allowed
        /// values- 10) edition, Essentials(Allowed values- 10) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_max_anomaly_penalty")]
        public int? HsMaxAnomalyPenalty { get; set; }
        /// <summary>
        /// Maximum penalty that may be deducted from health score for high resource utilization. Allowed values are 0-100. Allowed
        /// in Basic(Allowed values- 25) edition, Essentials(Allowed values- 25) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_max_resources_penalty")]
        public int? HsMaxResourcesPenalty { get; set; }
        /// <summary>
        /// Maximum penalty that may be deducted from health score based on security assessment. Allowed values are 0-100. Allowed
        /// in Basic(Allowed values- 100) edition, Essentials(Allowed values- 100) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_max_security_penalty")]
        public int? HsMaxSecurityPenalty { get; set; }
        /// <summary>
        /// DoS connection rate below which the DoS security assessment will not kick in. Allowed in Basic(Allowed values- 1000)
        /// edition, Essentials(Allowed values- 1000) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_min_dos_rate")]
        public int? HsMinDosRate { get; set; }
        /// <summary>
        /// Adds free performance score credits to health score. It can be used for compensating health score for known slow
        /// applications. Allowed values are 0-100. Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_performance_boost")]
        public int? HsPerformanceBoost { get; set; }
        /// <summary>
        /// Threshold number of connections in 5min, below which apdexr, apdexc, rum_apdex, and other network quality metrics are
        /// not computed. Allowed in Basic(Allowed values- 10) edition, Essentials(Allowed values- 10) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_pscore_traffic_threshold_l4_client")]
        public double? HsPscoreTrafficThresholdL4Client { get; set; }
        /// <summary>
        /// Threshold number of connections in 5min, below which apdexr, apdexc, rum_apdex, and other network quality metrics are
        /// not computed. Allowed in Basic(Allowed values- 10) edition, Essentials(Allowed values- 10) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_pscore_traffic_threshold_l4_server")]
        public double? HsPscoreTrafficThresholdL4Server { get; set; }
        /// <summary>
        /// Score assigned when the certificate has expired. Allowed values are 0-5. Allowed in Basic(Allowed values- 0.0) edition,
        /// Essentials(Allowed values- 0.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_certscore_expired")]
        public double? HsSecurityCertscoreExpired { get; set; }
        /// <summary>
        /// Score assigned when the certificate expires in more than 30 days. Allowed values are 0-5. Allowed in Basic(Allowed
        /// values- 5.0) edition, Essentials(Allowed values- 5.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_certscore_gt30d")]
        public double? HsSecurityCertscoreGt30d { get; set; }
        /// <summary>
        /// Score assigned when the certificate expires in less than or equal to 7 days. Allowed values are 0-5. Allowed in
        /// Basic(Allowed values- 2.0) edition, Essentials(Allowed values- 2.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_certscore_le07d")]
        public double? HsSecurityCertscoreLe07d { get; set; }
        /// <summary>
        /// Score assigned when the certificate expires in less than or equal to 30 days. Allowed values are 0-5. Allowed in
        /// Basic(Allowed values- 4.0) edition, Essentials(Allowed values- 4.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_certscore_le30d")]
        public double? HsSecurityCertscoreLe30d { get; set; }
        /// <summary>
        /// Penalty for allowing certificates with invalid chain. Allowed values are 0-5. Allowed in Basic(Allowed values- 1.0)
        /// edition, Essentials(Allowed values- 1.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_chain_invalidity_penalty")]
        public double? HsSecurityChainInvalidityPenalty { get; set; }
        /// <summary>
        /// Score assigned when the minimum cipher strength is 0 bits. Allowed values are 0-5. Allowed in Basic(Allowed values- 0.0)
        /// edition, Essentials(Allowed values- 0.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_cipherscore_eq000b")]
        public double? HsSecurityCipherscoreEq000b { get; set; }
        /// <summary>
        /// Score assigned when the minimum cipher strength is greater than equal to 128 bits. Allowed values are 0-5. Allowed in
        /// Basic(Allowed values- 5.0) edition, Essentials(Allowed values- 5.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_cipherscore_ge128b")]
        public double? HsSecurityCipherscoreGe128b { get; set; }
        /// <summary>
        /// Score assigned when the minimum cipher strength is less than 128 bits. Allowed values are 0-5. Allowed in Basic(Allowed
        /// values- 3.5) edition, Essentials(Allowed values- 3.5) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_cipherscore_lt128b")]
        public double? HsSecurityCipherscoreLt128b { get; set; }
        /// <summary>
        /// Score assigned when no algorithm is used for encryption. Allowed values are 0-5. Allowed in Basic(Allowed values- 0.0)
        /// edition, Essentials(Allowed values- 0.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_encalgo_score_none")]
        public double? HsSecurityEncalgoScoreNone { get; set; }
        /// <summary>
        /// Score assigned when RC4 algorithm is used for encryption. Allowed values are 0-5. Allowed in Basic(Allowed values- 2.5)
        /// edition, Essentials(Allowed values- 2.5) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_encalgo_score_rc4")]
        public double? HsSecurityEncalgoScoreRc4 { get; set; }
        /// <summary>
        /// Penalty for not enabling HSTS. Allowed values are 0-5. Allowed in Basic(Allowed values- 1.0) edition, Essentials(Allowed
        /// values- 1.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_hsts_penalty")]
        public double? HsSecurityHstsPenalty { get; set; }
        /// <summary>
        /// Penalty for allowing non-PFS handshakes. Allowed values are 0-5. Allowed in Basic(Allowed values- 1.0) edition,
        /// Essentials(Allowed values- 1.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_nonpfs_penalty")]
        public double? HsSecurityNonpfsPenalty { get; set; }
        /// <summary>
        /// Score assigned when OCSP Certificate Status is set to Revoked or Issuer Revoked. Allowed values are 0.0-5.0. Field
        /// introduced in 20.1.1. Allowed in Basic(Allowed values- 0.0) edition, Essentials(Allowed values- 0.0) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_ocsp_revoked_score")]
        public double? HsSecurityOcspRevokedScore { get; set; }
        /// <summary>
        /// Deprecated. Allowed values are 0-5. Allowed in Basic(Allowed values- 1.0) edition, Essentials(Allowed values- 1.0)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_selfsignedcert_penalty")]
        public double? HsSecuritySelfsignedcertPenalty { get; set; }
        /// <summary>
        /// Score assigned when supporting SSL3.0 encryption protocol. Allowed values are 0-5. Allowed in Basic(Allowed values- 3.5)
        /// edition, Essentials(Allowed values- 3.5) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_ssl30_score")]
        public double? HsSecuritySsl30Score { get; set; }
        /// <summary>
        /// Score assigned when supporting TLS1.0 encryption protocol. Allowed values are 0-5. Allowed in Basic(Allowed values- 5.0)
        /// edition, Essentials(Allowed values- 5.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_tls10_score")]
        public double? HsSecurityTls10Score { get; set; }
        /// <summary>
        /// Score assigned when supporting TLS1.1 encryption protocol. Allowed values are 0-5. Allowed in Basic(Allowed values- 5.0)
        /// edition, Essentials(Allowed values- 5.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_tls11_score")]
        public double? HsSecurityTls11Score { get; set; }
        /// <summary>
        /// Score assigned when supporting TLS1.2 encryption protocol. Allowed values are 0-5. Allowed in Basic(Allowed values- 5.0)
        /// edition, Essentials(Allowed values- 5.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_tls12_score")]
        public double? HsSecurityTls12Score { get; set; }
        /// <summary>
        /// Score assigned when supporting TLS1.3 encryption protocol. Allowed values are 0-5. Field introduced in 18.2.6. Allowed
        /// in Basic(Allowed values- 5.0) edition, Essentials(Allowed values- 5.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_tls13_score")]
        public double? HsSecurityTls13Score { get; set; }
        /// <summary>
        /// Penalty for allowing weak signature algorithm(s). Allowed values are 0-5. Allowed in Basic(Allowed values- 1.0) edition,
        /// Essentials(Allowed values- 1.0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "hs_security_weak_signature_algo_penalty")]
        public double? HsSecurityWeakSignatureAlgoPenalty { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// Influence the audit of ingress latency and connection establishement time. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "latency_audit_props")]
        public NSXTALBLatencyAuditPropertiesType LatencyAuditProps { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// The name of the analytics profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// This flag sets the time duration of no live data traffic after which Virtual Service metrics processing is suspended. It
        /// is applicable only when enable_ondemand_metrics is set to false. Field introduced in 18.1.1. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "ondemand_metrics_idle_timeout")]
        public int? OndemandMetricsIdleTimeout { get; set; }
        /// <summary>
        /// List of HTTP status code ranges to be excluded from being classified as an error.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBHTTPStatusRangeType> Ranges { get; set; }
        /// <summary>
        /// Block of HTTP response codes to be excluded from being classified as an error. Enum options - AP_HTTP_RSP_4XX,
        /// AP_HTTP_RSP_5XX.
        /// </summary>
        [JsonProperty(PropertyName = "resp_code_block")]
        public IList<string> RespCodeBlock { get; set; }
        /// <summary>
        /// Rules applied to the HTTP application log for filtering sensitive information. Field introduced in 17.2.10, 18.1.2.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sensitive_log_profile")]
        public NSXTALBSensitiveLogProfileType SensitiveLogProfile { get; set; }
        /// <summary>
        /// Maximum number of SIP messages added in logs for a SIP transaction. By default, this value is 20. Allowed values are
        /// 1-1000. Field introduced in 17.2.13, 18.1.5, 18.2.1. Allowed in Basic(Allowed values- 20) edition, Essentials(Allowed
        /// values- 20) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "sip_log_depth")]
        public int? SipLogDepth { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the analytics profile.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
