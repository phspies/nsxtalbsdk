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
    public class NSXTALBVinfraVcenterConnectivityStatusType 
    {
        /// <summary>
        /// cloud of VinfraVcenterConnectivityStatus.
        /// </summary>
        [JsonProperty(PropertyName = "cloud")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cloud { get; set; }
        /// <summary>
        /// datacenter of VinfraVcenterConnectivityStatus.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Datacenter { get; set; }
        /// <summary>
        /// vcenter of VinfraVcenterConnectivityStatus.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
