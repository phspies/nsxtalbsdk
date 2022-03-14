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
        public NSXTALBVinfraVcenterConnectivityStatusType()
        {
        }
        /// <summary>
        /// cloud of VinfraVcenterConnectivityStatus.
        /// </summary>
        [JsonProperty(PropertyName = "cloud", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cloud { get; set; }
        /// <summary>
        /// datacenter of VinfraVcenterConnectivityStatus.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Datacenter { get; set; }
        /// <summary>
        /// vcenter of VinfraVcenterConnectivityStatus.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
