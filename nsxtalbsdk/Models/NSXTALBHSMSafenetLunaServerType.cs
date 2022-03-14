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
    public class NSXTALBHSMSafenetLunaServerType 
    {
        /// <summary>
        /// Field introduced in 16.5.2,17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Password of the partition assigned to this client.
        /// </summary>
        [JsonProperty(PropertyName = "partition_passwd")]
        public string? PartitionPasswd { get; set; }
        /// <summary>
        /// Serial number of the partition assigned to this client. Field introduced in 16.5.2,17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "partition_serial_number")]
        public string? PartitionSerialNumber { get; set; }
        /// <summary>
        /// IP address of the Safenet/Gemalto HSM device.
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string RemoteIp { get; set; }
        /// <summary>
        /// CA certificate of the server.
        /// </summary>
        [JsonProperty(PropertyName = "server_cert", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ServerCert { get; set; }
    }
}
