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
    public class NSXTALBVSDataScriptType 
    {
        /// <summary>
        /// Event triggering execution of datascript. Enum options - VS_DATASCRIPT_EVT_HTTP_REQ, VS_DATASCRIPT_EVT_HTTP_RESP,
        /// VS_DATASCRIPT_EVT_HTTP_RESP_DATA, VS_DATASCRIPT_EVT_HTTP_LB_FAILED, VS_DATASCRIPT_EVT_HTTP_REQ_DATA,
        /// VS_DATASCRIPT_EVT_HTTP_RESP_FAILED, VS_DATASCRIPT_EVT_HTTP_LB_DONE, VS_DATASCRIPT_EVT_HTTP_AUTH,
        /// VS_DATASCRIPT_EVT_HTTP_POST_AUTH, VS_DATASCRIPT_EVT_TCP_CLIENT_ACCEPT, VS_DATASCRIPT_EVT_SSL_HANDSHAKE_DONE,
        /// VS_DATASCRIPT_EVT_CLIENT_SSL_PRE_CONNECT, VS_DATASCRIPT_EVT_CLIENT_SSL_CLIENT_HELLO, VS_DATASCRIPT_EVT_DNS_REQ,
        /// VS_DATASCRIPT_EVT_DNS_RESP, VS_DATASCRIPT_EVT_L4_REQUEST, VS_DATASCRIPT_EVT_L4_RESPONSE, VS_DATASCRIPT_EVT_MAX. Allowed
        /// in Basic(Allowed values- VS_DATASCRIPT_EVT_HTTP_REQ) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "evt", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Evt { get; set; }
        /// <summary>
        /// Datascript to execute when the event triggers.
        /// </summary>
        [JsonProperty(PropertyName = "script", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Script { get; set; }
    }
}
