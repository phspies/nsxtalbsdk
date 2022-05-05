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
    public class NSXTALBVinfraPoolServerDeleteDetailsType 
    {
        /// <summary>
        /// pool_name of VinfraPoolServerDeleteDetails.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolName { get; set; }
        /// <summary>
        /// server_ip of VinfraPoolServerDeleteDetails.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        public IList<string> ServerIp { get; set; }
    }
}
