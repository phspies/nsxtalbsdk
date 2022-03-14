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
    public class NSXTALBCaptureIPCType 
    {
        /// <summary>
        /// Flow del probe filter for SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_del_probe")]
        public bool? FlowDelProbe { get; set; }
        /// <summary>
        /// Flow mirror add filter for SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_mirror_add")]
        public bool? FlowMirrorAdd { get; set; }
        /// <summary>
        /// Filter for all flow mirror SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_mirror_all")]
        public bool? FlowMirrorAll { get; set; }
        /// <summary>
        /// Flow mirror del filter for SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_mirror_del")]
        public bool? FlowMirrorDel { get; set; }
        /// <summary>
        /// Flow probe filter for SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_probe")]
        public bool? FlowProbe { get; set; }
        /// <summary>
        /// Filter for all flow probe SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_probe_all")]
        public bool? FlowProbeAll { get; set; }
        /// <summary>
        /// IPC batched filter for SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "ipc_batched")]
        public bool? IpcBatched { get; set; }
        /// <summary>
        /// Filter for incoming IPC request. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "ipc_rx_req")]
        public bool? IpcRxReq { get; set; }
        /// <summary>
        /// Filter for incoming IPC response. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "ipc_rx_res")]
        public bool? IpcRxRes { get; set; }
        /// <summary>
        /// Filter for outgoing IPC request. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "ipc_tx_req")]
        public bool? IpcTxReq { get; set; }
        /// <summary>
        /// Filter for outgoing IPC response. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "ipc_tx_res")]
        public bool? IpcTxRes { get; set; }
        /// <summary>
        /// Vs heart beat filter for SE IPC. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "vs_hb")]
        public bool? VsHb { get; set; }
    }
}
