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
    public class NSXTALBGslbDownloadStatusType 
    {
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// This field indicates the download state to a dns-vs(es) or a VS or a SE depending on the usage context. . Enum options -
        /// GSLB_DOWNLOAD_NONE, GSLB_DOWNLOAD_DONE, GSLB_DOWNLOAD_PENDING, GSLB_DOWNLOAD_ERROR. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
    }
}
