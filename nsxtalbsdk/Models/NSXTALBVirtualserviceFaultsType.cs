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
    public class NSXTALBVirtualserviceFaultsType 
    {
        /// <summary>
        /// Enable debug faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "debug_faults")]
        public bool? DebugFaults { get; set; }
        /// <summary>
        /// Enable pool server faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "pool_server_faults")]
        public bool? PoolServerFaults { get; set; }
        /// <summary>
        /// Enable VS scaleout and scalein faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_faults")]
        public bool? ScaleoutFaults { get; set; }
        /// <summary>
        /// Enable shared vip faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "shared_vip_faults")]
        public bool? SharedVipFaults { get; set; }
        /// <summary>
        /// Enable SSL certificate expiry faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_cert_expiry_faults")]
        public bool? SslCertExpiryFaults { get; set; }
        /// <summary>
        /// Enable SSL certificate status faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_cert_status_faults")]
        public bool? SslCertStatusFaults { get; set; }
    }
}
