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
    public class NSXTALBHSMThalesRFSType 
    {
        public NSXTALBHSMThalesRFSType()
        {
        }
        /// <summary>
        /// IP address of the RFS server from where to sync the Thales encrypted private key.
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Port at which the RFS server accepts the sync request from clients for Thales encrypted private key. Allowed values are
        /// 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }
}
