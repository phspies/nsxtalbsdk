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
    public class NSXTALBDebugVirtualServiceCaptureType 
    {
        /// <summary>
        /// Maximum allowed size of PCAP Capture File per SE. Max(absolute_size, percentage_size) will be final value. Set both to 0
        /// for avi default size. DOS, IPC and DROP pcaps not applicaple. Field introduced in 18.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "capture_file_size")]
        public NSXTALBCaptureFileSizeType CaptureFileSize { get; set; }
        /// <summary>
        /// Number of minutes to capture packets. Use 0 to capture until manually stopped. Special values are 0 - infinite. Unit is
        /// MIN.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Enable SSL session key capture. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssl_session_key_capture")]
        public bool? EnableSslSessionKeyCapture { get; set; }
        /// <summary>
        /// Number of files to maintain for SE pcap file rotation.file count set to 1 indicates no rotate. Allowed values are 1-10.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "file_count")]
        public int? FileCount { get; set; }
        /// <summary>
        /// Total number of packets to capture.
        /// </summary>
        [JsonProperty(PropertyName = "num_pkts")]
        public int? NumPkts { get; set; }
        /// <summary>
        /// Enable PcapNg for packet capture. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "pcap_ng")]
        public bool? PcapNg { get; set; }
        /// <summary>
        /// Number of bytes of each packet to capture. Use 0 to capture the entire packet. Allowed values are 64-1514. Special
        /// values are 0 - full capture. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "pkt_size")]
        public int? PktSize { get; set; }
    }
}
