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
    public class NSXTALBFailActionType 
    {
        /// <summary>
        /// Backup Pool when pool experiences a failure. Field deprecated in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "backup_pool")]
        public NSXTALBFailActionBackupPoolType BackupPool { get; set; }
        /// <summary>
        /// Local response to HTTP requests when pool experiences a failure.
        /// </summary>
        [JsonProperty(PropertyName = "local_rsp")]
        public NSXTALBFailActionHTTPLocalResponseType LocalRsp { get; set; }
        /// <summary>
        /// URL to redirect HTTP requests to when pool experiences a failure.
        /// </summary>
        [JsonProperty(PropertyName = "redirect")]
        public NSXTALBFailActionHTTPRedirectType Redirect { get; set; }
        /// <summary>
        /// Enables a response to client when pool experiences a failure. By default TCP connection is closed. Enum options -
        /// FAIL_ACTION_HTTP_REDIRECT, FAIL_ACTION_HTTP_LOCAL_RSP, FAIL_ACTION_CLOSE_CONN, FAIL_ACTION_BACKUP_POOL. Allowed in
        /// Basic(Allowed values- FAIL_ACTION_CLOSE_CONN,FAIL_ACTION_HTTP_REDIRECT) edition, Essentials(Allowed values-
        /// FAIL_ACTION_CLOSE_CONN) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
