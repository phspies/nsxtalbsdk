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
    public class NSXTALBIcapRequestLogType 
    {
        /// <summary>
        /// Denotes whether the content was processed by ICAP server and an action was taken. Enum options - ICAP_DISABLED,
        /// ICAP_PASSED, ICAP_MODIFIED, ICAP_BLOCKED, ICAP_FAILED. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Complete request body from client was sent to The ICAP server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "complete_body_sent")]
        public bool? CompleteBodySent { get; set; }
        /// <summary>
        /// The HTTP method of the request. Enum options - HTTP_METHOD_GET, HTTP_METHOD_HEAD, HTTP_METHOD_PUT, HTTP_METHOD_DELETE,
        /// HTTP_METHOD_POST, HTTP_METHOD_OPTIONS, HTTP_METHOD_TRACE, HTTP_METHOD_CONNECT, HTTP_METHOD_PATCH, HTTP_METHOD_PROPFIND,
        /// HTTP_METHOD_PROPPATCH, HTTP_METHOD_MKCOL, HTTP_METHOD_COPY, HTTP_METHOD_MOVE, HTTP_METHOD_LOCK, HTTP_METHOD_UNLOCK.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_method")]
        public string? HttpMethod { get; set; }
        /// <summary>
        /// The HTTP response code received from the ICAP server. HTTP response code is only available if content is blocked. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_response_code")]
        public int? HttpResponseCode { get; set; }
        /// <summary>
        /// The absolute ICAP uri of the request. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "icap_absolute_uri")]
        public string? IcapAbsoluteUri { get; set; }
        /// <summary>
        /// ICAP response headers received from ICAP server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "icap_headers_received_from_server")]
        public string? IcapHeadersReceivedFromServer { get; set; }
        /// <summary>
        /// ICAP request headers sent to ICAP server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "icap_headers_sent_to_server")]
        public string? IcapHeadersSentToServer { get; set; }
        /// <summary>
        /// The ICAP method of the request. Enum options - ICAP_METHOD_REQMOD, ICAP_METHOD_RESPMOD. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "icap_method")]
        public string? IcapMethod { get; set; }
        /// <summary>
        /// The response code received from the ICAP server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "icap_response_code")]
        public int? IcapResponseCode { get; set; }
        /// <summary>
        /// ICAP server IP for this connection. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "icap_server_ip")]
        public int? IcapServerIp { get; set; }
        /// <summary>
        /// ICAP server port for this connection. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "icap_server_port")]
        public int? IcapServerPort { get; set; }
        /// <summary>
        /// Latency added due to ICAP processing. This is the time taken from 1st byte of ICAP request sent to last byte of ICAP
        /// response received. Field introduced in 20.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "latency")]
        public long? Latency { get; set; }
        /// <summary>
        /// Content-Length of the modified content from ICAP server. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "modified_content_length")]
        public int? ModifiedContentLength { get; set; }
        /// <summary>
        /// ICAP log specific to NSX Defender. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_defender_log")]
        public NSXTALBIcapNSXDefenderLogType NsxDefenderLog { get; set; }
        /// <summary>
        /// ICAP log specific to OPSWAT. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "opswat_log")]
        public NSXTALBIcapOPSWATLogType OpswatLog { get; set; }
        /// <summary>
        /// The name of the pool that was used for the request. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// The uuid of the pool that was used for the request. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Blocking reason for the content. It is available only if content was scanned by ICAP server and some violations were
        /// found. Field deprecated in 21.1.1. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// ICAP server IP for this connection. Field deprecated in 20.1.3. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        public NSXTALBIpAddrType ServerIp { get; set; }
        /// <summary>
        /// Source port for this connection. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "source_port")]
        public int? SourcePort { get; set; }
        /// <summary>
        /// Detailed description of the threat found in the content. Available only if request was scanned by ICAP server and some
        /// violations were found. Field deprecated in 20.1.3. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "threat_description")]
        public string? ThreatDescription { get; set; }
        /// <summary>
        /// Short description of the threat found in the content. Available only if content was scanned by ICAP server and some
        /// violations were found. Field deprecated in 21.1.1. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "threat_id")]
        public string? ThreatId { get; set; }
        /// <summary>
        /// Selected ICAP vendor for the request. Enum options - ICAP_VENDOR_GENERIC, ICAP_VENDOR_OPSWAT, ICAP_VENDOR_LASTLINE.
        /// Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vendor")]
        public string? Vendor { get; set; }
        /// <summary>
        /// Threat found in the content.  Available only if content was scanned by ICAP server and some violations were found. Field
        /// deprecated in 21.1.1. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "violations")]
        public IList<NSXTALBIcapViolationType> Violations { get; set; }
    }
}
