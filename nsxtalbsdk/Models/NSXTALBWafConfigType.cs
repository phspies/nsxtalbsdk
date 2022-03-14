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
    public class NSXTALBWafConfigType 
    {
        /// <summary>
        /// WAF allowed HTTP Versions. Enum options - ZERO_NINE, ONE_ZERO, ONE_ONE, TWO_ZERO. Field introduced in 17.2.1. Maximum of
        /// 8 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_http_versions")]
        public IList<string> AllowedHttpVersions { get; set; }
        /// <summary>
        /// WAF allowed HTTP methods. Enum options - HTTP_METHOD_GET, HTTP_METHOD_HEAD, HTTP_METHOD_PUT, HTTP_METHOD_DELETE,
        /// HTTP_METHOD_POST, HTTP_METHOD_OPTIONS, HTTP_METHOD_TRACE, HTTP_METHOD_CONNECT, HTTP_METHOD_PATCH, HTTP_METHOD_PROPFIND,
        /// HTTP_METHOD_PROPPATCH, HTTP_METHOD_MKCOL, HTTP_METHOD_COPY, HTTP_METHOD_MOVE, HTTP_METHOD_LOCK, HTTP_METHOD_UNLOCK.
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_methods")]
        public IList<string> AllowedMethods { get; set; }
        /// <summary>
        /// Allowed request content type character sets in WAF. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_request_content_type_charsets")]
        public IList<string> AllowedRequestContentTypeCharsets { get; set; }
        /// <summary>
        /// WAF allowed Content Types. Field deprecated in 21.1.3. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_request_content_types")]
        public IList<string> AllowedRequestContentTypes { get; set; }
        /// <summary>
        /// Argument seperator. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "argument_separator")]
        public string? ArgumentSeparator { get; set; }
        /// <summary>
        /// Enable to buffer response body for inspection. Field deprecated in 18.2.2. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "buffer_response_body_for_inspection")]
        public bool? BufferResponseBodyForInspection { get; set; }
        /// <summary>
        /// Maximum size for the client request body for file uploads. Allowed values are 1-32768. Field deprecated in 18.1.5. Field
        /// introduced in 17.2.1. Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "client_file_upload_max_body_size")]
        public int? ClientFileUploadMaxBodySize { get; set; }
        /// <summary>
        /// Maximum size for the client request body for non-file uploads. Allowed values are 1-32768. Field deprecated in 18.1.5.
        /// Field introduced in 17.2.1. Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "client_nonfile_upload_max_body_size")]
        public int? ClientNonfileUploadMaxBodySize { get; set; }
        /// <summary>
        /// Maximum size for the client request body scanned by WAF. Allowed values are 1-32768. Field introduced in 18.1.5, 18.2.1.
        /// Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "client_request_max_body_size")]
        public int? ClientRequestMaxBodySize { get; set; }
        /// <summary>
        /// Deprecated (Moved to WafPolicy). Configure thresholds for confidence labels. Field deprecated in 20.1.1. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "confidence_override")]
        public NSXTALBAppLearningConfidenceOverrideType ConfidenceOverride { get; set; }
        /// <summary>
        /// WAF Content-Types and their request body parsers. Use this field to configure which Content-Types should be handled by
        /// WAF and which parser should be used. All Content-Types here are treated as 'allowed'. The order of entries matters. If
        /// the request's Content-Type matches an entry, its request body parser will run and no other parser will be invoked. Field
        /// introduced in 21.1.3. Maximum of 256 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "content_type_mappings")]
        public IList<NSXTALBWafContentTypeMappingType> ContentTypeMappings { get; set; }
        /// <summary>
        /// 0  For Netscape Cookies. 1  For version 1 cookies. Allowed values are 0-1. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_format_version")]
        public int? CookieFormatVersion { get; set; }
        /// <summary>
        /// Deprecated (Moved to WafPolicy). Enable Application Learning based rule updates on the WAF Profile. Rules will be
        /// programmed in dedicated WAF learning group. Field deprecated in 20.1.1. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_auto_rule_updates")]
        public bool? EnableAutoRuleUpdates { get; set; }
        /// <summary>
        /// Ignore request body parsing errors due to partial scanning. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_incomplete_request_body_error")]
        public bool? IgnoreIncompleteRequestBodyError { get; set; }
        /// <summary>
        /// Deprecated (Moved to WafPolicy). Parameters for tuning Application learning. Field deprecated in 20.1.1. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "learning_params")]
        public NSXTALBAppLearningParamsType LearningParams { get; set; }
        /// <summary>
        /// The maximum period of time WAF processing is allowed to take for a single request. A value of 0 (zero) means no limit
        /// and should not be chosen in production deployments. It is only used for exceptional situations where crashes of se_dp
        /// processes are acceptable. The behavior of the system if this time is exceeded depends on two other configuration
        /// settings, the WAF policy mode and the WAF failure mode. In WAF policy mode 'Detection', the request is allowed and
        /// flagged for both failure mode 'Closed' and 'Open'. In enforcement node, 'Closed' means the request is rejected, 'Open'
        /// means the request is allowed and flagged. Irrespective of these settings, no subsequent WAF rules of this or other
        /// phases will be executed once the maximum execution time has been exceeded. Allowed values are 0-5000. Field introduced
        /// in 17.2.12, 18.1.2. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "max_execution_time")]
        public int? MaxExecutionTime { get; set; }
        /// <summary>
        /// Deprecated (Moved to WafPolicy) Minimum confidence label required for auto rule updates. Enum options -
        /// CONFIDENCE_VERY_HIGH, CONFIDENCE_HIGH, CONFIDENCE_PROBABLE, CONFIDENCE_LOW, CONFIDENCE_NONE. Field deprecated in 20.1.1.
        /// Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "min_confidence")]
        public string? MinConfidence { get; set; }
        /// <summary>
        /// Limit CPU utilization for each regular expression match when processing rules. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "regex_match_limit")]
        public int? RegexMatchLimit { get; set; }
        /// <summary>
        /// Limit depth of recursion for each regular expression match when processing rules. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "regex_recursion_limit")]
        public int? RegexRecursionLimit { get; set; }
        /// <summary>
        /// WAF default action for Request Body Phase. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "request_body_default_action", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string RequestBodyDefaultAction { get; set; }
        /// <summary>
        /// WAF default action for Request Header Phase. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "request_hdr_default_action", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string RequestHdrDefaultAction { get; set; }
        /// <summary>
        /// WAF default action for Response Body Phase. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "response_body_default_action", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ResponseBodyDefaultAction { get; set; }
        /// <summary>
        /// WAF default action for Response Header Phase. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "response_hdr_default_action", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ResponseHdrDefaultAction { get; set; }
        /// <summary>
        /// WAF Restricted File Extensions. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "restricted_extensions")]
        public IList<string> RestrictedExtensions { get; set; }
        /// <summary>
        /// WAF Restricted HTTP Headers. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "restricted_headers")]
        public IList<string> RestrictedHeaders { get; set; }
        /// <summary>
        /// Whether or not to send WAF status in a request header to pool servers. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "send_status_header")]
        public bool? SendStatusHeader { get; set; }
        /// <summary>
        /// Maximum size for response body scanned by WAF. Allowed values are 1-32768. Field introduced in 17.2.1. Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "server_response_max_body_size")]
        public int? ServerResponseMaxBodySize { get; set; }
        /// <summary>
        /// WAF Static File Extensions. GET and HEAD requests with no query args and one of these extensions are allowed and not
        /// checked by the ruleset. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "static_extensions")]
        public IList<string> StaticExtensions { get; set; }
        /// <summary>
        /// HTTP status code used by WAF Positive Security Model when rejecting a request. Enum options - HTTP_RESPONSE_CODE_0,
        /// HTTP_RESPONSE_CODE_100, HTTP_RESPONSE_CODE_101, HTTP_RESPONSE_CODE_200, HTTP_RESPONSE_CODE_201, HTTP_RESPONSE_CODE_202,
        /// HTTP_RESPONSE_CODE_203, HTTP_RESPONSE_CODE_204, HTTP_RESPONSE_CODE_205, HTTP_RESPONSE_CODE_206, HTTP_RESPONSE_CODE_300,
        /// HTTP_RESPONSE_CODE_301, HTTP_RESPONSE_CODE_302, HTTP_RESPONSE_CODE_303, HTTP_RESPONSE_CODE_304, HTTP_RESPONSE_CODE_305,
        /// HTTP_RESPONSE_CODE_307, HTTP_RESPONSE_CODE_400, HTTP_RESPONSE_CODE_401, HTTP_RESPONSE_CODE_402, HTTP_RESPONSE_CODE_403,
        /// HTTP_RESPONSE_CODE_404, HTTP_RESPONSE_CODE_405, HTTP_RESPONSE_CODE_406, HTTP_RESPONSE_CODE_407, HTTP_RESPONSE_CODE_408,
        /// HTTP_RESPONSE_CODE_409, HTTP_RESPONSE_CODE_410, HTTP_RESPONSE_CODE_411, HTTP_RESPONSE_CODE_412, HTTP_RESPONSE_CODE_413,
        /// HTTP_RESPONSE_CODE_414, HTTP_RESPONSE_CODE_415, HTTP_RESPONSE_CODE_416, HTTP_RESPONSE_CODE_417, HTTP_RESPONSE_CODE_426,
        /// HTTP_RESPONSE_CODE_470, HTTP_RESPONSE_CODE_475, HTTP_RESPONSE_CODE_500, HTTP_RESPONSE_CODE_501, HTTP_RESPONSE_CODE_502,
        /// HTTP_RESPONSE_CODE_503, HTTP_RESPONSE_CODE_504, HTTP_RESPONSE_CODE_505. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "status_code_for_rejected_requests")]
        public string? StatusCodeForRejectedRequests { get; set; }
        /// <summary>
        /// The name of the request header indicating WAF evaluation status to pool servers. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "status_header_name")]
        public string? StatusHeaderName { get; set; }
        /// <summary>
        /// Block or flag XML requests referring to External Entities. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "xml_xxe_protection")]
        public bool? XmlXxeProtection { get; set; }
    }
}
