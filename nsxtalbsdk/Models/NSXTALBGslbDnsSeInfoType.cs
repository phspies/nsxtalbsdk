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
    public class NSXTALBGslbDnsSeInfoType 
    {
        /// <summary>
        /// This field describes the fd download status to the SE. Field deprecated in 18.2.3. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fd_download")]
        public NSXTALBGslbDownloadStatusType FdDownload { get; set; }
        /// <summary>
        /// Geo files queue for sequencing files to SE. Field deprecated in 18.2.3. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fd_info")]
        public NSXTALBConfigInfoType FdInfo { get; set; }
        /// <summary>
        /// Service engine's fabric IP used to push Geo files. Field deprecated in 18.2.3. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// UUID of the service engine. Field deprecated in 18.2.3. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
