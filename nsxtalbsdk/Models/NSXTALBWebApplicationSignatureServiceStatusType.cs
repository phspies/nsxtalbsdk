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
    public class NSXTALBWebApplicationSignatureServiceStatusType 
    {
        /// <summary>
        /// If the last attempted update failed, this is a more detailed error message. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// The time when the Application Signature service last successfull attemped to update this object. It will be not update,
        /// if an error occurs during an update attempt. In this case, the error will be set. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "last_successful_update_check")]
        public NSXTALBTimeStampType LastSuccessfulUpdateCheck { get; set; }
        /// <summary>
        /// A timestamp field. It is used by the Application Signature Sync service to keep track of the current version. Field
        /// introduced in 21.1.1, 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_sync_timestamp")]
        public NSXTALBTimeStampType UpstreamSyncTimestamp { get; set; }
    }
}
